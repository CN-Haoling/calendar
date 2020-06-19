using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using S22.Imap;


namespace MailControl
{
    public class MC
    {
        private User mailuser;
        private MailBox mailbox;
        private ImapClient userclient;
        public ImapClient Userclient { get{ return userclient; } }
        public List<MailMessage> NowMails { get; set; }
        public List<Mail> NowMailUS { get; set; }
        public List<Mail> NowMailALL { get; set; }
        public List<Mail> SENTMail { get; set; }
        public List<Mail> TRASHMail { get; set; }
        public MailBox Mailbox
        {
            get { return mailbox; }

        }

        public MC(User u)
        {
            mailuser = u;
            mailbox = new MailBox();
            Register(u);
            NowMailUS = new List<Mail>();
            NowMailALL = new List<Mail>();
            SENTMail = new List<Mail>();
            TRASHMail = new List<Mail>();
        }
        public void Register(User u)
        {

            userclient = new ImapClient(u.userhost, 993, u.userAdd, u.userCode, AuthMethod.Login, true);

        }
        public void PullMessage(int action)
        {
            switch (action)
            {
                case 0:
                    NowMailUS = new List<Mail>();
                    mailbox.usMailID = userclient.Search(SearchCondition.Unseen());
                    mailbox.usMessages = userclient.GetMessages(mailbox.usMailID, FetchOptions.HeadersOnly);
                    int countu = 0;
                    foreach (MailMessage msg in mailbox.usMessages)
                    {
                        uint id = mailbox.usMailID.ToList()[countu];
                        countu++;
                        Mail m = new Mail(msg, id);
                        NowMailUS.Add(m);
                        int countDist = 0;
                        bool isexist = false;
                        foreach (Mail m1 in NowMailALL)
                        {
                            if (m1.Id == m.Id)
                            {
                                isexist = true;
                                break;
                            }
                            else
                            {
                                countDist++;
                            }
                            if (NowMailALL.Count == countDist && isexist == false)
                            {
                                NowMailALL.Add(m); break;
                            }

                        }
                    }
                    exportXML(0);
                    exportXML(1);
                    break;
                case 1:
                    mailbox.AllMailID = userclient.Search(SearchCondition.All());
                    mailbox.Messages = userclient.GetMessages(mailbox.AllMailID, FetchOptions.HeadersOnly);
                    int countall = 0;
                    foreach (MailMessage msg in mailbox.Messages)
                    {
                        uint id = mailbox.AllMailID.ToList()[countall];
                        countall++;
                        Mail m = new Mail(msg, id);
                        NowMailALL.Add(m);

                    }
                    exportXML(1);//
                    break;
                case 2:
                    mailbox.SentID = userclient.Search(SearchCondition.All(), "Sent Messages");
                    mailbox.sentMessages = userclient.GetMessages(mailbox.SentID, FetchOptions.HeadersOnly, false, "Sent Messages");
                    int countsent = 0;
                    foreach (MailMessage msg in mailbox.sentMessages)
                    {
                        uint id = mailbox.SentID.ToList()[countsent];
                        countsent++;
                        Mail m = new Mail(msg, id);
                        SENTMail.Add(m);

                    }
                    exportXML(2);//
                    break;
                case 3:
                    int countdel = 0;
                    mailbox.DeletedID = userclient.Search(SearchCondition.All(), "Deleted Messages");
                    mailbox.DeletedMessages = userclient.GetMessages(mailbox.DeletedID, FetchOptions.HeadersOnly, false, "Deleted Messages");
                    foreach (MailMessage msg in mailbox.DeletedMessages)
                    {
                        uint id = mailbox.DeletedID.ToList()[countdel];
                        countdel++;
                        Mail m = new Mail(msg, id);
                        TRASHMail.Add(m);

                    }
                    exportXML(3);
                    break;
            }

        }
        public void showmessages(int action)
        {
            switch (action)
            {
                case 0:
                    try
                    {
                        NowMails = mailbox.usMessages.ToList();
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    break;
                case 1:
                    try
                    {
                        NowMails = mailbox.Messages.ToList();
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }

                    break;

            }



        }
        public void download(MailMessage msg)
        {

            string name = msg.Subject;
            Console.WriteLine(name);
            string result = name.Replace("<", "");
            result = result.Replace(">", "x");
            result = result.Replace("/", "x");
            result = result.Replace("|", "x");
            result = result.Replace(":", "x");
            result = result.Replace("*", "x");
            //result = result.Replace("\\", "x");
            result = result.Replace("?", "");
            result = result.Replace("=", "");
            Console.WriteLine(result);/// \ : * " < >  ？
            File.WriteAllText(result + ".html", msg.Body, Encoding.UTF8);



        }
        public void exportAttachments(Attachment a)
        {

            if (a != null)
            {
                var content = a.ContentStream;
                string name = a.Name;
                Console.WriteLine(name);
                string result = name.Replace("<", "");
                result = result.Replace(">", "x");
                result = result.Replace("/", "x");
                result = result.Replace("|", "x");
                result = result.Replace(":", "x");
                result = result.Replace("*", "x");
                //result = result.Replace("\\", "x");
                result = result.Replace("?", "");
                result = result.Replace("=", "");
                Console.WriteLine(result);/// \ : * " < >  ？
                FileStream fs = new FileStream(result, FileMode.Create, FileAccess.Write);
                a.ContentStream.CopyTo(fs);

                fs.Close();

            }

        }
        public void exportAttachments(Attachment a, string path)
        {

            if (a != null)
            {
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                a.ContentStream.CopyTo(fs);

                fs.Close();

            }

        }

        public List<Mail> QueryBySender(string x, List<Mail> dest)
        {

            try
            {
                var Query = dest
              .Where(mail => mail.From.Contains(x));
                return Query.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return null;




        }
        public List<Mail> QueryBySub(string x, List<Mail> dest)
        {
            var Query = dest
              .Where(message => message.Subject.Contains(x))
              ;

            return Query.ToList();



        }
        public void exportXML(int a)
        {
            string[] cases = { "US", "ALL", "SENT", "TRASH" };
            FileStream fs = new FileStream(mailuser.username + cases[a] + ".xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mail>));


            switch (a)
            {
                case 0:

                    xs.Serialize(fs, NowMailUS);
                    break;
                case 1:
                    xs.Serialize(fs, NowMailALL);
                    break;
                case 2:
                    xs.Serialize(fs, SENTMail);
                    break;
                case 3:
                    xs.Serialize(fs, TRASHMail);
                    break;
            }
            fs.Close();



        }
        public void init(int a)
        {
            string[] cases = { "US", "ALL", "SENT", "TRASH" };
            try
            {
                FileStream fs1 = new FileStream(mailuser.username + cases[a] + ".xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs1 = new XmlSerializer(typeof(List<Mail>));
                List<Mail> p = (List<Mail>)xs1.Deserialize(fs1);
                switch (a)
                {
                    case 0:
                        NowMailUS = p;
                        break;
                    case 1:
                        NowMailALL = p;
                        break;
                    case 2:
                        SENTMail = p;
                        break;
                    case 3:
                        TRASHMail = p;
                        break;
                }

                fs1.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public MailMessage PullMessage(uint id, string Box)
        {
            MailMessage msg = userclient.GetMessage(id, false, Box);
            return msg;
        }
        public User getUser()
        {
            return mailuser;

        }
        public void reconnect()
        {
            Register(mailuser);
        }
        public void deleteFromList(List<Mail> a, uint uid)
        {
            foreach (Mail mail in a)
            {
                if (uid == mail.Id)
                {
                    a.Remove(mail);
                    break;

                }
            }
        }
        public void delete(List<uint> uids, List<Mail> MLIST, int action)
        {
            //List<Mail>[] lists = { null,NowMailUS, SENTMail, NowMailALL, TRASHMail,  };
            long[] uid = new long[uids.Count];
            int count = 0;
            foreach (uint axx in uids)
            {
                if (MLIST == NowMailUS)
                {
                    deleteFromList(MLIST, axx);
                    deleteFromList(NowMailALL, axx);
                    exportXML(0);
                    exportXML(1);
                }
                else if (MLIST == NowMailALL)
                {
                    deleteFromList(MLIST, axx);
                    deleteFromList(NowMailUS, axx);
                    exportXML(0);
                    exportXML(1);

                }
                else
                {
                    deleteFromList(MLIST, axx);
                    exportXML(2);
                    exportXML(3);
                }
                long dest = Convert.ToInt64(axx);
                uid[count] = dest;
                count++;

            }

            var client = new ImapX.ImapClient("imap.qq.com");
            if (client.Connect())
            {
                long[] uida = uid;
                int a = 1;
                if (client.Login("791331362@qq.com", "akkvwbhjbzcnbfgf"))
                {
                    Console.WriteLine("login successful");
                    var messages = client.Folders[action].Search(uid);//[2].Search();//0 no 1 receive 2sent 3caogao 4deleted 5trash
                    foreach (ImapX.Message msg in messages)
                    {
                        msg.MoveTo(client.Folders[4]);
                    }


                }
            }


        }
        public void markStar(List<uint> list)
        {
            foreach (uint uid in list)
            {
                var a = userclient.GetMessageFlags(uid);
                MessageFlag[] flag = { MessageFlag.Flagged };
                userclient.AddMessageFlags(uid, "INBOX", flag);
                a = userclient.GetMessageFlags(uid);
            }
        }
        public void UnmarkStar(List<uint> list)
        {
            foreach (uint uid in list)
            {
                var a = userclient.GetMessageFlags(uid);
                MessageFlag[] flag = { MessageFlag.Flagged };
                userclient.RemoveMessageFlags(uid, "INBOX", flag);
                a = userclient.GetMessageFlags(uid);
            }
        }
        public void markUnSeen(List<uint> list)
        {
            foreach (uint uid in list)
            {
                MessageFlag[] flag = { MessageFlag.Seen };
                userclient.RemoveMessageFlags(uid, "INBOX", flag);
            }
        }
        public void markSeen(List<uint> list)
        {
            foreach (uint uid in list)
            {
                MessageFlag[] flag = { MessageFlag.Seen };
                userclient.AddMessageFlags(uid, "INBOX", flag);
            }
        }
        public void delete(uint uids)
        {

            long axx = Convert.ToInt64(uids);
            long[] uid = new long[1];
            uid[0] = axx;
            var client = new ImapX.ImapClient("imap.qq.com");
            if (client.Connect())
            {

                int a = 1;
                if (client.Login("791331362@qq.com", "akkvwbhjbzcnbfgf"))
                {
                    Console.WriteLine("login successful");
                    var messages = client.Folders[1].Search(uid);//[2].Search();
                    messages[0].Remove();

                }
            }
        }
    }
}

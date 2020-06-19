using System;

using S22.Imap;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.IO;
using System.Data.SQLite;



//akkvwbhjbzcnbfgf
namespace MailControl
{
    class Program {
       
        static void Main(string[] args) {
            
            User me = new User("lhl", "791331362@qq.com", "akkvwbhjbzcnbfgf", "imap.qq.com");
            MC mc = new MC(me);
            
            mc.init(0);
            //mc.PullMessage(2);
            //mc.showmessages(0);
           // object a = mc.SENTMail;
            Users users = new Users();
            users.init();
            users.getAll();
            var  a = users.myUsers;
            mc.delete(1112);

            

            //me.usercontrol.receiveUnseen();

            //me.usercontrol.export(me.usercontrol.Usmessages);
            //me.usercontrol.attachment(me.usercontrol.Usmessages);

        }
    }

    }


/*
 * 
 * User user1 = new User();
string hostname = "imap.qq.com",
   username = "791331362@qq.com", password = "akkvwbhjbzcnbfgf";
            // The default port for IMAP over SSL is 993.
            using (ImapClient client = new ImapClient(hostname, 993, username, password, AuthMethod.Login, true))
            {
                DateTime de = new DateTime(2020, 5, 1, 20, 20, 6);
// IEnumerable<uint> uids = client.Search(SearchCondition.Unseen());
IEnumerable<uint> uids = client.Search(SearchCondition.SentSince(new DateTime(2020, 5, 1)));
// Download mail messages from the default mailbox.

IEnumerable<MailMessage> messages = client.GetMessages(uids);

int count = 0;
                foreach (MailMessage msg in messages) {
                    
                    string date = DateTime.Parse(msg.Headers["Date"]).ToString();
Console.WriteLine(date);
                    string content = msg.Body;
string name = count.ToString();
count++;
                    File.WriteAllText(name, content, Encoding.UTF8);
                }
     
                Console.WriteLine("We are connected!");
            }
        }*/
        
    /*
     * class Program
    {
        
           static void Main(string[] args)
        {
           // User user1 = new User();
            string hostname = "imap.qq.com",
               username = "791331362@qq.com", password = "akkvwbhjbzcnbfgf";
            // The default port for IMAP over SSL is 993.
             
            using (ImapClient client = new ImapClient(hostname, 993, username, password, AuthMethod.Login, true))
            {
                DateTime de = new DateTime(2020, 5, 1, 20, 20, 6);
                // IEnumerable<uint> uids = client.Search(SearchCondition.Unseen());
                 
                IEnumerable<uint> uids = client.Search(SearchCondition.Unseen());
                // Download mail messages from the default mailbox.

                //IEnumerable<MailMessage> messages = client.GetMessages(uids,FetchOptions.HeadersOnly);
                IEnumerable<MailMessage> messages = client.GetMessages(uids);

                int count = 0;
                foreach (MailMessage msg in messages)
                {
                    MailMessage message1 = msg;
                    //string sender = ; //msg.From.ToString();
                   /* List<Attachment> m =  message1.Attachments.ToList();
                    
                    //FileStream s = new FileStream("test.dat",FileMode.Create,FileAccess.Write);

                    long a = m[0].ContentStream.Length;//
                    int.TryParse(a.ToString(),out int length );
                    byte[] byteArrayRead = new byte[length];
                    m[0].ContentStream.Read(byteArrayRead, 0, length);
                   // s.Write(byteArrayRead, 0, length);
                    //byte[] byteArray = Convert.FromBase64String(base64String);
                    Stream sc = m[0].ContentStream;
                    StreamReader reader = new StreamReader(m[0].ContentStream);
                    string text = reader.ReadToEnd();
                    //Console.WriteLine(sender);
                    string content = msg.Body;
                    string name = count.ToString();
                    count++;
                    //s.Flush();

                    File.WriteAllText(name, content, Encoding.UTF8);
                }

                Console.WriteLine("We are connected!");
            }
        }*/



    
     
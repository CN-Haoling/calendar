using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailControl
{
    [Serializable]
    public class Mail

    {
        private string mailBody;
        public string MailBody
        {
            get { return mailBody; }
            set { mailBody = value; }
        }
        private string subject;
        public string Subject

        {
            get { return subject; }
            set { subject = value; }
        }
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private string from;
        public string From
        {
            set { from = value; }
            get { return from; }

        }
        private uint uid;
        public uint Id
        {
            set { uid = value; }
            get { return uid; }

        }
        // private MemoryStream ms = new MemoryStream();
        //public MemoryStream Att {
        //   get { return ms; }
        //   set { ms = value; }

        // }
        //Attach attach;
        public Mail() { }
        public Mail(MailMessage msg, uint id)
        {
            int dates;
            int count = 0;
            mailBody = msg.Body;
            subject = msg.Subject;
            if (msg.From != null)
            {
                from = msg.From.Address;
            }
            uid = id;
            // if (msg.Attachments.Count != 0) 
            //{ msg.Attachments[0].ContentStream.CopyTo(ms); };
            foreach (string s in msg.Headers.AllKeys)
            {


                if (s == "Date")
                {
                    dates = count;
                    var dat = msg.Headers[count];
                    date = DateTime.Parse(dat);


                }
                count++;
            }

        }
    }
}

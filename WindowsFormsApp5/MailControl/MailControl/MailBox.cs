using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailControl
{
    public class MailBox
    {
        private IEnumerable<MailMessage> messages;
        private IEnumerable<MailMessage> usmessages;
        private IEnumerable<MailMessage> sentmessages;
        public IEnumerable<MailMessage> Messages
        {
            get { return messages; }
            set { messages = value; }
        }
        public IEnumerable<MailMessage> usMessages
        {
            get { return usmessages; }
            set { usmessages = value; }
        }
        public IEnumerable<MailMessage> sentMessages
        {
            get { return sentmessages; }
            set { sentmessages = value; }
        }
        public IEnumerable<MailMessage> DeletedMessages
        {
            get;
            set;
        }
        public IEnumerable<uint> usMailID { get; set; }
        public IEnumerable<uint> AllMailID { get; set; }
        public IEnumerable<uint> TrashID { get; set; }
        public IEnumerable<uint> SentID { get; set; }
        public IEnumerable<uint> DeletedID { get; set; }
        public MailBox()
        {



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailControl
{
    class Box
    {
        private IEnumerable<Mail> messages;
        private IEnumerable<Mail> usmessages;
        //private IEnumerable<MailMessage> allmessages;
        public IEnumerable<Mail> Messages
        {
            get { return messages; }
            set { messages = value; }
        }
        public IEnumerable<Mail> usMessages
        {
            get { return usmessages; }
            set { usmessages = value; }
        }
        public IEnumerable<Mail> allMessages
        {
            get { return messages; }
            set { messages = value; }
        }
        public IEnumerable<uint> usMailID { get; set; }
        public IEnumerable<uint> AllMailID { get; set; }

        public Box()
        {



        }
    }
}

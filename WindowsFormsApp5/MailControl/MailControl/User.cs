using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S22.Imap;


namespace MailControl
{
    [Serializable]
    public class User
    {
        public string username { get; set; }
        public string userAdd { get; set; }
        public string userCode { get; set; }
        public string userhost { get; set; }
        //ImapClient client;
        //public Mailcontrol usercontrol;
        public User() { }
        public User(string username,string add,string code,string hostname) {
            this.username = username;
            this.userAdd = add;
            this.userCode = code;
            this.userhost = hostname;
            //client = new ImapClient(hostname, 993, userAdd, userCode, AuthMethod.Login, true);
            //usercontrol = new Mailcontrol(client);
        }

        
        
    }
}

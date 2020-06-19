using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MailControl
{
    class Attach
    {
        List<FileStream> content;
        public Attach(FileStream a) {
            content.Add(a);


        }
    }
}

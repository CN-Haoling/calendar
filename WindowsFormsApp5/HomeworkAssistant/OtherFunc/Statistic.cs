using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MailControl;
using S22.Imap;
using System.Net.Mail;

namespace HomeworkAssistant
{
    class Statistic
    {
        public static MC mc;




        //下载附件,并返回学号集合
        public static List<string> DownloadAttachments(Tasks task, string path)
        {
            UpdateMailbox(task);
            Regex regex = new Regex(@"^(?<id>\d{13})-(.*)-" + task.Name+"$");
            List<MailMessage> messages = mc.Mailbox.Messages.ToList();

            List<MailMessage> HwMail = new List<MailMessage>();//过滤获得的mailmsg
            List<string> StuId = new List<string>();           //过滤获得的学号集合

            messages.ForEach(x =>
            {
                Match match = regex.Match(x.Subject);
                if (match.Success)
                {
                    HwMail.Add(x);
                    StuId.Add(match.Groups["id"].Value);
                }

            }
            );
            //下载附件到指定路径
            HwMail.ForEach(x =>
            {
                if (x.Attachments.FirstOrDefault() != null) {
                    mc.exportAttachments(x.Attachments.FirstOrDefault(), path + @"\" + x.Attachments.FirstOrDefault().Name);
                    }
                }
            );
            return StuId;
        }

        //过滤到的学号
            public static List<string> GetFilteredStuId(Tasks task)
        {
            UpdateMailbox(task);
            Regex regex = new Regex(@"^(?<id>\d{13})-(.*)-" + task.Name + "$");
            List<MailMessage> messages = mc.Mailbox.Messages.ToList();

            List<MailMessage> HwMail = new List<MailMessage>();//过滤获得的mailmsg
            List<string> StuId = new List<string>();           //过滤获得的学号集合

            messages.ForEach(x =>
            {
                Match match = regex.Match(x.Subject);
                if (match.Success)
                {
                    HwMail.Add(x);
                    StuId.Add(match.Groups["id"].Value);
                }

            }
            );
           
            return StuId;
        }

        //初步过滤
        private static void UpdateMailbox(Tasks task)
        {
            //获得ddl之前发送的作业
            mc.Mailbox.usMailID = mc.Userclient.Search(SearchCondition.Unseen().And(SearchCondition.SentBefore(task.DDL)));
            // mc.Mailbox.Messages = mc.Userclient.GetMessages(mc.Mailbox.usMailID);
            //获得大小超过2KB的作业，以过滤空作业
            mc.Mailbox.Messages  = mc.Userclient.GetMessages(mc.Mailbox.usMailID,
                     (Bodypart part) => {
                        if (part.Disposition.Type == ContentDispositionType.Attachment)
                         {
                             Int64 TwoKilobytes = (1024  * 2);
                             if (part.Size < TwoKilobytes)
                             {                         
                                return false;
                             }
                         }
                        return true;
                     }
                 );
        }



        /*
        //获得仅由学号组成的List
        public static List<string> StuIdFilter(Tasks task)
        {
            string regex = @"^(?<id>\d{13})";
            List<string> subjects = Filter(task);
            List<string> StuId = new List<string>();

            subjects.ForEach(x =>
            {
                Match match = Regex.Match(x, regex);
                StuId.Add(match.Groups["id"].Value);
            }
            );
            return StuId;

        }        
        //过滤，获得指定的作业邮件的Subject集合
        private static List<string> Filter(Tasks task)
        {
            Regex regex = new Regex(@"^(\d{13})-(.*)-" + task.Name);
            List<string> mailSubjects = GetTitleList(mc.Mailbox.Messages.ToList());

            List<string> HwSubjects = new List<string>();
            mailSubjects.ForEach(x => { if (regex.IsMatch(x)) HwSubjects.Add(x); });//获得符合格式的邮件主题
            return HwSubjects;
        }

        //获得由邮件主题组成的List，用于筛选出作业邮件
        private static List<string> GetTitleList(List<MailMessage> messages)
        {
            List<string> temp = new List<string>();
            messages.ForEach(x => temp.Add(x.Subject));
            return temp;
        }
        //过滤，获得指定的作业邮件的Subject集合
        public static List<string> Filter(Tasks task)
        {
            Regex regex = new Regex(@"^(\d{13})-(.*)-" + task.Name);
            mc.Mailbox.MailID = mc.userclient.Search(SearchCondition.Unseen().And(SearchCondition.Subject(task.Name)));//获取在ddl之前发送且包含作业名的邮件UID
            mc.Mailbox.Messages = mc.userclient.GetMessages(mc.Mailbox.MailID);               
            List<string> mailSubjects = GetTitleList(mc.Mailbox.Messages.ToList());

            List<string> HwSubjects = new List<string>();
            mailSubjects.ForEach(x => { if (regex.IsMatch(x)) HwSubjects.Add(x); });//获得符合格式的邮件主题
            return HwSubjects;
        }


        //返回由task的DDL和作业名限制的搜索条件
        private static SearchCondition GetSearchCondition(Tasks task,List<string> HwSubjects) 
        {
            var a = SearchCondition.SentBefore(task.DDL).And(SearchCondition.Unseen());
            var b = new SearchCondition();
            HwSubjects.ForEach(x => b=b.Or(SearchCondition.Subject(x)));
            return a.And(b);
        }
    }*/
    }
}

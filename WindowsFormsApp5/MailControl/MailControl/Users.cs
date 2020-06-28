using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MailControl
{
    public class Users
    {
        SqLiteHelper userdb;
        List<User> users = new List<User>();
        public List<User> myUsers
        {
            get { return users; }

        }
        public void init()
        {
            userdb = new SqLiteHelper(@"mydb.db");//\C#work\WindowsFormsApp5\WindowsFormsApp5\bin\Debug\mydb.db
            //userdb.CreateTable("tableA", new string[] { "username", "userAdd", "userCode", "userhost" }, new string[] { "TEXT", "TEXT", "TEXT", "TEXT" });

            //userdb.InsertValues("tableA", new string[] { "lhl", "791331362@qq.com", "akkvwbhjbzcnbfgf", "imap.qq.com" });
            //userdb.InsertValues("tableA", new string[] { "yyf", "1097506252@qq.com", "pxuudslckbavffei", "imap.qq.com" });
            SQLiteDataReader reader = userdb.ReadFullTable("tableA");
            while (reader.Read())
            {
                //读取ID
                Console.WriteLine("" + reader.GetString(reader.GetOrdinal("username")));
                //读取Name
                Console.WriteLine("" + reader.GetString(reader.GetOrdinal("userAdd")));
                //读取Age
                Console.WriteLine("" + reader.GetString(reader.GetOrdinal("userCode")));
                //读取Email
                Console.WriteLine(reader.GetString(reader.GetOrdinal("userhost")));
            }


        }
        public List<User> getAll()
        {
            users = new List<User>();
            var table = userdb.ReadFullTable("tableA");
            while (table.Read())
            {
                //读取ID
                string username = table.GetString(table.GetOrdinal("username"));
                //读取Name
                string useradd = table.GetString(table.GetOrdinal("userAdd"));
                //读取Age
                string usercode = table.GetString(table.GetOrdinal("userCode"));
                //读取Email
                string userhost = table.GetString(table.GetOrdinal("userhost"));
                User user = new User(username, useradd, usercode, userhost);
                users.Add(user);
            }
            return users;
            
        }
        public void insert(User a)
        {
            string username = a.username;
            string add = a.userAdd;
            string code = a.userCode;
            string hostname = a.userhost;

            userdb.InsertValues("tableA", new string[] { username, add, code, hostname });
        }
        public List<User> Quaryname(string name)
        {

            var Query = users
                  .Where(message => message.username.Equals(name))
              ;

            return Query.ToList();
        }

    }
}

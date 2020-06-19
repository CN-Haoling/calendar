using System;
using System.Drawing;
using System.Windows.Forms;
using MailControl;
using WindowsFormsApp5;
namespace WindowsFormsApp5
{
    public partial class mainform : Form
    {
        User mainuser;
        public mainform(User a)
        {
            InitializeComponent();
            
            x = this.Width;
            y = this.Height;
            setTag(this);
            panelparent.AutoScroll = true;
            mainuser = a;


        }

        private void panelparent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Calendar.MainCalendar calender  = new Calendar.MainCalendar(true);
            calender.TopLevel = false;
            calender.FormBorderStyle = FormBorderStyle.None;
            calender.Dock = DockStyle.Fill;

            //清空Panel里面的控件

            this.panelparent.Controls.Clear();

            //加入控件

            this.panelparent.Controls.Add(calender);
            //tabPage1.Controls.Add(calender);
            //让窗体显示

            calender.Show();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(mainuser);
            CloseFrm();
            OpenFrm(form);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            send transform = new send(mainuser);
            CloseFrm();
            OpenFrm(transform);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        //调整窗口大小等比例缩放
        private float x;//定义当前窗体的宽度
        private float y;//定义当前窗体的高度
        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                //获取控件的Tag属性值，并分割后存储字符串数组
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    //根据窗体缩放的比例确定控件的值
                    con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * newx);//宽度
                    con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * newy);//高度
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * newx);//左边距
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * newy);//顶边距
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }
            }
        }
        private void mainform_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            setControls(newx, newy, this);
            panelparent.Refresh();
        }

       
        private void CloseFrm()
        {
            //palParent为panel控件
            foreach (Control item in this.panelparent.Controls)
            {
                if (item is Form)
                {
                    Form form = (Form)item;
                    form.Close();
                    this.panelparent.Controls.Remove(form);
                }
            }
        }
        private void OpenFrm(Form frm)
        {
            frm.TopLevel = false;//取消非顶级窗体
            frm.WindowState = FormWindowState.Maximized;//将窗体最大化
            frm.FormBorderStyle = FormBorderStyle.None;//设为无边框
            frm.Parent = this.panelparent;//指定该窗体的父窗体
            frm.Show();//展示窗体
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkAssistant
{
    public partial class HwPublisher : Form
    {
        public Tasks CurrentTask { get; set; }

        public string HwName { get; set; }

        public string Format { get; set; }

       // public DateTime Deadline { get; set; }


        public HwPublisher()
        {
            InitializeComponent();            
        }

        private void HwPublisher_Load(object sender, EventArgs e)
        {
            txt_hwName.DataBindings.Add("Text", this, "HwName");
            cbo_Format.DataBindings.Add("Text", this, "Format");
            //dateTimePicker.DataBindings.Add("Value", this, "Deadline"); 
        }

        private void btn_Publish_Click(object sender, EventArgs e)
        {
            try
            {
                Tasks task = new Tasks(HwName, dateTimePicker.Value.Date, Format);
                task.AddDetails();
                TaskService.Add(task);
                MessageBox.Show("发布成功！");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"添加失败:{ ex.Message}");
            }
        }
    }
}

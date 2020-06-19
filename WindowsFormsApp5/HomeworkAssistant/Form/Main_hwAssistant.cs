using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailControl;

namespace HomeworkAssistant
{
    public partial class Main_hwAssistant : Form
    {
        public Main_hwAssistant()
        {
            InitializeComponent();
        }

        public Main_hwAssistant(MC mc)
        {
            InitializeComponent();
            Statistic.mc = mc;
        }

        private void btn_Class_Click(object sender, EventArgs e)
        {
            classInfo newform = new classInfo();
            newform.Show();
        }

        private void btn_hmPublish_Click(object sender, EventArgs e)
        {
            HwPublisher newform = new HwPublisher();
            if (newform.ShowDialog() == DialogResult.OK) return;
        }

        private void btn_hwCheck_Click(object sender, EventArgs e)
        {
            HwChecker newform = new HwChecker();
            newform.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interruption_Expt
{
    public partial class Form1 : Form
    {
        // private Timer timer1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Interval = 10; // 設置間隔為 10 毫秒
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Left += 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); // 啟動計時器
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 在這裡添加發送信號的邏輯
            Console.WriteLine("信號已發送");
            pictureBox1_Click(sender, e);
        }
    }
}

using System.Diagnostics;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/mintchocobubbletea",
                UseShellExecute = true
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.제주도;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요! 제 디지털 명합입니다.");
        }
    }
}

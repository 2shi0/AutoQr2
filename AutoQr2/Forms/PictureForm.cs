using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AutoQr2
{
    public partial class PictureForm : Form
    { 
        private QRAuthClass QRAuthClass = new QRAuthClass();

        private string gen1, gen2, gen3, gen4;

        public PictureForm()
        {
            InitializeComponent();
        }

        private void PictureForm_Load(object sender, EventArgs e)
        {
            PictureBox.ImageLocation = "test-img.jpg";

            this.Text = Application.ProductName;
            timer1.Interval = 1000;
            timer1.Enabled = true;

            DateTime d = DateTime.Now;
            label1.Text = d.ToString("HH:mm:ss");

            gen1 = Properties.Settings.Default.gen1;
            gen2 = Properties.Settings.Default.gen2;
            gen3 = Properties.Settings.Default.gen3;
            gen4 = Properties.Settings.Default.gen4;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime d = DateTime.Now;
            label1.Text = d.ToString("HH:mm:ss");

            string t = d.ToString("HHmmss");

            try
            {
                switch (t)
                {
                    //1限
                    case "085500":
                        if (!string.IsNullOrEmpty(gen1))
                        {
                            PictureBox.ImageLocation = gen1;
                        }
                        break;
                    case "085505":
                        if (!string.IsNullOrEmpty(gen1))
                        {
                            QRAuthClass.Auth();
                            PictureBox.ImageLocation = "test-img.jpg";
                        }
                        break;
                    //2限
                    case "103500":
                        if (!string.IsNullOrEmpty(gen2))
                        {
                            PictureBox.ImageLocation = gen2;
                        }
                        break;
                    case "103505":
                        if (!string.IsNullOrEmpty(gen2))
                        {
                            QRAuthClass.Auth();
                            PictureBox.ImageLocation = "test-img.jpg";
                        }
                        break;
                    //3限
                    case "132500":
                        if (!string.IsNullOrEmpty(gen3))
                        {
                            PictureBox.ImageLocation =gen3;
                        }
                        break;
                    case "132505":
                        if (!string.IsNullOrEmpty(gen3))
                        {
                            QRAuthClass.Auth();
                            PictureBox.ImageLocation = "test-img.jpg";
                        }
                        break;
                    //4限
                    case "150500":
                        if (!string.IsNullOrEmpty(gen4))
                        {
                            PictureBox.ImageLocation = gen4;
                        }
                        break;
                    case "150505":
                        if (!string.IsNullOrEmpty(gen4))
                        {
                            QRAuthClass.Auth();
                            PictureBox.ImageLocation = "test-img.jpg";
                        }
                        break;
                }

            }
            catch
            {
                using (Form dummyForm = new Form())
                {
                    dummyForm.TopMost = true;
                    MessageBox.Show(dummyForm, "画像がないよ～（涙）");
                    dummyForm.TopMost = false;
                }
            }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            QRAuthClass.Auth();

            DialogResult result = MessageBox.Show("ブラウザ上のカメラにカラーバーが表示されましたか？","", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("正常に動作しています。");
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                DialogResult result2 = MessageBox.Show("", "ブラウザ上のカメラは真っ黒ですか？", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("OBSのソースから、このソフトのウインドウをキャプチャしてください。");
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    MessageBox.Show("接続しているUSBウェブカメラを取り外すか無効にし、再起動してからもう一度実行してみてください");
                }
            }
        }
    }
}

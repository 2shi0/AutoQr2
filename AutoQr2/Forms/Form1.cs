using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AutoQr2
{
    public partial class Form1 : Form
    {
        private SeleniumClass SeleniumClass = new SeleniumClass();

        private ActivateCheckClass ActivateCheckClass = new ActivateCheckClass();

        private FileOpenClass FileOpenClass = new FileOpenClass();

        private ObsControlClass ObsControlClass = new ObsControlClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //アクティベーションチェック
            ActivateCheckClass.ActivateCheck();

            //フォーム記憶ロード
            this.IdTextBox.Text = Properties.Settings.Default.IdTextBox;
            this.PassTextBox.Text = Properties.Settings.Default.PassTextBox;
            this.ObsPathTextBox.Text = Properties.Settings.Default.ObsPathTextBox;
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            //入力チェック
            if (!TextInputCheck()) return;

            //ボタン封印
            RunButton.Enabled = false;

            //OBS起動
            ObsControlClass.Run(ObsPathTextBox.Text);

            //ファイルパスの受け渡し
            Properties.Settings.Default.ID = this.IdTextBox.Text;
            Properties.Settings.Default.PASS = this.PassTextBox.Text;

            Properties.Settings.Default.gen1 = this.Gen1TextBox.Text;
            Properties.Settings.Default.gen2 = this.Gen2TextBox.Text;
            Properties.Settings.Default.gen3 = this.Gen3TextBox.Text;
            Properties.Settings.Default.gen4 = this.Gen4TextBox.Text;


            //処理
            PictureForm PictureForm = new PictureForm();
            PictureForm.Show();

            //ボタン開放
            RunButton.Enabled = true;

        }

        //ファイル参照
        private void Gen1Ref_Click(object sender, EventArgs e)
        {
            Gen1TextBox.Text = FileOpenClass.ImgFileReference();
        }

        private void Gen2Ref_Click(object sender, EventArgs e)
        {
            Gen2TextBox.Text = FileOpenClass.ImgFileReference();
        }

        private void Gen3Ref_Click(object sender, EventArgs e)
        {
            Gen3TextBox.Text = FileOpenClass.ImgFileReference();
        }

        private void Gen4Ref_Click(object sender, EventArgs e)
        {
            Gen4TextBox.Text = FileOpenClass.ImgFileReference();
        }
        private void ObsPathRef_Click(object sender, EventArgs e)
        {
            ObsPathTextBox.Text = FileOpenClass.ObsPathReference();
        }
        //ゲッターロボ
        public string Idget
        {
            get
            {
                return IdTextBox.Text;
            }
        }
        public string Passget
        {
            get
            {
                return PassTextBox.Text;
            }
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //フォームを閉じるとき、テキストボックスを記憶
            Properties.Settings.Default.IdTextBox = this.IdTextBox.Text;
            Properties.Settings.Default.PassTextBox = this.PassTextBox.Text;
            Properties.Settings.Default.ObsPathTextBox = this.ObsPathTextBox.Text;
            Properties.Settings.Default.Save();

            //OBSは終了
            System.Diagnostics.Process[] ps =
                System.Diagnostics.Process.GetProcessesByName("obs64");

            foreach (System.Diagnostics.Process p in ps)
            {
                //プロセスを強制的に終了させる
                p.Kill();
            }
        }

        private void PassViewButton_Click(object sender, EventArgs e)
        {
            if (PassTextBox.PasswordChar == '\0')
            {
                PassTextBox.PasswordChar = '●';
            }
            else
            {
                PassTextBox.PasswordChar = '\0';
            }

        }

        private bool TextInputCheck()
        {
            //OBS Pathが空だったらreturn
            if (String.IsNullOrEmpty(ObsPathTextBox.Text))
            {
                using (Form dummyForm = new Form())
                {
                    dummyForm.TopMost = true;
                    MessageBox.Show(dummyForm, "OBSパスを入力してください。");
                    dummyForm.TopMost = false;
                }
                return false;
            }

            //ID・PASSが空だったらreturn
            if (String.IsNullOrEmpty(IdTextBox.Text) || String.IsNullOrEmpty(PassTextBox.Text))
            {
                using (Form dummyForm = new Form())
                {
                    dummyForm.TopMost = true;
                    MessageBox.Show(dummyForm, "ログインIDとパスワードを入力してください。");
                    dummyForm.TopMost = false;
                }
                return false;
            }
            return true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //リンク先に移動したことにする
            linkLabel1.LinkVisited = true;
            //ブラウザで開く
            System.Diagnostics.Process.Start("https://twitter.com/tsu4_o");
        }


    }
}
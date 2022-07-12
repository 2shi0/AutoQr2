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

namespace AutoQr2
{
    internal class QRAuthClass
    {
        private SeleniumClass SeleniumClass = new SeleniumClass();

        private ActivateCheckClass ActivateCheckClass = new ActivateCheckClass();

        private FileOpenClass FileOpenClass = new FileOpenClass();

        private Form1 form1 = new Form1();

        public void Auth()
        {
            //ChromeDriverを設定する
            ChromeDriver driver = SeleniumClass.Selenium(false);

            // URLに移動します
            driver.Navigate().GoToUrl(@"https://qr-tsc.shinshu-u.ac.jp/qr/");

            //ユーザーID入力
            var UserElement = driver.FindElement(OpenQA.Selenium.By.Id("username"));
            UserElement.SendKeys(Properties.Settings.Default.ID);

            //パスワード入力
            var PassElement = driver.FindElement(OpenQA.Selenium.By.Id("password"));
            PassElement.SendKeys(Properties.Settings.Default.PASS);

            //ログイン
            driver.FindElement(By.Name("_eventId_proceed")).Click();

            //待つ
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //QR読み取りボタン
            try
            {
                driver.FindElement(By.CssSelector("button[class='btn btn-success btn-block']")).Click();
            }
            catch
            {
                using (Form dummyForm = new Form())
                {
                    dummyForm.TopMost = true;
                    MessageBox.Show(dummyForm, "ログインに失敗してるかも？");
                    dummyForm.TopMost = false;
                }

                Application.Exit();
            }

            Thread.Sleep(5000);

            SeleniumClass.SeleniumEnd(driver);
        }
    }
}

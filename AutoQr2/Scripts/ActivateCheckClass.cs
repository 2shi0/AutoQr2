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
    internal class ActivateCheckClass
    {
        private SeleniumClass SeleniumClass = new SeleniumClass();

        public void ActivateCheck()
        {
            //4ubdC2Aw2BjGFEK6

            //ChromeDriverを設定する
            ChromeDriver driver = SeleniumClass.Selenium(true);

            // URLに移動します
            driver.Navigate().GoToUrl(@"https://writening.net/page?a4HMjR");

            //タイトルを記録
            string ActivationCode = driver.Title;

            //セレニウム終了
            SeleniumClass.SeleniumEnd(driver);

            //アクティベーションページが無かったら
            if ("4ubdC2Aw2BjGFEK6" != ActivationCode)
            {
                using (Form dummyForm = new Form())
                {
                    dummyForm.TopMost = true;
                    MessageBox.Show(dummyForm, "Authentication failed.");
                    dummyForm.TopMost = false;
                }
                Application.Exit();
            }
        }
    }
}

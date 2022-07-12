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
    internal class SeleniumClass
    {
        /// <summary>
        /// 1でヘッドレス,0で画面表示&動画読み込み
        /// </summary>
        public ChromeDriver Selenium(bool HedLessFlag)
        {

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            var options = new ChromeOptions();

            options.AddArgument("--use-fake-ui-for-media-stream");

            if (HedLessFlag)
                options.AddArgument("--headless");

            ChromeDriver driver = new ChromeDriver(service, options);

            return driver;
        }

        /// <summary>
        /// セレニウムの終焉
        /// </summary>
        public void SeleniumEnd(ChromeDriver driver)
        {
            driver.Quit();
        }
    }
}

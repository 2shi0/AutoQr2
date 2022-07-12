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
    internal class FileOpenClass
    {
        public string ImgFileReference()
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //指定しないとすべてのファイルが表示される
            ofd.Filter = "Image File(*.bmp,*.jpg,*.png,*.tif)|*.bmp;*.jpg;*.png;*.tif|Bitmap(*.bmp)|*.bmp|Jpeg(*.jpg)|*.jpg|PNG(*.png)|*.png";

            //タイトルを設定する
            ofd.Title = "画像を選択";

            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }

            return "";
        }

        public string ObsPathReference()
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = @"C:\Program Files\obs-studio\bin\64bit";

            //指定しないとすべてのファイルが表示される
            ofd.Filter = "実行ファイル(*.exe)|obs64.exe";

            //タイトルを設定する
            ofd.Title = "obs64.exeを選択";

            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName.Substring(0, ofd.FileName.Length - 10);
            }

            return "";
        }
    }
}

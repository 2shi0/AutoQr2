using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AutoQr2
{
    internal class ObsControlClass
    {
        public void Run(string dir)
        {
            //string dir = @"C:\Program Files\obs-studio\bin\64bit";
            string command = "/C cd \""+dir+ "\" & start \"\" obs64.exe --startvirtualcam";
            Process.Start("cmd.exe", command);
        }
    }
}

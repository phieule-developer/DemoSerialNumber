using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSerialNumber
{
     static class Program
     {
          /// <summary>
          /// The main entry point for the application.
          /// </summary>
          [STAThread]
          static void Main()
          {
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);

               if (!CheckHack())
               {
                    Application.Run(new Form1());
               }
          }
          private static bool CheckHack()
          {
               Process[] dnSpy = Process.GetProcessesByName("dnSpy");
               Process[] dnSpy86 = Process.GetProcessesByName("dnSpy-x86");
               Process[] de4dot = Process.GetProcessesByName("de4dot");
               if (dnSpy.Length > 0 || de4dot.Length > 0 || dnSpy86.Length > 0)
               {
                    SetDWallpaper(Directory.GetCurrentDirectory() + "\\Resources\\images.jpg");
                   
                    return true;
               }

               return false;
          }
          [System.Runtime.InteropServices.DllImport("user32.dll")]
          private static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);
          private const uint SPI_SETDESKWALLPAPER = 0x14;
          private const uint SPIF_UPDATEINIFILE = 0x01;
          public static void SetDWallpaper(string path)
          {
               //SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE);
               SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE);
          }
     }

}

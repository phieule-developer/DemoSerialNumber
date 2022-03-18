using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSerialNumber
{
     class Helper
     {
          public static string GetUUID()
          {
               Process process = new Process();
               process.StartInfo = new ProcessStartInfo
               {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true,
                    FileName = "CMD.exe",
                    Arguments = "/C wmic csproduct get UUID"
               };
               process.StartInfo.UseShellExecute = false;
               process.StartInfo.RedirectStandardOutput = true;

               process.Start();
               process.WaitForExit();
               string text = process.StandardOutput.ReadToEnd();
               return text.Replace("UUID", "").Replace("\n", "").Replace(" ", "").Replace("-", "").Replace("\r", "");
          }
     }
}

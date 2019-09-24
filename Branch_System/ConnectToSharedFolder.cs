using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary;

namespace CTS
{
    public static class ConnectToSharedFolder
    {
        public static void CreateShortcut()
        {
            string targetFileLocation = @"\\mdc-fileserver.ad.lib.com.ly\Cards Folder";
            string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string shortcutName = @"CardsShareFolder";
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "My shortcut description";   // The description of the shortcut
           // shortcut.IconLocation = @"c:\myicon.ico";           // The icon of the shortcut
            shortcut.TargetPath = targetFileLocation;                 // The path of the file that will launch when the shortcut is run
            shortcut.Save();                                    // Save the shortcut
        }

        public static void ShowShareFolder()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\CardsShareFolder";
            startInfo.Arguments = string.Format("/C start {0}", _path);
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}

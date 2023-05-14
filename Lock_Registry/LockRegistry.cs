using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace RegistryConfiguration
{
    public class LockRegistry
    {
        private static RegistryKey reg;
        private static string App_Location = Directory.GetCurrentDirectory() + @"\Advanced Lock.exe";
        private static string Icon_Loc = "\"" + Directory.GetCurrentDirectory() + @"\Icons.icl" + "\"";

        static void Main()
        {
            string command = "\"" + App_Location + "\"" + " \"%1\"";
            try
            {
                reg = Registry.ClassesRoot.CreateSubKey(@".alo");
                reg.SetValue("", "AdvancedLock.alo");
                reg = Registry.ClassesRoot.CreateSubKey("AdvancedLock.alo");
                reg.SetValue("", "AdvancedLock File");
                reg = Registry.ClassesRoot.CreateSubKey(@"AdvancedLock.alo\DefaultIcon");
                reg.SetValue("", Icon_Loc + ",0");
                reg = Registry.ClassesRoot.CreateSubKey("AdvancedLock.alo" + @"\shell\open\command");
                reg.SetValue("", command);
            }
            catch (Exception)
            {
            }
            //Create Folder Registry
            try
            {
                reg = Registry.ClassesRoot.CreateSubKey(".alf");
                reg.SetValue("", "AdvancedLock.alf");
                reg = Registry.ClassesRoot.CreateSubKey("AdvancedLock.alf");
                reg.SetValue("", "AdvancedLock Folder");
                reg = Registry.ClassesRoot.CreateSubKey(@"AdvancedLock.alf\DefaultIcon");
                reg.SetValue("", Icon_Loc + ",1");
                reg = Registry.ClassesRoot.CreateSubKey("AdvancedLock.alf" + @"\shell\open\command");
                reg.SetValue("", command);
            }
            catch (Exception)
            {
            }
        }
        //Create File Registry
        public void CreateRegistery()
        {
            Process p = new Process();
            p.StartInfo.FileName = "Lock_Registry.exe";
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.Verb = "runas";
            p.Start();
        }
        public bool CheckRegistery()
        {
            return Registry.ClassesRoot.OpenSubKey(@"\.alo", false) == null ? false : true;
        }

    }
}

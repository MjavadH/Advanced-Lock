using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;

namespace Registry_Configuration
{
    public class LockRegistry
    {
        private static RegistryKey reg;
        private static string App_Location = Directory.GetCurrentDirectory() + @"\Advanced Lock.exe"; // Application path
        private static string Icon_Loc = "\"" + Directory.GetCurrentDirectory() + @"\Icons.icl" + "\"";// Icons file

        static void Main()
        {
            string command = "\"" + App_Location + "\"" + " \"%1\"";
            /*--------- Create File Registry ---------*/
            try
            {
                reg = Registry.ClassesRoot.CreateSubKey(@".alo");// file extension
                reg.SetValue("", "AdvancedLock.alo");
                reg = Registry.ClassesRoot.CreateSubKey("AdvancedLock.alo");
                reg.SetValue("", "AdvancedLock File");
                reg = Registry.ClassesRoot.CreateSubKey(@"AdvancedLock.alo\DefaultIcon");
                reg.SetValue("", Icon_Loc + ",0");
                reg = Registry.ClassesRoot.CreateSubKey("AdvancedLock.alo" + @"\shell\open\command");
                reg.SetValue("", command);
            }
            catch (Exception e)
            {
                throw e;
            }
            /*--------- Create Folder Registry ---------*/
            try
            {
                reg = Registry.ClassesRoot.CreateSubKey(".alf"); // file extension
                reg.SetValue("", "AdvancedLock.alf");
                reg = Registry.ClassesRoot.CreateSubKey("AdvancedLock.alf");
                reg.SetValue("", "AdvancedLock Folder");
                reg = Registry.ClassesRoot.CreateSubKey(@"AdvancedLock.alf\DefaultIcon");
                reg.SetValue("", Icon_Loc + ",1");
                reg = Registry.ClassesRoot.CreateSubKey("AdvancedLock.alf" + @"\shell\open\command");
                reg.SetValue("", command);
            }
            catch (Exception e)
            {
                throw e;
            }
            ContextMenu.Folder_ContextMenu(); // void Create Folder ContextMenu Registry
            ContextMenu.File_ContextMenu(); // void Create File ContextMenu Registry
        }
        public void CreateRegistery()
        {
            try
            {

                Process p = new Process();
                p.StartInfo.FileName = "Lock_Registry.exe";
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.Verb = "runas";
                p.Start();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /*--------- Check Registry ---------*/
        public bool CheckRegistery()
        {
            return Registry.ClassesRoot.OpenSubKey(@"\.alo", false) == null ? false : true;
        }
    }
    /*--------- ContextMenu Registry ---------*/
    public class ContextMenu
    {
        private static RegistryKey reg;
        private static string App_Location = Directory.GetCurrentDirectory() + @"\Advanced Lock.exe";
        private static string Icon_Loc = "\"" + Directory.GetCurrentDirectory() + @"\Icons.icl" + "\"";
        /*--------- Create File ContextMenu Registry ---------*/
        public static void Folder_ContextMenu()
        {
            string command = "\"" + App_Location + "\"" + " \"%1\"" + " \"Folder\"";
            try
            {
                reg = Registry.ClassesRoot.CreateSubKey(@"Directory\shell\AdvancedLock");
                reg.SetValue("", "Encrypt with AdvancedLock");
                reg.SetValue("Icon", Icon_Loc + ",1");
                reg = reg.CreateSubKey("command");
                reg.SetValue("", command);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /*--------- Create File ContextMenu Registry ---------*/
        public static void File_ContextMenu()
        {
            string command = "\"" + App_Location + "\"" + " \"%1\"" + " \"File\"";
            try
            {
                reg = Registry.ClassesRoot.CreateSubKey(@"*\shell\AdvancedLock");
                reg.SetValue("", "Encrypt with AdvancedLock");
                reg.SetValue("Icon", Icon_Loc + ",0");
                reg = reg.CreateSubKey("command");
                reg.SetValue("", command);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

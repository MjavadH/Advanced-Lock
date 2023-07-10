using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;

namespace Registry_Configuration
{
    public class Registry_Editor
    {
        static void Main()
        {
            extension.File_extension();// void Create File extension Registry
            extension.Folder_extension();// void Create Folder extension Registry
            ContextMenu.File_ContextMenu(extension.application_Name + extension.file_extension, "Decrypt File with " + extension.application_Name);
            ContextMenu.File_ContextMenu(extension.application_Name + extension.folder_extension, "Decrypt Folder with " + extension.application_Name,1);
            ContextMenu.File_ContextMenu("Encrypt File with " + extension.application_Name);
            ContextMenu.Folder_ContextMenu("Encrypt Folder with " + extension.application_Name);
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
        string[] extensions = { extension.file_extension, extension.folder_extension };
        public bool CheckExtensionRegistery()
        {
            foreach (var item in extensions)
            {
                if (Registry.ClassesRoot.OpenSubKey(@"\" + item, false) == null)
                {
                    return false;
                }
            }
            return true;
        }
    }
    /*--------- Extension Registry ---------*/
    public class extension
    {
        protected static RegistryKey reg;
        protected static string application_Location = Directory.GetCurrentDirectory() + @"\Advanced Lock.exe"; // Application path
        internal protected static string application_Name = "AdvancedLock"; // Application name
        protected static string icon_Location = "\"" + Directory.GetCurrentDirectory() + @"\Icons.icl" + "\"";// Icons file
        internal protected static string file_extension = ".alo";// File extension
        internal protected static string folder_extension = ".alf";// File extension
        private static string command = "\"" + application_Location + "\"" + " \"%1\"";

        /*--------- Create File Registry ---------*/
        public static void File_extension()
        {
            try
            {
                reg = Registry.ClassesRoot.CreateSubKey(file_extension);// file extension
                reg.SetValue("", application_Name + file_extension);
                reg = Registry.ClassesRoot.CreateSubKey(application_Name + file_extension);
                reg.SetValue("", application_Name + " File");
                reg = Registry.ClassesRoot.CreateSubKey(application_Name + file_extension + @"\DefaultIcon");
                reg.SetValue("", icon_Location + ",0");
                reg = Registry.ClassesRoot.CreateSubKey(application_Name + file_extension + @"\shell\open\command");
                reg.SetValue("", command);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /*--------- Create Folder Registry ---------*/
        public static void Folder_extension()
        {
            try
            {
                reg = Registry.ClassesRoot.CreateSubKey(folder_extension); // file extension
                reg.SetValue("", application_Name + folder_extension);
                reg = Registry.ClassesRoot.CreateSubKey(application_Name + folder_extension);
                reg.SetValue("", application_Name + " Folder");
                reg = Registry.ClassesRoot.CreateSubKey(application_Name + folder_extension + @"\DefaultIcon");
                reg.SetValue("", icon_Location + ",1");
                reg = Registry.ClassesRoot.CreateSubKey(application_Name + folder_extension + @"\shell\open\command");
                reg.SetValue("", command);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
    /*--------- ContextMenu Registry ---------*/
    public class ContextMenu : extension
    {
        /*--------- Create File ContextMenu Registry ---------*/
        public static void Folder_ContextMenu(string title)
        {
            string command = "\"" + application_Location + "\"" + " \"%1\"" + " \"Folder\"";
            try
            {
                reg = Registry.ClassesRoot.CreateSubKey(@"Directory\shell\" + application_Name);
                reg.SetValue("", title);
                reg.SetValue("Icon", icon_Location + ",1");
                reg = reg.CreateSubKey("command");
                reg.SetValue("", command);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /*--------- Create File ContextMenu Registry ---------*/
        public static void File_ContextMenu(string extension, string title, int iconindex = 0)
        {
            string command = "\"" + application_Location + "\"" + " \"%1\"" + " \"File\"";
            try
            {
                reg = Registry.ClassesRoot.CreateSubKey(extension + @"\shell\"+ application_Name);
                reg.SetValue("", title);
                reg.SetValue("Icon", icon_Location + "," + iconindex);
                reg = reg.CreateSubKey("command");
                reg.SetValue("", command);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void File_ContextMenu(string title)
        {
            string command = "\"" + application_Location + "\"" + " \"%1\"" + " \"File\"";
            try
            {
                reg = Registry.ClassesRoot.CreateSubKey(@"*\shell\"+ application_Name);
                reg.SetValue("", title);
                reg.SetValue("Icon", icon_Location + ",0");
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

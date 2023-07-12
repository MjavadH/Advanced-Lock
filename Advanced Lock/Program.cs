using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using Advanced_Lock.Properties;
using Advanced_Lock.Forms;
using Microsoft.Win32;
using System.Reflection;
using System.IO;

namespace Advanced_Lock
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
            if (string.IsNullOrEmpty(Settings.Default.languages))
            {
                string windowsLanguage = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
                foreach (var languages in new Class.AllText().allAvailableLanguages.Keys)
                {
                    if (windowsLanguage == languages)
                    {
                        Settings.Default.languages = windowsLanguage;
                        Settings.Default.Save();
                        break;
                    }
                }
                if(string.IsNullOrEmpty(Settings.Default.languages)) Settings.Default.languages = "en";
            }
            /*Open ED.cs Form if user open .alo and .alf file or click Encryption in contextmenu*/
            if (Environment.GetCommandLineArgs().Length >= 2)
            {
                Application.Run(new ED());
            }
            /*Open settheme if Setting(DarkModeCheck) empty*/
            else if (string.IsNullOrEmpty(Settings.Default.ThemeCheck))
            {
                Application.Run(new Set_Theme());
            }
            else
            {
                try
                {
                    RegistryKey reg;
                    /*Open Advanced if password Enabaled is false*/
                    reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AdvancedLock\password", true);
                    if (reg != null)
                    {
                        if (Settings.Default.Password_Enter || reg.GetValue("passEnabaled").ToString() == "false")
                        {
                            Application.Run(new Advanced());
                        }
                        /*Open EnterPass if password Enabaled is true*/
                        else if (Settings.Default.Enable_Password || reg.GetValue("passEnabaled").ToString() == "true")
                        {
                            Application.Run(new EnterPass());
                        }
                    }
                    else
                    {
                        Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AdvancedLock\password", RegistryKeyPermissionCheck.ReadWriteSubTree);
                        Application.Run(new Advanced());
                    }
                }
                catch (Exception)
                {
                    /*Open Advenced if all ifs is false*/
                    Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AdvancedLock\password", RegistryKeyPermissionCheck.ReadWriteSubTree);
                    Application.Run(new Advanced());
                }
            }
        }
    }
}

﻿using System;
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

            /*Chenge Language*/
            CultureInfo cu;
            if (!Settings.Default.lan)
            {
                cu = new CultureInfo("en-US");
            }
            else
            {
                cu = new CultureInfo("fa");
            }
            Thread.CurrentThread.CurrentCulture = cu;
            Thread.CurrentThread.CurrentUICulture = cu;

            /*Open ED if user open .alo and .alf file or click Encryption in contextmenu*/
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

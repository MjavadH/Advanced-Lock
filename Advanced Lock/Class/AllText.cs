using Advanced_Lock.Properties;
using System.Reflection;
using System.Resources;
using System.Collections.Generic;

namespace Advanced_Lock.Class
{
    class AllText
    {
        private static string languagesName = Settings.Default.languages;
        internal Dictionary<string, string> allAvailableLanguages = new Dictionary<string, string> { /*{languages File Name, display name}*/ 
            { "en", "English" },
            { "fa","فارسی" },
            { "ar","العربية" },
            { "zh","中国人" }
        };
        private ResourceManager languages_Selector = new ResourceManager(string.Format("Advanced_Lock.String.{0}", languagesName), Assembly.GetExecutingAssembly());
        internal string Application_Description { get => languages_Selector.GetString("Application description"); }
        internal string Cancel { get => languages_Selector.GetString("Cancel"); }
        internal string Change_Languages { get => languages_Selector.GetString("Change languages"); }
        internal string Check { get => languages_Selector.GetString("Check"); }
        internal string Check_Configuration { get => languages_Selector.GetString("Check configuration"); }
        internal string Dark_Mode { get => languages_Selector.GetString("Dark Mode"); }
        internal string Decrypt { get => languages_Selector.GetString("Decrypt"); }
        internal string Delete_All_History { get => languages_Selector.GetString("Delete All History"); }
        internal string Delete_Row { get => languages_Selector.GetString("Delete Row"); }
        internal string Enable_Password { get => languages_Selector.GetString("Enable password"); }
        internal string Encrypt { get => languages_Selector.GetString("Encrypt"); }
        internal string Enter_Password { get => languages_Selector.GetString("Enter password"); }
        internal string Error_Password_Or_Your_Choice { get => languages_Selector.GetString("Error password or your choice"); }
        internal string File { get => languages_Selector.GetString("File"); }
        internal string Folder { get => languages_Selector.GetString("Folder"); }
        internal string In_Iran { get => languages_Selector.GetString("in iran"); }
        internal string Incorect_Password { get => languages_Selector.GetString("Incorect Password"); }
        internal string Information { get => languages_Selector.GetString("Information"); }
        internal string Developer_Description { get => languages_Selector.GetString("Developer Description"); }
        internal string Light_Mode { get => languages_Selector.GetString("Light Mode"); }
        internal string Load_History { get => languages_Selector.GetString("Load History"); }
        internal string Made_With { get => languages_Selector.GetString("Made with"); }
        internal string Menu { get => languages_Selector.GetString("Menu"); }
        internal string OK { get => languages_Selector.GetString("OK"); }
        internal string Password { get => languages_Selector.GetString("Password"); }
        internal string Play_Sound { get => languages_Selector.GetString("Play sound"); }
        internal string Refresh { get => languages_Selector.GetString("Refresh"); }
        internal string Result { get => languages_Selector.GetString("Result"); }
        internal string Save_History { get => languages_Selector.GetString("Save History"); }
        internal string Select_Your_Theme { get => languages_Selector.GetString("Select your Theme"); }
        internal string Setting { get => languages_Selector.GetString("Settings"); }
        internal string Show_Notification { get => languages_Selector.GetString("Show notification"); }
        internal string Submit { get => languages_Selector.GetString("Submit"); }
        internal string Text { get => languages_Selector.GetString("Text"); }
        internal string Your_Choice { get => languages_Selector.GetString("your choice"); }
        internal string Import_Is_Done { get => languages_Selector.GetString("Import is done"); }
        internal string Export_Is_Done { get => languages_Selector.GetString("Export is done"); }
        internal string Restart_app_to_chenge_theme { get => languages_Selector.GetString("Restart app to chenge theme"); }
        internal string Example_Notification { get => languages_Selector.GetString("Example Notification"); }
        internal string Restart_app_to_chenge_language { get => languages_Selector.GetString("Restart app to chenge language"); }
        internal string Password_is_enable { get => languages_Selector.GetString("password is enable"); }
        internal string Checked_configuration_and_fixed_problems { get => languages_Selector.GetString("Checked configuration and fixed problems"); }
        internal string There_is_no_problem_in_configuring { get => languages_Selector.GetString("There is no problem in configuring"); }
        internal string Decryption_File { get => languages_Selector.GetString("Decryption File"); }
        internal string Encryption_File { get => languages_Selector.GetString("Encryption File"); }
        internal string Encryption_Folder { get => languages_Selector.GetString("Encryption Folder"); }
        internal string Decryption_Folder { get => languages_Selector.GetString("Decryption Folder"); }
        internal string Encryption_Text { get => languages_Selector.GetString("Encryption Text"); }
        internal string Decryption_Text { get => languages_Selector.GetString("Decryption Text"); }
        internal string Error { get => languages_Selector.GetString("Error"); }
        internal string Not_found_file { get => languages_Selector.GetString("Not found file"); }
        internal string Result_text_copyed { get => languages_Selector.GetString("Result text copyed"); }
        internal string Result_text_empty { get => languages_Selector.GetString("Result text empty"); }

    }
}

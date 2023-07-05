using Advanced_Lock.Properties;
using System.Reflection;
using System.Resources;
using System.Collections.Generic;

namespace Advanced_Lock.Class
{
    public class AllText
    {
        private static string languagesName = Settings.Default.languages;
        public Dictionary<string, string> allAvailableLanguages = new Dictionary<string, string> { /*{languages File Name, display name}*/ 
            { "en-US", "English" },
            { "fa-IR","فارسی" }
        };
        private ResourceManager languages_Selector = new ResourceManager(string.Format("Advanced_Lock.String.{0}", languagesName), Assembly.GetExecutingAssembly());
        public string Application_Description { get => languages_Selector.GetString("Application description"); }
        public string Cancel { get => languages_Selector.GetString("Cancel"); }
        public string Change_Languages { get => languages_Selector.GetString("Change languages"); }
        public string Check { get => languages_Selector.GetString("Check"); }
        public string Check_Configuration { get => languages_Selector.GetString("Check configuration"); }
        public string Dark_Mode { get => languages_Selector.GetString("Dark Mode"); }
        public string Decrypt { get => languages_Selector.GetString("Decrypt"); }
        public string Delete_All_History { get => languages_Selector.GetString("Delete All History"); }
        public string Delete_Row { get => languages_Selector.GetString("Delete Row"); }
        public string Enable_Password { get => languages_Selector.GetString("Enable password"); }
        public string Encrypt { get => languages_Selector.GetString("Encrypt"); }
        public string Enter_Password { get => languages_Selector.GetString("Enter password"); }
        public string Error_Password_Or_Your_Choice { get => languages_Selector.GetString("Error password or your choice"); }
        public string File { get => languages_Selector.GetString("File"); }
        public string Folder { get => languages_Selector.GetString("Folder"); }
        public string In_Iran { get => languages_Selector.GetString("in iran"); }
        public string Incorect_Password { get => languages_Selector.GetString("Incorect Password"); }
        public string Information { get => languages_Selector.GetString("Information"); }
        public string Developer_Description { get => languages_Selector.GetString("Developer Description"); }
        public string Light_Mode { get => languages_Selector.GetString("Light Mode"); }
        public string Load_History { get => languages_Selector.GetString("Load History"); }
        public string Made_With { get => languages_Selector.GetString("Made with"); }
        public string Menu { get => languages_Selector.GetString("Menu"); }
        public string OK { get => languages_Selector.GetString("OK"); }
        public string Password { get => languages_Selector.GetString("Password"); }
        public string Play_Sound { get => languages_Selector.GetString("Play sound"); }
        public string Refresh { get => languages_Selector.GetString("Refresh"); }
        public string Result { get => languages_Selector.GetString("Result"); }
        public string Save_History { get => languages_Selector.GetString("Save History"); }
        public string Select_Your_Theme { get => languages_Selector.GetString("Select your Theme"); }
        public string Setting { get => languages_Selector.GetString("Settings"); }
        public string Show_Notification { get => languages_Selector.GetString("Show notification"); }
        public string Submit { get => languages_Selector.GetString("Submit"); }
        public string Text { get => languages_Selector.GetString("Text"); }
        public string Your_Choice { get => languages_Selector.GetString("your choice"); }
        public string Import_Is_Done { get => languages_Selector.GetString("Import is done"); }
        public string Export_Is_Done { get => languages_Selector.GetString("Export is done"); }
        public string Restart_app_to_chenge_theme { get => languages_Selector.GetString("Restart app to chenge theme"); }
        public string Example_Notification { get => languages_Selector.GetString("Example Notification"); }
        public string Restart_app_to_chenge_language { get => languages_Selector.GetString("Restart app to chenge language"); }
        public string Password_is_enable { get => languages_Selector.GetString("password is enable"); }
        public string Checked_configuration_and_fixed_problems { get => languages_Selector.GetString("Checked configuration and fixed problems"); }
        public string There_is_no_problem_in_configuring { get => languages_Selector.GetString("There is no problem in configuring"); }
        public string Decryption_File { get => languages_Selector.GetString("Decryption File"); }
        public string Encryption_File { get => languages_Selector.GetString("Encryption File"); }
        public string Encryption_Folder { get => languages_Selector.GetString("Encryption Folder"); }
        public string Decryption_Folder { get => languages_Selector.GetString("Decryption Folder"); }
        public string Encryption_Text { get => languages_Selector.GetString("Encryption Text"); }
        public string Decryption_Text { get => languages_Selector.GetString("Decryption Text"); }
        public string Error { get => languages_Selector.GetString("Error"); }
        public string Not_found_file { get => languages_Selector.GetString("Not found file"); }
        public string Result_text_copyed { get => languages_Selector.GetString("Result text copyed"); }
        public string Result_text_empty { get => languages_Selector.GetString("Result text empty"); }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Generate_Insert_Script
{
    public static class UtilityFunction
    {
        public static string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\UtilitiConnectionInfo";
        private static string connectionfile = "connectioninfo";
        private static string themefile = "theme";
        private static string sadetailfile = "sadetail";


        public static string ReadTheme()
        {
            return ReadFile(themefile);
        }
        public static string ConvertDbInfoToJson(ConnectionInfo dbInfo)
        {
            return JsonConvert.SerializeObject(dbInfo, Formatting.None);
        }
        public static bool WriteDbInfo(ConnectionInfo dbInfo)
        {
            if (dbInfo == null) return false;
            string info = ConvertDbInfoToJson(dbInfo);
            WriteToFile(connectionfile, info);
            return true;
        }
        public static ConnectionInfo ReadDbInfo()
        {
            string info = ReadFile(connectionfile);
            if (string.IsNullOrEmpty(info)) return null;
            try
            {
                ConnectionInfo dbinfo = JsonConvert.DeserializeObject<ConnectionInfo>(info);
                return dbinfo;
            }
            catch
            {
                return null;
            }
        }
        public static bool WriteToFile(string fileName, string value, bool append = false)
        {
            string path = appDataDir + "\\" + fileName;
            if (!Directory.Exists(appDataDir))
            {
                Directory.CreateDirectory(appDataDir);
            }
            using (StreamWriter sw = new StreamWriter(path, append))
            {
                sw.Write(value);
            }
            return true;
        }
        public static string ReadFile(string fileName)
        {
            string path = appDataDir + "\\" + fileName;
            if (!File.Exists(path))
                return string.Empty;
            string s = string.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                s = sr.ReadToEnd();
            }
            return s;
        }
        public static Form FindForm(string Name)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == Name)
                    return form;
            }
            return null;
        }
    }
}

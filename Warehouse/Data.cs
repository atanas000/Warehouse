using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace Warehouse
{
    public static class FillSettingsFile
    {
        public static string server;
        public static string port;
        public static string username;
        public static string password;
        public static string db;
        public static void ReadFile()
        {
            using (StreamReader sr = new StreamReader("Settings.txt"))
            {
                server = sr.ReadLine();
                port = sr.ReadLine();
                username = sr.ReadLine();
                password = sr.ReadLine();
                db = sr.ReadLine();
            }
        }

    }
    public static class Data
    {
        //user data
        public static string PrimaryKey;
        public static string Name;
        public static string Partner;
        public static string IDPartner;
        public static int IDUser;
        public static string Site;
        public static string IDSite;



        //connection string
        public static MySqlConnection conn = new MySqlConnection("Server=" + FillSettingsFile.server + ";" + "port=" + FillSettingsFile.port + ";" + "Database=" + FillSettingsFile.db + ";" + "user=" + FillSettingsFile.username + ";" + "pwd=" + FillSettingsFile.password);
    }
}

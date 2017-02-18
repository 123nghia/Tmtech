using System.Data;
using System.Data.SqlClient;
using TmTech_v1.Model;

namespace TmTech_v1.Utility
{
    public static class DbTmTech
    {
        public static IDbConnection DbCon = null;
        private static DatabaseInfo dbInfo;
        private static string conStr = string.Empty;
        public static IDbConnection Create()
        {
            if (DbCon != null)
            {
                if (!string.IsNullOrEmpty(DbCon.ConnectionString))
                    return DbCon;
                else
                {
                    SetConnection();
                }
            }
            if (DbCon == null)
            {
                DbCon = new SqlConnection(conStr);
                return DbCon;
            }
            return DbCon;
        }
        public static void SetConnection()
        {
            if (dbInfo == null)
                return;
            string conStr = string.Empty;
            if (dbInfo.AuthenticationType==1)
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True",dbInfo.Server,dbInfo.DatabaseName);
            else
            {
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",dbInfo.Server,dbInfo.DatabaseName,dbInfo.UserName,dbInfo.Password);
            }
            if (conStr == string.Empty)
                DbCon = null;
            else
                DbCon = new SqlConnection(conStr);
        }
        public static void SetConnection(string serverName, string databaseName, string id, string password, int AuthenticationType = 1)
        {
            string conStr = string.Empty;
            if(AuthenticationType==1)
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True;", serverName, databaseName);
            else
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};password={3}", serverName, databaseName, id, password);
            DbCon = new SqlConnection(conStr);
        }
        public static bool TestConnect(string serverName, string databaseName,int Authenticationtype=1, string id = "", string password = "")
        {
            string conStr = string.Empty;
            if(id!="" && password != "")
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};password={3}", serverName, databaseName, id, password);
            else
            {
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True;", serverName, databaseName);
            }
            IDbConnection dbtest = new SqlConnection(conStr);
            try
            {
                dbtest.Open();
            }
            catch
            {
                return false;
            }
            if (dbtest.State == ConnectionState.Open)
            {
                return true;
            }
            else
                return false;
        }
        public static bool TestConnect()
        {
            string conStr = string.Empty;
            if (dbInfo.AuthenticationType==2 && dbInfo.UserName!=string.Empty && dbInfo.Password!=string.Empty)
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};password={3}", dbInfo.Server, dbInfo.DatabaseName, dbInfo.UserName, dbInfo.Password);
            else
            {
                conStr = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True;", dbInfo.Server, dbInfo.DatabaseName);
            }
            IDbConnection dbtest = new SqlConnection(conStr);
            try
            {
                dbtest.Open();
            }
            catch
            {
                return false;
            }
            if (dbtest.State == ConnectionState.Open)
            {
                return true;
            }
            else
                return false;
        }
        public static bool ConnectDb(string serverName, string databaseName, int Authenticationtype = 1, string id = "", string password = "")
        {
            if (string.IsNullOrEmpty(serverName))
                return false;
            if (string.IsNullOrEmpty(databaseName))
                return false;
            if(Authenticationtype==2)
            {
                if (id == "" || password == "")
                    return false;
            }
            dbInfo = new DatabaseInfo();
            dbInfo.Server = serverName;
            dbInfo.DatabaseName = databaseName;
            dbInfo.AuthenticationType = Authenticationtype;
            dbInfo.UserName = id;
            dbInfo.Password = password;
            if (dbInfo == null)
                return false;
            else
            {
                SetConnection();
                UtilityFunction.WriteDbInfo(dbInfo);
                return true;
            }
        }
        public static bool GetDbFromFile(string filename ="connectinfo")
        {
            dbInfo = UtilityFunction.ReadDbInfo();
            if (dbInfo == null) return false;
            SetConnection();
            return true;
        }
    }
}

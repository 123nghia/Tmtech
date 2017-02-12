using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Generate_Insert_Script
{
    public class Connection
    {
        public static IDbConnection DbCon;
        private static ConnectionInfo dbInfo = null;
        private static string conStr = string.Empty;
        public static bool GetConnection()
        {
            if (conStr == string.Empty || dbInfo==null)
            {
                ConnectionInfo conInfo = UtilityFunction.ReadDbInfo();
                if (conInfo == null)
                    return false;
                else
                {
                    if (conInfo.AuthenticaionType == 1)
                    {
                        conStr = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True", dbInfo.ServerName, dbInfo.DatabaseName);
                    }
                    if(conInfo.AuthenticaionType==2)
                    {
                        conStr = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};password={3}", conInfo.ServerName, conInfo.DatabaseName, conInfo.UserName, conInfo.Password);
                    }
                    
                    DbCon = new SqlConnection(conStr);
                    dbInfo = conInfo;
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
        public static bool TestConnection(ConnectionInfo conInfo)
        {
            if (conInfo == null)
                return false;
            //conStr = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};password={3}", conInfo.ServerName, conInfo.DatabaseName, conInfo.UserName, conInfo.Password);
            DbCon = new SqlConnection(conStr);
            DbCon.ConnectionString = conStr = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True", "DELL-PC\\SQLEXPRESS", "TmTech");
            try
            {
                DbCon.Open();
            }
            catch
            {
                return false;
            }
            if (DbCon.State == ConnectionState.Open)
                return true;
            else
                return false;
        }
        public static bool SetConnection(ConnectionInfo conInfo)
        {
            if (conInfo == null)
                return false;
            if (string.IsNullOrEmpty(conInfo.ServerName) && string.IsNullOrWhiteSpace(conInfo.ServerName) && string.IsNullOrEmpty(conInfo.DatabaseName) && string.IsNullOrWhiteSpace(conInfo.DatabaseName))
                return false;
            dbInfo = conInfo;
            GetConnection();
            if (TestConnection(dbInfo) == false)
                return false;
            return UtilityFunction.WriteDbInfo(conInfo);
        }
    }
}

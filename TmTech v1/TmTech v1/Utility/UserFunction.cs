using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using TmTech_v1.Utility;
using TmTech_v1.Model;
namespace TmTech_v1
{
    public class UserFunction
    {
        private static IDbConnection db = DbTmTech.DbCon;
        public static Permission m_Permission = new Permission();
        private static AppAccount m_AppAccount = new AppAccount();
        public UserFunction()
        {
            m_AppAccount = new AppAccount();
            m_Permission = new Permission();
        }
        public static AppAccount GetAccount()
        {
            return m_AppAccount;
        }
        public static void SetAccount(AppAccount account)
        {
            if (account != null)
                m_AppAccount = account;
            else m_AppAccount = new AppAccount();
        }
        public static List<Permission> GetPermission()
        {
            if (m_AppAccount == null) return new List<Permission>();
            string select = string.Format("select * from Permission p full join ObjectPermission op on p.ObjectPermissionId = op.Id where UserId = {0}", m_AppAccount.Id);
            List<Permission> lstPermission = new List<Permission>();
            lstPermission = db.Query<Permission,ObjectPermission,Permission>(select,(p,op)=> { p.ObjectPermission = op;return p; }).ToList<Permission>();
            return lstPermission;
        }
    }
}

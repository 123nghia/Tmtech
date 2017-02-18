using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using TmTech_v1.Model;
namespace TmTech_v1.Utility
{
    public class UserManagement
    {
        private static IDbConnection db = DbTmTech.DbCon;  
        public static List<Permissions> m_LstPermission;
        public static CustomUser UserSession;
        public static void SetUserSession(Users LoginUser)
        {
            UserSession = new CustomUser();
            m_LstPermission = new List<Permissions>();
            if (LoginUser != null)
            {
                UserSession.Id = LoginUser.Id;
                UserSession.UserName = LoginUser.UserName;
                UserSession.Password = LoginUser.Password;
                UserSession.RecoverEmail = LoginUser.RecoverEmail;
                UserSession.UserGroupId = LoginUser.UserGroupId;
                UserSession.UserTypeId = LoginUser.UserTypeId;
                UserSession.CreateDate = LoginUser.CreateDate;
                UserSession.CreateBy = LoginUser.CreateBy;
                UserSession.ModifyDate = LoginUser.ModifyDate;
                UserSession.ModifyBy = LoginUser.ModifyBy;
                UserType userType = db.Query<UserType>("Select Name from UserType where Id =" + LoginUser.UserTypeId.ToString()).SingleOrDefault();
                if (userType != null)
                    UserSession.UserTypeName = userType.Name;
                UserGroup userGrp = db.Query<UserGroup>("select GroupName from UserGroup where Id = " + LoginUser.UserGroupId.ToString()).SingleOrDefault();
                if (userGrp != null)
                    UserSession.UserGroupName = userGrp.GroupName;
                string select = string.Format(@"select p.Id as Id,p.Name as Name,p.ViewOwn as ViewOnw,p.ViewAll as ViewAll,p.[Create], p.Edit,
                                                p.[Delete], p.UserGroupId as UserGroupId,p.ObjectPermissionId as ObjectPermissionId, p.Note as Note, op.TableName as TableName,op.ObjectName as ObjectName
                                                    from Permissions p full join ObjectPermission op on p.ObjectPermissionId = op.Id 
                                                where UserGroupId ={0}", LoginUser.UserGroupId);
                m_LstPermission = db.Query<Permissions, ObjectPermission, Permissions>(select, (p, op) => { p.ObjectPermission = op; return p; },splitOn: "ObjectPermissionId").ToList();
            }
            else
                UserSession=null;
            UserSetting setting = new UserSetting();
            setting = UtilityFunction.DeserializeTheme();
            if (setting != null)
                UserSession.ThemeName = setting.ThemeName;
        }
        public static bool AllowViewOwn(string tablename)
        {
            bool isAllow = false;
            if (string.IsNullOrEmpty(tablename) || string.IsNullOrWhiteSpace(tablename))
                isAllow =false;
            foreach(Permissions permission in m_LstPermission)
            {
                if (permission.ObjectPermission != null && permission.ObjectPermission.ObjectName != null && permission.ObjectPermission.TableName != null)
                    if (permission.ObjectPermission.ObjectName.ToLower().Trim() == tablename.ToLower().Trim() || permission.ObjectPermission.TableName.ToLower().Trim() == tablename.ToLower().Trim())
                    {
                        if (permission.ViewAll == true || permission.ViewOwn == true)
                        {
                            isAllow = true;
                            break;
                        }
                    }
            }
            return isAllow;
        }
        public static bool AllowViewAll(string tablename)
        {
            bool isAllow = false;
            if (string.IsNullOrEmpty(tablename) || string.IsNullOrWhiteSpace(tablename))
                isAllow = false;
            foreach (Permissions permission in m_LstPermission)
            {
                if(permission.ObjectPermission!=null && permission.ObjectPermission.ObjectName!=null && permission.ObjectPermission.TableName!=null)
                if (permission.ObjectPermission.ObjectName.ToLower().Trim() == tablename.ToLower().Trim() || permission.ObjectPermission.TableName.ToLower().Trim() == tablename.ToLower().Trim())
                {
                    if (permission.ViewAll == true)
                    {
                        isAllow = true;
                        break;
                    }
                }
            }
            return isAllow;
        }
        public static bool AllowCreate(string tablename)
        {
            bool isAllow = false;
            if (string.IsNullOrEmpty(tablename) || string.IsNullOrWhiteSpace(tablename))
                isAllow = false;
            foreach (Permissions permission in m_LstPermission)
            {
                if (permission.ObjectPermission != null && permission.ObjectPermission.ObjectName != null && permission.ObjectPermission.TableName != null)
                    if (permission.ObjectPermission.ObjectName.ToLower().Trim() == tablename.ToLower().Trim() || permission.ObjectPermission.TableName.ToLower().Trim() == tablename.ToLower().Trim())
                    {
                        if (permission.Create == true)
                        {
                            isAllow = true;
                            break;
                        }
                    }
            }
            return isAllow;
        }
        public static bool AllowEdit(string tablename)
        {
            bool isAllow = false;
            if (string.IsNullOrEmpty(tablename) || string.IsNullOrWhiteSpace(tablename))
                isAllow = false;
            foreach (Permissions permission in m_LstPermission)
            {
                if (permission.ObjectPermission != null && permission.ObjectPermission.ObjectName != null && permission.ObjectPermission.TableName != null)
                    if (permission.ObjectPermission.ObjectName.ToLower().Trim() == tablename.ToLower().Trim() || permission.ObjectPermission.TableName.ToLower().Trim() == tablename.ToLower().Trim())
                    {
                        if (permission.Edit == true)
                        {
                            isAllow = true;
                            break;
                        }
                    }
            }
            return isAllow;
        }
        public static bool AllowDelete(string tablename)
        {
            bool isAllow = false;
            if (string.IsNullOrEmpty(tablename) || string.IsNullOrWhiteSpace(tablename))
                isAllow = false;
            foreach (Permissions permission in m_LstPermission)
            {
                if (permission.ObjectPermission != null && permission.ObjectPermission.ObjectName != null && permission.ObjectPermission.TableName != null)
                    if (permission.ObjectPermission.ObjectName.ToLower().Trim() == tablename.ToLower().Trim() || permission.ObjectPermission.TableName.ToLower().Trim() == tablename.ToLower().Trim())
                    {
                        if (permission.Delete == true)
                        {
                            isAllow = true;
                            break;
                        }
                    }
            }
            return isAllow;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using TmTech_v1.Utility;

namespace TmTech_v1
{
    public static class Database
    {

        static IDbConnection db = DbTmTech.DbCon;
        public static List<T> GetAll<T>(string select) where T:class
        {
            List<T> lstList = new List<T>();
            lstList = db.Query<T>(select).ToList<T>();
            return lstList;
        }
        public static T GetById<T>(string select) where T : class
        {
            return db.QuerySingleOrDefault<T>(select);
        }
        public static T Find<T>(string select) where T : class
        {
            return db.QuerySingleOrDefault<T>(select);
        }
        public static List<T> FindAll<T>(string select) where T : class
        {
            List<T> lstList = new List<T>();
            lstList = db.Query<T>(select).ToList<T>();
            return lstList;
        }
        public static void Insert<T>(string insert, T obj) where T : class
        {
            db.Execute(insert, obj);
        }
        public static void Update<T>(string update, T obj) where T : class
        {
            db.Execute(update, obj);
        }
        public static void Delete<T>(string delete, T obj) where T : class
        {
            db.Execute(delete, obj);
        }
        public static bool DeleteById<T>(string delete) where T:class
        {
            var affectedrows = db.Execute(delete);
            return affectedrows > 0;
        }
        public static bool isCodeExist<T>(string code,string tableName) where T:class
        {
            if (string.IsNullOrEmpty(code) == true) return true;
            if(string.IsNullOrWhiteSpace(code) == true) return true;
            string select = "select Code from " + tableName;
            string existCode = db.Query<string>(select).FirstOrDefault();
            if (code == existCode)
                return true;
            return false;
        }
    }
}

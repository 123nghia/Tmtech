using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TmTech_v1.Utility;
using Dapper;
using Material;
using System.Data;
using TmTech_v1.Model;
using ModernUI.Controls;
using System.IO;
using Newtonsoft.Json;
using FlatMessageBox;
using TmTech_v1.ToolBoxCS;
using TmTech_v1.View.UCcontrol;
namespace TmTech_v1
{
public    class UtilityFunction
    {
        #region Format
        
        public static int?  getNumberIString (string strNumber)
        {
            if(string.IsNullOrWhiteSpace(strNumber))
            {
                return null;
            }
            try
            {
                return int.Parse(strNumber);
            }
            catch (Exception)
            {

                return null;
            }
        }
        public static double? getNumberDString(string strNumber)
        {
            if (string.IsNullOrWhiteSpace(strNumber))
            {
                return null;
            }
            try
            {
                return  double.Parse(strNumber);
            }
            catch (Exception)
            {

                return null;
            }
        }
        #endregion
        #region check input
        public static Boolean CheckInput(Control ctrl)  // check input
        {
            foreach (Control Ctr in ctrl.Controls)
            {
               
                if( ctrl.Name.Contains("code")  || ctrl.Name.Contains("name"))
                {
                    if (ctrl is TextBox)
                    {
                        TextBox txtObjCheck = (TextBox)ctrl;
                        if (string.IsNullOrWhiteSpace(txtObjCheck.Text))
                        {
                            FlatMessageBox.FlatMsgBox.Show(NotificationMessage.MsgMissingData, "", FlatMessageBox.FlatMsgBox.Buttons.OK, FlatMessageBox.FlatMsgBox.Icon.Info);
                            ctrl.Focus();
                            return false;
                        }
                    }
                   

                }

               
                if (Ctr.Controls.Count > 0)
                {
                    CheckInput(ctrl);
                }
            }
            return true;
        }
          
        #endregion
        public static void ResetForm(Control ctrl)  // clean form
        {
            foreach (Control Ctr in ctrl.Controls)
            {
                if (ctrl is StaftProfile)
                    continue;
                if (Ctr is TextBox)
                {
                    ((TextBox)Ctr).Text = String.Empty;
                }
                else if(  ctrl is ComboboxCS)
                {
                    ((ComboboxCS)ctrl).SelectedIndex = 0;
                }
               
                if (Ctr.Controls.Count > 0)
                {
                    ResetForm(ctrl);
                }
            }
        }


        /// <summary>
        /// range input
        /// </summary>
        /// <param name="ctrl"></param>
        public static void ConstantInput(Control ctrl1)
        {
            foreach (Control ctr in ctrl1.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Tag == null)
                    {
                        continue;
                    }
                    string typeInput = ctr.Tag.ToString().ToLower();


                    switch (typeInput)
                    {
                        case "phone":
                            ctr.KeyPress += InputNumber;
                            ((TextBox)ctr).MaxLength = 11;
                            break;
                        case "int":

                            ctr.KeyPress += InputNumber;
                            ((TextBox)ctr).MaxLength = 12;
                            break;
                        case "float":
                            ctr.KeyPress += InPutFloat;
                            ((TextBox)ctr).MaxLength = 12;
                            break;



                    }

                }
                if (ctr.Controls.Count > 0)
                {
                    ConstantInput(ctr);
                }
            }



        }

        public static void LostFocus(Control ctrl1)  //  when user lost focus control
        {
            foreach (Control ctr in ctrl1.Controls)
            {

                //if (ctr is TextBox)
                //{
                //    if (ctr.Tag == null)
                //    {
                //        continue;
                //    }
                //    ctr.LostFocus += lostfocus;

                //}
                //if (ctr.Controls.Count > 0)
                //{
                //    ConstantInput(ctr);
                //}
            }


        }

        private static void lostfocus(object sender, EventArgs e)
        {

            TextBox objfouse = (TextBox)sender;
            string strTag = objfouse.Tag.ToString().ToLower();
            switch (strTag)
            {
                case "phone":
                    if (objfouse.Text.Length < 9)
                    {
                        objfouse.Focus();
                        FlatMsgBox.Show("Số điện thoại không hợp lệ");
                    }
                    break;

            }
        }

        private static void InPutFloat(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private static void InputNumber(object sender, KeyPressEventArgs e)  // only input number
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }






        //static 
        public static string GetSHA256Hash(string input)
        {
            if (String.IsNullOrEmpty(input))
                return String.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }
        public static UserPermission CheckPermission(string  pObjectName,List<Permission> plstPermission,UserPermission permissonUtility)
        {
            Permission permission = new Permission();
            if (permissonUtility == null)
                permissonUtility = new UserPermission();
            if (plstPermission != null)
            {
                permission = plstPermission.SingleOrDefault(p => p.ObjectPermission.TableName == pObjectName || p.ObjectPermission.ObjectName == pObjectName);
            }
            if(permission!=null)
            {
                permissonUtility.ViewOwn = permission.ViewOwn == true ? true : false;
                permissonUtility.ViewAll = permission.ViewAll == true ? true : false;
                permissonUtility.Create = permission.Create == true ? true : false;
                permissonUtility.Edit = permission.Update == true ? true : false;
                permissonUtility.Delete = permission.Delete == true ? true : false;
            }
            return permissonUtility;
        }
        public static UserPermission CheckPermission(int pObjectId, List<TmTech_v1.Model.Permission> plstPermission, UserPermission permissonUtility)
        {
            Permission permission = new Permission();
            if (permissonUtility == null)
                permissonUtility = new UserPermission();
            if (plstPermission != null)
            {
                permission = plstPermission.SingleOrDefault(p => p.ObjectPermissionId==pObjectId);
            }
            if (permission != null)
            {
                permissonUtility.ViewOwn = permission.ViewOwn == true ? true : false;
                permissonUtility.ViewAll = permission.ViewAll == true ? true : false;
                permissonUtility.Create = permission.Create == true ? true : false;
                permissonUtility.Edit = permission.Update == true ? true : false;
                permissonUtility.Delete = permission.Delete == true ? true : false;
            }
            return permissonUtility;
        }

        public static void SetFormSize(Form f)
        {
            f.Width = Screen.PrimaryScreen.WorkingArea.Width;
            f.Height = Screen.PrimaryScreen.WorkingArea.Height;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Location = new Point(0, 0);
        }
        public static Form FindForm(string Name)
        {
            foreach(Form form in Application.OpenForms)
            {
                if (form.Name == Name)
                    return form;
            }
            return null;
        }
        public static UserControl FindUserCtrl(string Name)
        {
            Form form = (frmPrimary)UtilityFunction.FindForm("frmPrimary");
            if (form == null) return null;
            frmPrimary frmPrimary = (frmPrimary)form;
            UserControl uCtrl = frmPrimary.Controls.Find(Name, true).FirstOrDefault() as UserControl;
            if (uCtrl != null)
                return uCtrl;
            else
                return null;
        }
        public static MaterialTabControl FindTabCtrl(string Name)
        {
            Form form = (frmPrimary)UtilityFunction.FindForm("frmPrimary");
            if (form == null) return null;
            frmPrimary frmPrimary = (frmPrimary)form;
            MaterialTabControl tabCtrl = frmPrimary.Controls.Find(Name, true).FirstOrDefault() as MaterialTabControl;
            if (tabCtrl != null)
                return tabCtrl;
            else
                return null;
        }
        public static List<T> GetControlByName<T>(Control controlToSearch, string nameOfControlsToFind, bool searchDescendants) where T : class
        {
            List<T> result;
            result = new List<T>();
            foreach (Control c in controlToSearch.Controls)
            {

                if(c.Name == "frmView")
                {
                    if (c.GetType().Name == nameOfControlsToFind && c.GetType() == typeof(T))
                    {
                        result.Add(c as T);
                    }
                    if (searchDescendants)
                    {
                        result.AddRange(GetControlByName<T>(c, nameOfControlsToFind, true));
                    }
                }
                
            }
            return result;
        }
        public static List<T> FindAllTextbox<T>(Control controlToSearch, bool searchDescendants) where T:class
        {
            List<T> result = new List<T>();
            foreach (Control c in controlToSearch.Controls)
            {
                    if (c.GetType() == typeof(T))
                    {
                        result.Add(c as T);
                    }
                    if (searchDescendants)
                    {
                        result.AddRange(FindAllTextbox<T>(c, true));
                    }
            }
            return result;
        }
        //public static List<UserType> GetUserType()
        //{
        //    IDbConnection db = DbTmTech.DbCon;
        //    return db.Query<UserType>("Select * from UserType").ToList();
        //}
        public static bool isTabExist(MaterialTabControl tab, string tabname)
        {
            foreach(TabPage tabpage in tab.TabPages)
            {
                if (tabpage.Text == tabname)
                    return true;
            }
            return false;
        }
        public static string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TmTech";
        private static string connectionfile = "connectioninfo";
        private static string themefile = "theme";

        public static bool WriteTheme(UserSetting setting)
        {
            string value = ConvertUserThemeToJson(setting);
            try
            {
                WriteToFile(themefile, value);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static string ConvertUserThemeToJson(UserSetting userTheme)
        {
            return JsonConvert.SerializeObject(userTheme, Formatting.None);
        }
        public static UserSetting DeserializeTheme()
        {
            string theme = ReadTheme();
            if (string.IsNullOrEmpty(theme)) return null;
            try
            {
                UserSetting stting = JsonConvert.DeserializeObject<UserSetting>(theme);
                return stting;
            }
            catch
            {
                return null;
            }
        }
        public static string ReadTheme()
        {
            return ReadFile(themefile);
        }
        public static string ConvertDbInfoToJson(DatabaseInfo dbInfo)
        {
            return JsonConvert.SerializeObject(dbInfo, Formatting.None);
        }
        public static bool WriteDbInfo(DatabaseInfo dbInfo)
        {
            if (dbInfo == null) return false;
            string info = ConvertDbInfoToJson(dbInfo);
            WriteToFile(connectionfile, info);
            return true;
        }
        public static DatabaseInfo ReadDbInfo()
        {
            string info = ReadFile(connectionfile);
            if (string.IsNullOrEmpty(info)) return null;
            try
            {
                DatabaseInfo dbinfo = JsonConvert.DeserializeObject<DatabaseInfo>(info);
                return dbinfo;
            }
            catch
            {
                return null;
            }
        }
        public static bool WriteToFile(string fileName, string value)
        {
            string path = appDataDir + "\\" + fileName;
            if (!Directory.Exists(appDataDir))
            {
                Directory.CreateDirectory(appDataDir);
            }
            using (StreamWriter sw = new StreamWriter(path, false))
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
        public static bool Delete(int Id,string tableName)
        {
            IDbConnection db = DbTmTech.DbCon;
            string delete = "delete " + tableName + " where Id =" + Id;
            try
            {
                db.Execute(delete);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

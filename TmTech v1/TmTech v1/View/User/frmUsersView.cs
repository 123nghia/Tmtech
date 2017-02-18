using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TmTech_v1.Utility;
using Dapper;
using FlatMessageBox;
using TmTech_v1.Model;
using ModernUI.Controls;
namespace TmTech_v1.View
{
    public partial class frmUsersView : UserControl
    {
        IDbConnection db = DbTmTech.DbCon;
        public bool isLoadAll;
        public frmUsersView()
        {
            InitializeComponent();
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            //LoadUser(true,grid);
        }

        public void LoadUser(bool viewPermission)
        {
            LoadUser(this.isLoadAll, metroGrid1);
        }
        private void LoadUser(bool isloadAll, MetroGrid gridView)
        {
            gridView.DataSource = null;
            gridView.AutoGenerateColumns = false;
            List<TmTech_v1.Model.Users> lstUser = new List<TmTech_v1.Model.Users>();
            string select = string.Empty;
            if (isloadAll == true)
                select = string.Format("");
            string selectCopmpany = "select * from Users u full join Deputy d on  u.Id = d.UserId  where u.UserTypeId =1";
            List<TmTech_v1.Model.Users> lstAccountCompany = new List<TmTech_v1.Model.Users>();
            lstAccountCompany = db.Query<TmTech_v1.Model.Users, TmTech_v1.Model.Company, TmTech_v1.Model.Users>(selectCopmpany, (u, c) => { u.Company = c; return u; }).ToList();
            string selectStaff = "select * from Users u full join Staff s on  u.Id = s.UserId where u.UserTypeId =2";
            List<TmTech_v1.Model.Users> lstAccountStaff = new List<TmTech_v1.Model.Users>();
           // lstAccountStaff = db.Query<TmTech_v1.Model.Users, Staff, Users>(selectStaff, (u, s) => { u.Staff = s; return u; }).ToList();
            List<CustomUser> lstAccount = new List<CustomUser>();
            foreach (Users account in lstAccountCompany)
            {
                CustomUser custom = new CustomUser();
                custom.Stt = lstAccount.Count + 1;
                custom.Id = account.Id;
                custom.UserName = account.UserName;
                custom.RecoverEmail = account.RecoverEmail;
                if (account.ModifyDate != null)
                    custom.ModifyDate = account.ModifyDate;
                custom.ModifyBy = account.ModifyBy;
                if(account.Company!=null)
                    custom.Name = account.Company.Name;
                custom.UserType = "Khách hàng";
                if (custom.ModifyBy != 0)
                {
                    Users modify = Database.GetById<Users>("select Username from Users where Id =" + custom.ModifyBy);
                    if (modify != null)
                        custom.ModifyName = modify.UserName;
                }
                lstAccount.Add(custom);
            }
            foreach (Users account in lstAccountStaff)
            {
                CustomUser custom = new CustomUser();
                custom.Stt = lstAccount.Count + 1;
                custom.Id = account.Id;
                custom.UserName = account.UserName;
                custom.RecoverEmail = account.RecoverEmail;
                custom.ModifyDate = account.ModifyDate;
                custom.ModifyBy = account.ModifyBy;
                custom.Name = account.Staff!=null?account.Staff.Name:"";
                custom.UserType = "Nhân viên";
                if (custom.ModifyBy != 0  && custom.ModifyBy!=null)
                {
                    Users modify = Database.GetById<Users>("select Username from Users where Id =" + custom.ModifyBy);
                    if (modify != null)
                        custom.ModifyName = modify.UserName;
                }
                lstAccount.Add(custom);
            }
            List<CustomUser> lstFinal = new List<CustomUser>();
            if(isloadAll==true)
                gridView.DataSource = lstAccount;
            else
            {
                foreach(CustomUser user in lstAccount)
                {
                    if (user.ModifyBy == UserManagement.UserSession.Id)
                        lstFinal.Add(user);
                }
                gridView.DataSource = lstFinal;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(UserManagement.AllowCreate("Users")==true)
            {
                frmCreateUser frmCreate = new frmCreateUser();
                frmCreate.Show();
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền tạo mới");
            }
        }
        public delegate void delgSetFormEnable(bool isEnable);
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(UserManagement.AllowEdit("Users")==true)
            {
                CustomUser user = null;
                int selectedrow = metroGrid1.CurrentRow.Index;
                //if (selectedrow == 0) return;
                user = (CustomUser)metroGrid1.Rows[selectedrow].DataBoundItem;
                if (user == null) return;
                frmEditUser frmEdit = new frmEditUser(user);
                frmEdit.Show();
                Form form = (frmPrimary)UtilityFunction.FindForm("frmPrimary");
                if (form == null) return;
                frmPrimary frmPrimary = (frmPrimary)form;
                delgSetFormEnable delg = new delgSetFormEnable(frmPrimary.SetEnable);
                delg(false);
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền chỉnh sửa");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UserManagement.AllowDelete("Users") == true)
            {
                DialogResult result = FlatMsgBox.Show("Bạn có chắc muốn xóa người dùng này ?", "Cảnh báo", FlatMsgBox.Buttons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CustomUser user = null;
                    int selectedrow = metroGrid1.CurrentRow.Index;
                    //if (selectedrow == 0) return;
                    user = (CustomUser)metroGrid1.Rows[selectedrow].DataBoundItem;
                    if (user == null) return;
                    bool ok = Database.DeleteById<Users>("delete Users where Id = " + user.Id.ToString());
                    if (ok == false)
                    {
                        FlatMsgBox.Show("Không thể xóa");
                        return;
                    }
                    LoadUser(this.isLoadAll, metroGrid1);
                }
                else return;
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền tạo mới");
            }
        }
    }
}

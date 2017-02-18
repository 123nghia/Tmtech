
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TmTech_v1.Utility;
using TmTech_v1.Model;
using ModernUI.Forms;
namespace TmTech_v1.View
{
    public partial class frmCreateUser : MetroForm
    {
        IDbConnection db = DbTmTech.DbCon;
        List<UserType> lstUserType;
        List<Company> lstCompany;
      //  List<Staff> lstStaff;
        List<UserGroup> lstUserGroup;
        
        private enum UserTypes {Company =1, Nhanvien  =2};
        public frmCreateUser()
        {
            InitializeComponent();
            lstUserType = Database.GetAll<UserType>("select * from UserType");
            //lstStaff = Database.GetAll<Staff>("select * from Staff");
            lstCompany = Database.GetAll<Company>("Select * from Company");
            lstUserGroup = Database.GetAll<UserGroup>("select * from UserGroup");
            lstUserGroup.Add(new UserGroup { Id = 0, GroupName = "Không xác định" });
        }

        private void Create_Load(object sender, EventArgs e)
        {
            cbbUsertype.DataSource = lstUserType;
            cbbUsertype.DisplayMember = "Name";
            cbbUsertype.ValueMember = "Id";
            cbbUserGroup.DataSource = lstUserGroup;
            cbbUserGroup.DisplayMember = "Name";
            cbbUserGroup.ValueMember = "Id";
            LoadUserStaff();
        }

        public delegate void delgSetFormEnable(bool isEnable);
        private void Create_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form = (frmPrimary)UtilityFunction.FindForm("frmPrimary");
            if (form == null) return;
            frmPrimary frmPrimary = (frmPrimary)form;
            delgSetFormEnable delg = new delgSetFormEnable(frmPrimary.SetEnable);
            delg(true);
        }
        


        private bool Create(Users user)
        {
            if (user == null) return false;
            string insert = "insert into Users values (@UserName,@Password,@RecoverEmail,@UserTypeId,@UserGroupId,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)";
            try
            {
                Database.Insert<Users>(insert, user);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        private void cbbUsertype_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbUser.DataSource = null;
            LoadUserStaff();
        }
        private void LoadUserStaff()
        {
            BindingSource bds = new BindingSource();
            if (cbbUsertype.SelectedValue.ToString() == ((int)UserTypes.Company).ToString())
            {
                bds.DataSource = lstCompany;
                cbbUser.DataSource = bds.DataSource;
                cbbUser.DisplayMember = "Name";
                cbbUser.ValueMember = "Id";
            }
            if (cbbUsertype.SelectedValue.ToString() == ((int)UserTypes.Nhanvien).ToString())
            {
               // cbbUser.DataSource = lstStaff;
                cbbUser.DisplayMember = "Name";
                cbbUser.ValueMember = "Id";
            }
        }


        private void lnkCreateUserGroup_Click(object sender, EventArgs e)
        {
            Form form = (frmPrimary)UtilityFunction.FindForm("frmPrimary");
            if (form == null) return;
            frmPrimary frmPrimary = (frmPrimary)form;
            TabPage tabUserGroup = new TabPage("User Group");
            tabUserGroup.Name = "UserGroup";
            //frmPrimary.mainTabCtrl.TabPages.Add(tabUserGroup);
            //frmPrimary.mainTabCtrl.SelectedIndex = frmPrimary.mainTabCtrl.TabCount - 1;
            this.Close();
        }
        private delegate void delgRefresh(bool viewPermission);
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPass.Text) || string.IsNullOrWhiteSpace(txtRetypePass.Text) || string.IsNullOrWhiteSpace(txtRecoverEmail.Text))
            {
                FlatMessageBox.FlatMsgBox.Show("Bạn phải nhập đủ thông tin", "", FlatMessageBox.FlatMsgBox.Buttons.OK, FlatMessageBox.FlatMsgBox.Icon.Info);
                return;
            }
            if (txtPass.Text.Trim() != txtRetypePass.Text.Trim())
            {
                FlatMessageBox.FlatMsgBox.Show("Mật khẩu không khớp", "", FlatMessageBox.FlatMsgBox.Buttons.OK, FlatMessageBox.FlatMsgBox.Icon.Info);
                return;
            }
            Users user = new Users();
            user.UserName = txtUserName.Text;
            user.Password = UtilityFunction.GetSHA256Hash(txtPass.Text);
            user.RecoverEmail = txtRecoverEmail.Text;
            user.ModifyDate = DateTime.Now;
            user.ModifyBy = UserManagement.UserSession.Id;
            user.CreateDate = DateTime.Now;
            user.CreateBy = user.ModifyBy;
            if ((int)cbbUsertype.SelectedValue != 0)
                user.UserTypeId = (int)cbbUsertype.SelectedValue;
            else
            {
                FlatMessageBox.FlatMsgBox.Show("Bạn chưa chọn loại người dùng");
                return;
            }
            if ((int)cbbUserGroup.SelectedValue != 0)
                user.UserGroupId = (int)cbbUserGroup.SelectedValue;
            if (Create(user) == true)
            {
                FlatMessageBox.FlatMsgBox.Show("Success");
                frmUsersView frmViewUser = UtilityFunction.FindUserCtrl("frmUsersView") as frmUsersView;
                if (frmViewUser != null)
                {
                    if (UserManagement.AllowViewAll("USers") == true)
                        frmViewUser.isLoadAll = true;
                    else
                        frmViewUser.isLoadAll = false;
                    delgRefresh delgLoadUser = new delgRefresh(frmViewUser.LoadUser);
                    delgLoadUser(frmViewUser.isLoadAll);
                    this.Close();
                }
            }
            else
            {
                FlatMessageBox.FlatMsgBox.Show("Không thành công");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

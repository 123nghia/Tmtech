
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using TmTech_v1.Utility;
using TmTech_v1.Model;
using ModernUI.Forms;
namespace TmTech_v1.View
{
    public partial class frmEditUser : MetroForm
    {
        CustomUser m_CustomUser;
        IDbConnection db = DbTmTech.DbCon;
        public frmEditUser()
        {
            InitializeComponent();
            m_CustomUser = new CustomUser();
        }
        public frmEditUser(CustomUser customeUser)
        {
            InitializeComponent();
            m_CustomUser = customeUser;
        }
        private void Edit_Load(object sender, EventArgs e)
        {
            if(m_CustomUser != null)
            {
                string select = string.Empty;
                txtUserName.Text = m_CustomUser.UserName;
                txtRecoverEmail.Text = m_CustomUser.RecoverEmail;
                txtUser.Text = m_CustomUser.Name;
            }
        }

        public delegate void delgSetFormEnable(bool isEnable);
        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form = (frmPrimary)UtilityFunction.FindForm("frmPrimary");
            if (form == null) return;
            frmPrimary frmPrimary = (frmPrimary)form;
            delgSetFormEnable delg = new delgSetFormEnable(frmPrimary.SetEnable);
            delg(true);
        }
        private void Edit(int Id,CustomUser user)
        {
            if(Id!=0 && user!=null)
            {
                Users account = Database.Find<Users>("select * from Users where Id = " + Id.ToString());
                if(account!=null)
                {
                    account.UserName = user.UserName;
                    account.Password = user.Password;
                    account.RecoverEmail = user.RecoverEmail;
                    account.ModifyDate = DateTime.Now;
                    account.ModifyBy = UserFunction.GetAccount().Id;
                    Database.Update<Users>("update Users set UserName =@UserName,Password =@Password,RecoverEmail = @RecoverEmail,ModifyDate = @ModifyDate,ModifyBy = @ModifyBy", account);
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            
            CustomUser customUser = new CustomUser();
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtOldPass.Text) || string.IsNullOrWhiteSpace(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtRetypePass.Text) || string.IsNullOrWhiteSpace(txtRecoverEmail.Text))
            {
                FlatMessageBox.FlatMsgBox.Show("Bạn phải nhập đủ thông tin", "", FlatMessageBox.FlatMsgBox.Buttons.OK, FlatMessageBox.FlatMsgBox.Icon.Info);
                return;
            }
            Users account = Database.Find<Users>("select * from Users where UserName = '" + txtUserName.Text.Trim() + "'");
            if (account == null)
            {
                FlatMessageBox.FlatMsgBox.Show("Tên đăng nhập không đúng", "", FlatMessageBox.FlatMsgBox.Buttons.OK, FlatMessageBox.FlatMsgBox.Icon.Info);
                return;
            }
            if (UtilityFunction.GetSHA256Hash(txtOldPass.Text) != account.Password)
            {
                FlatMessageBox.FlatMsgBox.Show("Mật khẩu không đúng", "", FlatMessageBox.FlatMsgBox.Buttons.OK, FlatMessageBox.FlatMsgBox.Icon.Info);
                return;
            }
            if (txtNewPass.Text.Trim() != txtRetypePass.Text.Trim())
            {
                FlatMessageBox.FlatMsgBox.Show("Mật khẩu mới không khớp", "", FlatMessageBox.FlatMsgBox.Buttons.OK, FlatMessageBox.FlatMsgBox.Icon.Info);
                return;
            }
            customUser.Id = m_CustomUser.Id;
            customUser.UserName = txtUserName.Text;
            customUser.Password = UtilityFunction.GetSHA256Hash(txtNewPass.Text);
            customUser.RecoverEmail = txtRecoverEmail.Text;
            Edit(customUser.Id, customUser);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

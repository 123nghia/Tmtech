using System;
using System.Windows.Forms;
using TmTech_v1.Utility;
using TmTech_v1.Model;
using ModernUI.Forms;
using Dapper;
using System.Data;
using FlatMessageBox;
using System.Linq;
namespace TmTech_v1
{
    public partial class frmLogin : MetroForm
    {
        IDbConnection db = null;
        public frmLogin()
        {
            this.Select();
            InitializeComponent();
            this.txtUserName.TabIndex = 10;
            txtUserName.Select();
            txtUserName.Focus();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtUserName.Select();
            txtUserName.Focus();
            this.AcceptButton = btnLogin;
        }


        private void btnSetupDb_Click(object sender, EventArgs e)
        {
            frmSetupDb frmSetupDb = new frmSetupDb();
            frmSetupDb.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Development
            txtUserName.Text = "quangphat";
            txtPass.Text = "number8";
            //

            if (DbTmTech.GetDbFromFile() == false)
            {
                FlatMsgBox.Show("Chưa thiết lập kết nối");
                return;
            }
            else
            {
                if (DbTmTech.TestConnect() == false)
                {
                    FlatMsgBox.Show("Chưa thiết lập kết nối");
                    return;
                }
                else
                    db = DbTmTech.DbCon;
            }
            string passHashed = UtilityFunction.GetSHA256Hash(txtPass.Text);
            string select = string.Format("select * from Users where UserName = '{0}' and Password = '{1}'", txtUserName.Text, passHashed);
            Users user = db.Query<Users>(select).SingleOrDefault();
            if (user == null)
            {
                FlatMessageBox.FlatMsgBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Login Failed", FlatMessageBox.FlatMsgBox.Buttons.OK);
                return;
            }
            UserManagement.SetUserSession(user);
            //frmMain frmMain = new frmMain();
            //frmMain.Show();
            frmPrimary frmPrimary = new frmPrimary();
            frmPrimary.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

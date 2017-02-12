using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModernUI.Forms;
using Dapper;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
namespace Generate_Insert_Script
{
    public partial class frmConnect : MetroForm
    {
        ConnectionInfo conInfo;
        public frmConnect()
        {
            InitializeComponent();
            conInfo = null;
            this.Select();
        }

        private delegate void delgRefresh(string dbname);
        private void btnConnect_Click(object sender, EventArgs e)
        {
            conInfo = new ConnectionInfo();
            conInfo.ServerName = txtServer.Text;
            if (cbbDatabase.SelectedItem == null) return;
            conInfo.DatabaseName = cbbDatabase.SelectedItem.ToString();
            conInfo.UserName = txtUsername.Text;
            conInfo.Password = txtPassword.Text;
            if(string.IsNullOrEmpty(conInfo.Password) || string.IsNullOrWhiteSpace(conInfo.Password))
                conInfo.AuthenticaionType = 1;
            else
                conInfo.AuthenticaionType = 2;
            bool result = Connection.SetConnection(conInfo);
            if (result == false)
            {
                FlatMessageBox.FlatMsgBox.Show("Kết nối không thành công");
                return;
            }
            else
            {
                frmPrimary exist = UtilityFunction.FindForm("frmPrimary") as frmPrimary;
                if (exist != null)
                {
                    exist.conInfo = this.conInfo;
                    delgRefresh delrefresh = new delgRefresh(exist.LoadTable);
                    delrefresh(conInfo.DatabaseName);
                }
                else
                {
                    frmPrimary frmPrimary = new frmPrimary();
                    frmPrimary.conInfo = this.conInfo;
                    frmPrimary.Show();
                }
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            conInfo = UtilityFunction.ReadDbInfo();
            if (conInfo != null)
            {
                txtServer.Text = conInfo.ServerName;
                txtUsername.Text = conInfo.UserName;
                txtPassword.Text = conInfo.Password;
                cbbDatabase.DataSource = null;
                generateDbList();
                cbbDatabase.SelectedItem = conInfo.DatabaseName;
            }
        }

        private void cbbDatabase_DropDown(object sender, EventArgs e)
        {
            cbbDatabase.DataSource = null;
            generateDbList();
        }
        private bool generateDbList()
        {
            ServerConnection servConn = new ServerConnection();
            servConn.ServerInstance = txtServer.Text;
            servConn.LoginSecure = true;
            //servConn.Login = txtUsername.Text;
            //servConn.Password = "";
            try
            {
                servConn.Connect();
                Microsoft.SqlServer.Management.Smo.Server srv = new Microsoft.SqlServer.Management.Smo.Server(servConn);
                DatabaseCollection lstdbnames = srv.Databases;
                servConn.Disconnect();
                foreach (Microsoft.SqlServer.Management.Smo.Database db in lstdbnames)
                {
                    cbbDatabase.Items.Add(db.Name);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

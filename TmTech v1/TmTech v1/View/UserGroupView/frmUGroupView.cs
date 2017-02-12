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
    public partial class frmUGroupView : UserControl
    {
        IDbConnection db = DbTmTech.DbCon;
        public bool isLoadAll;
        public frmUGroupView()
        {
            InitializeComponent();
        }

        internal void LoadGrid(bool viewPermission)
        {
            this.isLoadAll = viewPermission;
            LoadUserGroup(isLoadAll, metroGrid1);
        }
        private void LoadUserGroup(bool isloadAll, MetroGrid gridView)
        {
            gridView.DataSource = null;
            string select = string.Empty;
            select = string.Format("select ROW_NUMBER() OVER (ORDER BY ug.Id)  as Stt,* from UserGroup ug inner join Users u on ug.ModifyBy = u.Id where Id = " + UserManagement.UserSession.Id);
            if (isloadAll == true)
                select = string.Format("select ROW_NUMBER() OVER (ORDER BY ug.Id)  as Stt, * from UserGroup ug inner join Users u on ug.CreateBy = u.Id");
            List<UserGroup> lstUserGroup = new List<UserGroup>();
            lstUserGroup = db.Query<UserGroup, Users, UserGroup>(select, (ug, u) => { ug.Users = u;return ug; }).ToList();
            gridView.DataSource = lstUserGroup;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserGroup ugroup = metroGrid1.SelectedRows[0].DataBoundItem as UserGroup;
            if (ugroup == null)
                return;
            if (UserManagement.AllowDelete("UserGroup") == true && UserManagement.AllowDelete("Permissions") == true)
            {
                DialogResult result = FlatMsgBox.Show("Bạn có chắc muốn xóa ?","Cảnh báo", FlatMsgBox.Buttons.YesNo);
                if(result== DialogResult.Yes)
                {
                    if(UtilityFunction.Delete(ugroup.Id, "UserGroup")==true)
                    {
                        FlatMessageBox.FlatMsgBox.Show("Success");
                        LoadUserGroup(this.isLoadAll, metroGrid1);
                    }
                    else
                    {
                        FlatMessageBox.FlatMsgBox.Show("Failed");
                    }
                }
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền tạo mới");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (UserManagement.AllowCreate("UserGroup") == true && UserManagement.AllowCreate("Permissions")==true)
            {
                frmCreateUGroup frmCreate = new frmCreateUGroup();
                frmCreate.Show();
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền tạo mới");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (UserManagement.AllowEdit("UserGroup") == true && UserManagement.AllowEdit("Permissions") == true)
            {
                UserGroup uGroup = metroGrid1.SelectedRows[0].DataBoundItem as UserGroup;
                frmCreateUGroup frmCreate = new frmCreateUGroup(uGroup);
                frmCreate.Show();
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền tạo mới");
            }
        }
    }
}

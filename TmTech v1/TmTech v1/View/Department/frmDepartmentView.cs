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
using Material;
using TmTech_v1.Model;
using System.Reflection;
using ModernUI.Controls;
using TmTech_v1.Model;
namespace TmTech_v1.View
{
    public partial class frmDepartmentView : UserControl
    {
        IDbConnection db = DbTmTech.DbCon;
        public bool isLoadAll;
        private MaterialTabControl mainTabCtrl;
        public frmDepartmentView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            //LoadUser(true,grid);
        }

        public void LoadGrid(bool viewPermission)
        {
            this.isLoadAll = viewPermission;
            LoadDepartment(this.isLoadAll, metroGrid1);
        }
        private void LoadDepartment(bool isloadAll, MetroGrid gridView)
        {
            gridView.DataSource = null;
            gridView.AutoGenerateColumns = false;
            List<Department> lstProduct = new List<Department>();
            string select = string.Empty;
            select = string.Format(@"select rank() over(order by d.Id) as Stt,d.Id as Id,d.Code as Code,d.Name as Name,d.HeaderId,d.Quantity,d.Note,d.CreateDate,d.ModifyDate,s.Id,s.Name,u.Id,u.UserName
                                      from Department d full join Staff s on d.HeaderId = s.Id inner join Users u on d.CreateBy = u.Id");
            if(isloadAll==true)
            select += " where d.CreateBy = " + +UserManagement.UserSession.Id;
          //  lstProduct = db.Query<Department, Staff, Users, Department>(select, (d, s, u) => { d.Staff = s; d.User = u; return d; }, splitOn: "Id,Id").ToList();
            gridView.DataSource = lstProduct;
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (UserManagement.AllowCreate("Department") == true)
            {
                frmDepartmentDetail frmCreate = new frmDepartmentDetail();
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
            if (UserManagement.AllowEdit("Department") == true)
            {
                Department depart = metroGrid1.SelectedRows[0].DataBoundItem as Department;
                frmDepartmentDetail frmCreate = new frmDepartmentDetail(depart);
                frmCreate.Show();
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
                    //CustomUser user = null;
                    //int selectedrow = grdView.GetSelectedRows().FirstOrDefault();
                    ////if (selectedrow == 0) return;
                    //user = (CustomUser)grdView.GetRow(selectedrow);
                    //if (user == null) return;
                    //bool ok = Database.DeleteById<Users>("delete Users where Id = " + user.Id.ToString());
                    //if (ok == false)
                    //{
                    //    FlatMsgBox.Show("Không thể xóa");
                    //    return;
                    //}
                    //LoadUser(this.isLoadAll, grid);
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

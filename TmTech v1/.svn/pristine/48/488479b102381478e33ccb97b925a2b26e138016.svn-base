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
namespace TmTech_v1.View
{
    public partial class frmStaffView : UserControl
    {
        IDbConnection db = DbTmTech.DbCon;
        public bool isLoadAll;
        public frmStaffView()
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
        }
//        {
//            gridView.DataSource = null;
//            gridView.AutoGenerateColumns = false;
//         //  List<Staff> lstStaff = new List<Staff>();
//            string select = string.Empty;
//            select = string.Format(@"select rank() over(order by s.Id) as Stt,s.Id as Id,s.Code as Code,s.Name as Name,s.Phone1,s.Email,s.Skype,s.Address,s.Birthday,s.ModifyDate,d.Id,d.Name,sp.Id,sp.Name,u.UserName,u.Id,u.UserName
//                                      from Staff s inner join Department d on s.DepartmentId = d.Id inner join StaffPosition sp on s.PositionId = sp.Id inner join Users u on s.CreateBy = u.Id");
//            if(isloadAll==true)
//            select += " where s.CreateBy = " + +UserManagement.UserSession.Id;
//           // lstStaff = db.Query<Staff, Department, StaffPosition, Users, Staff>(select, (s, d, sp, u) => { s.Department = d; s.StaffPosition = sp; s.User = u; return s; }, splitOn: "Id,Id,UserName").ToList();
//            gridView.DataSource = lstStaff;
        //}


        private void btnCreate_Click(object sender, EventArgs e)
        {
            //if(UserManagement.AllowCreate("Product")==true)
            //{
            //    frmCreateProduct frmCreate = new frmCreateProduct();
            //    mainTabCtrl = UtilityFunction.FindTabCtrl("mainTabCtrl");
            //    TabPage tab = new TabPage("Tạo sản phẩm");
            //    tab.Controls.Add(frmCreate);
            //    mainTabCtrl.TabPages.Add(tab);
            //    mainTabCtrl.SelectedTab = mainTabCtrl.TabPages[mainTabCtrl.TabCount - 1];
            //}
            //else
            //{
            //    FlatMsgBox.Show("Bạn không có quyền tạo mới");
            //}
        }
        public delegate void delgSetFormEnable(bool isEnable);
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if(UserManagement.AllowEdit("Users")==true)
            //{
            //}
            //else
            //{
            //    FlatMsgBox.Show("Bạn không có quyền chỉnh sửa");
            //}
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

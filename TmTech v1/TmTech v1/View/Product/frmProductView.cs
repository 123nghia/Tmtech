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
    public partial class frmProductView : UserControl
    {
        IDbConnection db;
        public bool isLoadAll;
        private MaterialTabControl mainTabCtrl;
        public frmProductView()
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
            LoadProduct(this.isLoadAll, metroGrid1);
        }
        private void LoadProduct(bool isloadAll, MetroGrid gridView)
        {
            IDbConnection db = DbTmTech.Create();
            gridView.DataSource = null;
            gridView.AutoGenerateColumns = false;
            List<TmTech_v1.Model.Product> lstProduct = new List<TmTech_v1.Model.Product>();
            string select = string.Empty;
            select = string.Format(@"select rank() over(order by p.Id) as Stt,p.Id as Id,p.Code as Code,p.Name as Name,p.InputVoltage as InputVoltage ,
                                    p.Long as Long,p.Height as Height,p.Width as Width,p.Led as Led,p.Angle as Angle,p.IP as IP,p.Watt as Watt,c.Id as Id,c.Name as Name
                                        from Product p inner join Category c on p.CategoryId = c.Id");
            if(isloadAll==true)
            select = @"select rank() over(order by p.Id) as Stt,p.Id as Id,p.Code as Code,p.Name as Name,p.InputVoltage as InputVoltage ,
                    p.Long as Long,p.Height as Height,p.Width as Width,p.Led as Led,p.Angle as Angle,p.IP as IP,p.Watt as Watt,c.Id as Id,c.Name as Name
                        from Product p left join Category c on p.CategoryId = c.Id where p.CreateBy = " + +UserManagement.UserSession.Id;
            lstProduct = db.Query<TmTech_v1.Model.Product, TmTech_v1.Model.Category, TmTech_v1.Model.Product>(select,(p,c)=> { p.Category = c; return p; },splitOn: "Id").ToList();
            gridView.DataSource = lstProduct;
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(UserManagement.AllowCreate("Product")==true)
            {
                frmCreateProduct frmCreate = new frmCreateProduct();
                mainTabCtrl = UtilityFunction.FindTabCtrl("mainTabCtrl");
                TabPage tab = new TabPage("Tạo sản phẩm");
                tab.Controls.Add(frmCreate);
                mainTabCtrl.TabPages.Add(tab);
                mainTabCtrl.SelectedTab = mainTabCtrl.TabPages[mainTabCtrl.TabCount - 1];
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
                DialogResult result = FlatMsgBox.Show(MesgBox.MSGRemoveItem, "Cảnh báo", FlatMsgBox.Buttons.YesNo);
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

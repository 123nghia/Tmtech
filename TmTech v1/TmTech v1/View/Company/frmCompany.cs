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
using System.Reflection;
using ModernUI.Controls;
using System.Resources;
using ModernUI.Forms;

namespace TmTech_v1.View.Customer
{
    public partial class frmCompany : UserControl
    {
        IDbConnection db = DbTmTech.DbCon;
        public bool isLoadAll;
        ResourceManager rm = new ResourceManager("UsingRESX.MessageBox",
                Assembly.GetExecutingAssembly());
        

        public frmCompany()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void Lstcategory_Load(object sender, EventArgs e)
        {

        }

        public void loadCustormer(bool viewPermission)
        {
            this.isLoadAll = viewPermission;
            LoadDataCustomer(isLoadAll, metroGrid1);  // load data
        }
        public void loadCustormer()
        {
            
            LoadDataCustomer(isLoadAll, metroGrid1);  // load data
        }
        /// <summary>
        /// load all data customer from datatbase
        /// </summary>
        /// <param name="isLoadAll"></param>
        /// <param name="gridView"></param>
        private void LoadDataCustomer(bool isLoadAll, MetroGrid gridView)
        {

            gridView.AutoGenerateColumns = false;
            string select = string.Empty;
            select = string.Format("select * from Company ");
            if (isLoadAll == false)
            {
                select = string.Format("select * from Company  where  CreateBy =  " + UserManagement.UserSession.Id);
            }
            List<TmTech_v1.Model.Company> LstCompany = new List<TmTech_v1.Model.Company>();
            LstCompany = db.Query<TmTech_v1.Model.Company>(select).ToList();
            gridView.DataSource = null;
            gridView.DataSource = LstCompany;







        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (UserManagement.AllowCreate("Company") == true)
            {
                frmCreateCompany frmCreate = new frmCreateCompany();

                frmCreate.Show();
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền tạo mới");


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (metroGrid1.Rows.Count < 1)
            {
                FlatMsgBox.Show("Không có thông tin để xóa");
                return;
            }

            if (metroGrid1.CurrentCell.RowIndex < 0)
                return;
            if (UserManagement.AllowDelete("Company") == true)
            {
                DialogResult result = FlatMsgBox.Show("Bạn có chắc muốn xóa  khách hàng công ty  này ?", "Cảnh báo", FlatMsgBox.Buttons.YesNo);
                if (result == DialogResult.Yes)
                {
                    TmTech_v1.Model.Company cate = null;
                    int selectedrow = metroGrid1.CurrentCell.RowIndex;
                    //if (selectedrow == 0) return;
                    cate = (TmTech_v1.Model.Company)metroGrid1.Rows[selectedrow].DataBoundItem as TmTech_v1.Model.Company;
                    if (cate == null) return;
                    bool ok = Database.DeleteById<TmTech_v1.Model.Company>("delete from company  where Id = " + cate.Id);
                    if (ok == false)
                    {
                        FlatMsgBox.Show("Không xóa được ");
                        return;
                    }
                    else
                    {


                        LoadDataCustomer(isLoadAll, metroGrid1);
                    }

                }
                else return;
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền xóa ");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (UserManagement.AllowEdit("Company") == true)
            {
                int selectedrow = metroGrid1.CurrentCell.RowIndex;
                //if (selectedrow == 0) return;
                TmTech_v1.Model.Company cate = (TmTech_v1.Model.Company)metroGrid1.Rows[selectedrow].DataBoundItem as TmTech_v1.Model.Company;
                frmEditCompany objEdit = new frmEditCompany(cate);
                objEdit.Show();

              
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền chỉnh sửa");
            }
        }

    }
}

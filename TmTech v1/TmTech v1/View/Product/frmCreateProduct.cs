using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using TmTech_v1.Utility;
using FlatMessageBox;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Repository;
namespace TmTech_v1.View
{
    public partial class frmCreateProduct : UserControl
    {
        IDbConnection db = DbTmTech.DbCon;
        List<TmTech_v1.Model.Category> lstCategory;
        public frmCreateProduct()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            lstCategory = new List<TmTech_v1.Model.Category>();
            
        }
        private void LoadCategory()
        {
            lstCategory = Database.GetAll<TmTech_v1.Model.Category>("select Id,Name from Category");
            cbbCategory.DataSource = null;
            cbbCategory.DataSource = lstCategory;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "Id";
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
        private bool Create(TmTech_v1.Model.Product product)
        {
            if (product == null) return false;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.ProductRepository.Add(product);
                    uow.Commit();
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        private delegate void delgRefresh(bool viewPermission);
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                FlatMsgBox.Show("Chưa nhập mã sản phẩm");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                FlatMsgBox.Show("Chưa nhập tên sản phẩm");
                return;
            }
            if (Database.isCodeExist<TmTech_v1.Model.Product>(txtCode.Text, "Product") == true)
            {
                FlatMsgBox.Show("Mã sản phẩm đã tồn tại");
                return;
            }
            TmTech_v1.Model.Product product = new TmTech_v1.Model.Product();
            product.Code = txtCode.Text;
            product.Name = txtName.Text;
            product.CategoryId = (int)cbbCategory.SelectedValue;
            product.Led = txtLed.Text;
            product.InputVoltage = double.Parse(txtVolt.Text);
            product.Long = double.Parse(txtLong.Text);
            product.Width = double.Parse(txtWidth.Text);
            product.Height = double.Parse(txtHeight.Text);
            product.Watt = double.Parse(txtWatt.Text);
            product.Angle = double.Parse(txtAngle.Text);
            product.IP = double.Parse(txtIP.Text);
            product.ModifyBy = product.CreateBy = UserManagement.UserSession.Id;
            product.CreateDate = product.ModifyDate = DateTime.Now;
            if (Create(product) == true)
            {
                FlatMessageBox.FlatMsgBox.Show("Success");
                TmTech_v1.View.frmProductView frmView = UtilityFunction.FindUserCtrl("frmProductView") as TmTech_v1.View.frmProductView;
                if (frmView != null)
                {
                    delgRefresh delgLoadData = new delgRefresh(frmView.LoadGrid);
                    delgLoadData(frmView.isLoadAll);
                }
            }
            else
            {
                FlatMessageBox.FlatMsgBox.Show("Không thành công");
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            List<TextBox> lstTextbox = new List<TextBox>();
            lstTextbox = UtilityFunction.FindAllTextbox<TextBox>(this, true).ToList();
            if (lstTextbox != null)
            {
                foreach (TextBox textbox in lstTextbox)
                {
                    textbox.Clear();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}

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
using ModernUI.Forms;
namespace TmTech_v1.View.Customer
{
    public partial class frmCreateCompany :MetroForm
    {
        IDbConnection db = DbTmTech.DbCon;
        List<TmTech_v1.Model.Company> lstParrentCompay;
        
        List<TmTech_v1.Model.CustomerType> lstTypeCustomer;
        List<TmTech_v1.Model.Company> lstCompany;
        public  Boolean isnew = true;
        public frmCreateCompany()
        {
            InitializeComponent();
         
            this.Dock = DockStyle.Fill;
            lstCompany = new List<TmTech_v1.Model.Company>();
            //input range 
            UtilityFunction.ConstantInput(this.pnelKhachHang);
            UtilityFunction.LostFocus(this.pnelKhachHang);
            Loaddata();
        }

        private void Loaddata()
        {
            loadLstTypeCustomer();
            LoadParentCompany();
        }
        private void loadLstTypeCustomer()
        {
            if (lstCompany != null)
            {
                lstTypeCustomer   = Database.GetAll<TmTech_v1.Model.CustomerType>("SELECT * FROM CustomerType");
                lstTypeCustomer.Add(new TmTech_v1.Model.CustomerType { Id = 0, Name = "(để trống)" });
               lstTypeCustomer = lstTypeCustomer.OrderBy(p => p.Id).ToList();

                cboTypeCustomer.DataSource = null;
                cboTypeCustomer.DataSource = lstTypeCustomer;

                cboTypeCustomer.ValueMember = "Id";
                cboTypeCustomer.DisplayMember = "Name";
            }


        }

        private void LoadParentCompany()
        {
            if (lstCompany != null)
            {
                lstParrentCompay = Database.GetAll<TmTech_v1.Model.Company>("SELECT  id, Name FROM Company");
                lstParrentCompay.Add(new TmTech_v1.Model.Company { Id = 0, Name = "(để trống)" });
                lstParrentCompay = lstParrentCompay.OrderBy(p => p.Id).ToList();

                cboParentCompany.DataSource = null;

                cboParentCompany.ValueMember = "Id";
                cboParentCompany.DisplayMember = "Name";
                cboParentCompany.DataSource = lstParrentCompay;

            }
        }
    
        
        private void LoadCategory()
        {
        
       
        }
        private void frmCreate_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
        private bool Create(TmTech_v1.Model.Company product)
        {
            if (product == null) return false;
            string insert = @"INSERT INTO dbo.Company( Code ,
          Name ,
          Address ,
          Phone1 ,
          Phone2 ,
          Fax ,
          Taxcode ,
          SwiftCode ,
          Employee ,
          DebitValue ,
          ParentCompanyId ,
          Branch ,
          TagetValue ,
          Website ,
          Email ,
          StaffId ,
          Note ,
          TypeId ,
          CreateDate ,
          CreateBy ,
          ModifyDate ,
          ModifyBy
        )
VALUES  (
          @Code ,
          @Name ,
          @Address ,
          @Phone1 ,
          @Phone2 ,
          @Fax ,
          @Taxcode ,
          @SwiftCode ,
          @Employee ,
          @DebitValue ,
          @ParentCompanyId ,
          @Branch ,
          @TagetValue ,
          @Website ,
          @Email ,
          @StaffId ,
          @Note ,
          @TypeId ,
          @CreateDate ,
          @CreateBy ,
          @ModifyDate ,
          @ModifyBy

        )";
            try
            {
                Database.Insert<TmTech_v1.Model.Company>(insert, product);
                return true;
            }
            catch
            {
                return false;
            }

        }
        private delegate void delgRefresh();
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                FlatMsgBox.Show("Chưa nhập mã khách hàng");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                FlatMsgBox.Show("chưa nhập tên khách hàng");
                return;
            }
            if (Database.isCodeExist<TmTech_v1.Model.Company>(txtCode.Text, "Company") == true)
            {
                FlatMsgBox.Show("Mã khách hàng đã tồn tại");
                return;
            }
            TmTech_v1.Model.Company product = new TmTech_v1.Model.Company();
            product.Code = txtCode.Text;
            product.Name = txtName.Text;
            product.Address = txtAddress.Text;
            product.Phone1 = txtPhone1.Text;
            product.Phone2 = txtPhone2.Text;
            product.Fax = txtFax.Text;
            product.SwiftCode = txtSwiftCode.Text;
            product.Employee = UtilityFunction.getNumberIString(txtEmployee.Text);
            product.DebitValue = UtilityFunction.getNumberDString(txtDebitValue.Text);
            product.ParentCompanyId = UtilityFunction.getNumberIString(cboParentCompany.SelectedValue.ToString());
            product.TagetValue = UtilityFunction.getNumberIString(txtTagetValue.Text);
            product.Website = txtWebsite.Text;
            product.Email = txtEmail.Text;
            product.Note = txtNote.Text;
            product.TypeId = UtilityFunction.getNumberIString(cboTypeCustomer.Text);    
            product.ModifyBy = product.CreateBy = UserManagement.UserSession.Id;
            product.CreateDate = product.ModifyDate = DateTime.Now;
            if (Create(product) == true)
            {
                FlatMessageBox.FlatMsgBox.Show(NotificationMessage.MsgSuccess);
                TmTech_v1.View.Customer.frmCompany frmView = UtilityFunction.FindUserCtrl("frmCompany") as TmTech_v1.View.Customer.frmCompany;
                if (frmView != null)
                {                  
                    delgRefresh delgLoadData = new delgRefresh(frmView.loadCustormer);                  
                    delgLoadData();
                    this.Close();                  
                }
            }
            else
            {
                FlatMessageBox.FlatMsgBox.Show(NotificationMessage.MsgUnsuccess);
            }
        }

        private void btnClearAll_Click_1(object sender, EventArgs e)
        {
            //List<TextBox> lstTextbox = new List<TextBox>();
            //lstTextbox = UtilityFunction.FindAllTextbox<TextBox>(this, true).ToList();
            //if (lstTextbox != null)
            //{
            //    foreach (TextBox textbox in lstTextbox)
            //    {
            //        textbox.Clear();
            //    }
            //}
            UtilityFunction.ResetForm(this.pnelKhachHang);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

  
        
    }
}

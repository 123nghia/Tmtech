
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
namespace TmTech_v1.View.Customer
{
    public partial class frmEditCompany : MetroForm
    {
       Company m_Company;
        IDbConnection db = DbTmTech.DbCon;
        public frmEditCompany()
        {
            InitializeComponent();
            m_Company = new Company();
        }
        public frmEditCompany(Company compannyObject)
        {
            InitializeComponent();
            m_Company = compannyObject;
        }
        private void Edit_Load(object sender, EventArgs e)
        {
            LoadInformation();
        }

        public delegate void delgSetFormEnable(bool isEnable);
        public void LoadInformation()
        {
            if (m_Company != null)
            {
                txtCode.Text = m_Company.Code;
                txtName.Text = m_Company.Name;
                txtAddress.Text = m_Company.Address;
                txtPhone1.Text = m_Company.Phone1;
                txtPhone2.Text = m_Company.Phone2;
                txtDebitValue.Text = m_Company.DebitValue.ToString();
                txtFax.Text = m_Company.Fax;
                txtNote.Text = m_Company.Note;
                txtEmail.Text = m_Company.Email;
                cboTypeCustomer.SelectedValue = m_Company.TypeId;
                cboParentCompany.SelectedValue = m_Company.ParentCompanyId;
                txtEmployee.Text = m_Company.Employee.ToString();
                txtWebsite.Text = m_Company.Website;
                txtTaxcode.Text = m_Company.Taxcode;
                txtTagetValue.Text = m_Company.TagetValue.ToString();
            }
        }
        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private delegate void delgRefresh();
        private void Edit(int Id,Company  objUpdate)
        {
            if(Id!=0 && objUpdate!=null)
            {
        
                if(objUpdate!=null)
                {

                    Database.Update<Company>(@"UPDATE Company SET 
Name =@Name, Address =@Address,Phone1  =@Phone1, Phone2 =@Phone2,Fax  =@Fax, Taxcode =@Taxcode, SwiftCode =@SwiftCode,
Employee = @Employee,DebitValue =@DebitValue,ParentCompanyId =@ParentCompanyId,TagetValue =@TagetValue, Website =@Website,
Email =@Email,Note =@Note,TypeId =@TypeId,ModifyDate =@ModifyDate,
ModifyBy =@ModifyBy  where id =  " +objUpdate.Id, objUpdate);

                    FlatMessageBox.FlatMsgBox.Show(NotificationMessage.MsgSuccess);
                    TmTech_v1.View.Customer.frmCompany frmView = UtilityFunction.FindUserCtrl("frmCompany") as TmTech_v1.View.Customer.frmCompany;
                    if (frmView != null)
                    {
                        delgRefresh delgLoadData = new delgRefresh(frmView.loadCustormer);
                        delgLoadData();
                        this.Close();
                    }


                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {         

            if (UtilityFunction.CheckInput(this.pnelKhachHang) == false)
                return;
            Company company = new Company();
            company = Database.Find<Company>("SELECT * FROM Company WHERE Code  = '" + txtCode.Text + "'");
            company.Code = txtCode.Text;
            company.Name = txtName.Text;
            company.Address = txtAddress.Text;
            company.Phone1 = txtPhone1.Text;
            company.Phone2 = txtPhone2.Text;
            company.Fax = txtFax.Text;
            company.SwiftCode = txtSwiftCode.Text;
            company.Employee = UtilityFunction.getNumberIString(txtEmployee.Text);
            company.DebitValue = UtilityFunction.getNumberDString(txtDebitValue.Text);      
            company.TagetValue = UtilityFunction.getNumberIString(txtTagetValue.Text);
            company.Website = txtWebsite.Text;
            company.Email = txtEmail.Text;
            company.Note = txtNote.Text;            
            company.ModifyBy = company.CreateBy = UserManagement.UserSession.Id;
            company.CreateDate = company.ModifyDate = DateTime.Now;                        
            Edit(company.Id,company);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            UtilityFunction.ResetForm(this.pnelKhachHang);
            LoadInformation();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Repository;

namespace TmTech_v1.View.Custormers
{
    public partial class frmCustormer :UserControl
    {
        public frmCustormer()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            _currentCompany = new Company();
            _currentDeputy = new Deputy();
            
        }


        Company _currentCompany = null;
        Deputy _currentDeputy = null;

        private Company _company = null;
        private Deputy _Deputy = null;
             
        Boolean iscreate = false;
        Boolean isupdate = false;
        int _selectRow = -1;      
        
     
        void ResetCreate()
        {
            if( iscreate)
            {
                UtilityFunction.ResetForm(pnlInformation);
            }
        }

        private bool CreateCompany(TmTech_v1.Model.Company company)
        {
            if (company == null) return false;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.CompanyRepository.Add(company);
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        private bool CreateDeputy(TmTech_v1.Model.Deputy deputy)
        {
            if ( deputy == null) return false;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.DeputyRepository.Add(deputy);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void addRowDatagridview( Company objnewCompany, Deputy objnewdeputy)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;   
            DataRow dr = dt.NewRow();
            dr["Code"] = objnewCompany.Code;
            dr["Name"] = objnewCompany.Name;
            dr["Taxcode"] = objnewCompany.Taxcode;
            dr["Address"] = objnewCompany.Address;
            dr["NameDeputy"] = objnewdeputy.Name;
            dr["Address"] = objnewCompany.Address;
            dr["Email"] = objnewCompany.Email;  
            dr["Phone1"]  =  objnewCompany.Phone1;
            dr["TypeId"] = objnewCompany.TypeId;
            dr["TagetValue"] = objnewCompany.TagetValue;
            dr["NoBrank"] = objnewCompany.NoBrank;
            dr["NoStaff"] = objnewCompany.NoStaff;
            dr["Website"] = objnewCompany.Website;           
            dt.AcceptChanges();

        }
        private void LoadCompany()
        {
            List < Company > _ListCompany = new List<Company>();


            using (IUnitOfWork uow = new UnitOfWork())
            {
                _ListCompany = uow.CompanyRepository.All();
            }
            if( _ListCompany.Any())
            {
                dataGridView1.DataSource = _ListCompany;
            }

        }
        private void RemoveDatagridview(   int rowDelete)
        {
            dataGridView1.Rows.RemoveAt(rowDelete);
        }

        private void DeleteDatagridview (string id)
        {

        }
        private void PreUpdate ()
        {

        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {


            if (btnCreateAccount.Text == "Create Account:")
            {
                btnCreateAccount.Text = "Save";
                btnUpdate.Text = "Cancel";
                ResetCreate();
                txtCompanyName.Focus();
                iscreate = true;
                isupdate = false;
                return;
            }
        
            
           if (btnCreateAccount.Text.Equals("Save"))
           {
                if( iscreate ==true)
                {
                    CreateAction();
                }
                else if( isupdate==true)
                {
                    UpdateAction();
                }
           }
           
            
        }
        void UpdateAction()
        {

        }

        void CreateAction ()
        {

            if (txtCompanyName.Text == string.Empty)
            {
                FlatMessageBox.FlatMsgBox.Show("không được để trống");
                txtCompanyName.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtTaxCode.Text))
            {
                FlatMessageBox.FlatMsgBox.Show("không được để trống");
                txtTaxCode.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtTaxCode.Text))
            {
                FlatMessageBox.FlatMsgBox.Show("không được để trống");
                txtTaxCode.Focus();
                return;
            }
           

            Boolean _sex = false;
            if (cbSex.SelectedIndex == 1)
                _sex = true;
            Company objinsert = new Company
            {
                Taxcode = txtTaxCode.Text,
                Name = txtNameContact.Text,
                Address = txtAddree.Text,
                Phone1 = txtPhone.Text,
                SwiftCode = txtSwich.Text,
                Employee = ProfileStaff.Idstaff,
                Email = txtEmail.Text,
                Phone2 = txtPhone.Text,
                NoBrank = txtNoBrach.ValueText,
                NoStaff = txtStaft.ValueText,
                TagetValue = txtTargertValue.ValueText,
                Website = txtWebsite.Text,
                Note = txtNote.Text
            };
            Deputy objdeputy = new Deputy
            {
                Name = txtNameContact.Text,
                Email = txtEmail.Text,
                Phone1 = txtPhone.Text,
                StaffId = txtStaft.ValueText
            };

            if (objdeputy != null && objinsert != null)
            {
                CreateCompany(objinsert);
                CreateDeputy(objdeputy);
            }   
        }
        private void frmCustormer_Load(object sender, EventArgs e)
        {
            LoadCompany();
        }

        private void btnDelteSubAccount_Click(object sender, EventArgs e)
        {
            DialogResult _Result = FlatMessageBox.FlatMsgBox.Show("Bạn muốn xóa tài khoản này không", "Xóa  tài khoản", FlatMessageBox.FlatMsgBox.Buttons.YesNo, FlatMessageBox.FlatMsgBox.Icon.Question);
            if(_Result==DialogResult.No)
            {
                return;
            }
            else
            {
               

            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text.Equals("Modify Account:"))
            {
                btnCreateAccount.Text = "Save"; 
                btnUpdate.Text = "Cancel";
                PreUpdate();
                iscreate = false;
                isupdate = true;
                return;
            }
           if ( btnUpdate.Text =="Cancel")
           {
               DialogResult _Result = FlatMessageBox.FlatMsgBox.Show("Bạn có muốn hủy bỏ thao tác? ", "Xóa  tài khoản", FlatMessageBox.FlatMsgBox.Buttons.YesNo, FlatMessageBox.FlatMsgBox.Icon.Question);
               if (_Result == DialogResult.No)
               {
                   return;
               }
               else
               {


               }
           }
        }
        
        
            private void btnCreateSubAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isupdate || iscreate)
                return;
            _selectRow = e.RowIndex;

            DisplayInformation(_selectRow);
        }

        void DisplayInformation ( int RowDisplay)
        {

            if (_selectRow < 0)
            {
                return;
            }
            else
            {
                DataGridViewRow  DatarowInfor= dataGridView1.Rows[_selectRow];
                if(  DatarowInfor!=null)
                {
                   
                  txtCompanyName.Text = GetValuDisplay(DatarowInfor.Cells["NameCpany"]);                  
                  txtNameContact.Text =GetValuDisplay( DatarowInfor.Cells["NameDeputy"]);
                  txtAddree.Text = GetValuDisplay(DatarowInfor.Cells["Address"]);
                  txtTaxCode.Text = GetValuDisplay(DatarowInfor.Cells["Taxcode"]);
                  txtTaxCode.Text = GetValuDisplay(DatarowInfor.Cells["Taxcode"]);
                  txtBankName.Text = GetValuDisplay(DatarowInfor.Cells["NameCpany"]);
                  txtSwich.Text = GetValuDisplay(DatarowInfor.Cells["NameCpany"]);
                  cboTypeOfCompany.Text = GetValuDisplay(DatarowInfor.Cells["NameCpany"]);
                  CBLevel.SelectedIndex = -1;
                  txtNoBrach.Text = GetValuDisplay(DatarowInfor.Cells["NameCpany"]);
                  txtStaft.Text = GetValuDisplay(DatarowInfor.Cells["NameCpany"]);
                  txtTargertValue.Text = GetValuDisplay(DatarowInfor.Cells["NameCpany"]);
                  txtNameContact.Text =  GetValuDisplay(DatarowInfor.Cells["NameCpany"]);
                  txtEmail.Text =  GetValuDisplay(DatarowInfor.Cells["NameCpany"]);
                  txtPhone.Text =  GetValuDisplay(DatarowInfor.Cells["NameCpany"]);
                  cbSex.SelectedIndex = -1;
                  txtWebsite.Text =  GetValuDisplay(DatarowInfor.Cells["NameCpany"]);
                  txtNote.Text =  GetValuDisplay(DatarowInfor.Cells["NameCpany"]);
                  txtSignatureOfClient.Text =  GetValuDisplay(DatarowInfor.Cells["NameCpany"]);
                  ProfileStaff.Idstaff = 1;

                }

            }
        }

         string  GetValuDisplay ( DataGridViewCell dgrc)
        {
            try
            {
                return dgrc.Value.ToString();
            }
            catch (Exception)
            {

                return "";
            }
        }
        private void pnlInformation_Paint(object sender, PaintEventArgs e)
        {

        }
        
      
     
    }
}

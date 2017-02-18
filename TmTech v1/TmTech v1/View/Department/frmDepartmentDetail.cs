using ModernUI.Forms;
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
using TmTech_v1.Model;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmDepartmentDetail : MetroForm
    {
        IDbConnection db = DbTmTech.DbCon;
        Department m_Depart;
        public frmDepartmentDetail()
        {
            InitializeComponent();
            m_Depart = null;
        }
        public frmDepartmentDetail(Department department)
        {
            InitializeComponent();
            m_Depart = department;
        }

        private void frmProductPriceDetail_Load(object sender, EventArgs e)
        {
            dtpCreateDate.Enabled = dtpModifyDate.Enabled = txtCreateBy.Enabled = txtModifyBy.Enabled = false;
            if(m_Depart!=null)
            {
                Edit(m_Depart);
            }
            else
                if (m_Depart == null)
                {
                    Create();
                }
        }
        private void Edit()
        {
            //txtName.Text = m_Price.Name;
            //txtPrice.Text = m_Price.Price.ToString();
            //txtNote.Text = m_Price.Note;
            //dtpActiveDate.Value = m_Price.ActiveDate.Value;
            //cbActive.Checked = m_Price.Active==null?false:m_Price.Active.Value;
            //cbbProdCode.SelectedValue = m_Price.Product.Id;
            //txtProductName.Text = m_Price.Product.Name;
            //txtCreateBy.Text = m_Price.User.UserName;
            //txtCreateDate.Text = m_Price.CreateDate.ToString();
            //cbbProdCode.Enabled = false;
        }

        private void Create()
        {
            txtName.Clear();
            txtDepartCode.Clear();
            txtQuantity.Clear();
            txtCreateBy.Clear();
            txtModifyBy.Clear();
            txtModifyBy.Text = txtCreateBy.Text = UserManagement.UserSession.UserName;
        }
        private void Edit(Department Depart)
        {
            txtName.Text = m_Depart.Name;
            txtDepartCode.Text = m_Depart.Code;
            txtQuantity.Text = m_Depart.Quantity.ToString(); ;
            txtCreateBy.Text = m_Depart.User.UserName;
            txtModifyBy.Text = m_Depart.User.UserName;
            dtpCreateDate.Value = m_Depart.CreateDate.Value;
            dtpModifyDate.Value = m_Depart.ModifyDate.Value;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepartCode.Text) || string.IsNullOrWhiteSpace(txtDepartCode.Text))
            {
                FlatMessageBox.FlatMsgBox.Show(MesgBox.MsgNameNotNull);
                return;
            }
            if (string.IsNullOrEmpty(txtDepartCode.Text) || string.IsNullOrWhiteSpace(txtDepartCode.Text))
            {
                FlatMessageBox.FlatMsgBox.Show(MesgBox.MsgCodeNotNull);
                return;
            }
            Department depart = new Department();
            depart.Code = txtDepartCode.Text;
            depart.Name = txtName.Text;
            depart.HeaderId = cbbHeader.SelectedValue != null ? int.Parse(cbbHeader.SelectedValue.ToString()) : 0;
            depart.Quantity = (string.IsNullOrEmpty(txtQuantity.Text)&& string.IsNullOrWhiteSpace(txtQuantity.Text))!=true?int.Parse(txtQuantity.Text):0;
            depart.CreateBy = UserManagement.UserSession.Id;
            depart.ModifyBy = UserManagement.UserSession.Id;
            depart.CreateDate = DateTime.Now;
            depart.ModifyDate = DateTime.Now;
            if (m_Depart == null)
            {
                db.Execute("insert into Department(Code,Name,Quantity,HeaderId,Note,CreateDate,CreateBy,ModifyDate,ModifyBy) values (@Code,@Name,@Quantity,@HeaderId,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)", depart);
            }
            else
            {
                db.Execute("update Department set Code= @Code,Name= @Name,Quantity= @Quantity,HeaderId= @HeaderId,Note= @Note,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy where Id = " + m_Depart.Id, depart);
            }
        }

        private void cbbProdCode_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbbHeader.SelectedValue!=null)
            {
                txtQuantity.Text = ((Product)cbbHeader.SelectedItem).Name;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TmTech_v1.Utility;
using TmTech_v1.Model;
using ModernUI.Forms;
using System.Resources;
using System.Reflection;
using TmTech_v1.Interface;
using TmTech_v1.Repository;
namespace TmTech_v1.View
{
    public partial class frmCreateCategory : MetroForm
    {
        IDbConnection db = DbTmTech.DbCon;
        List<TmTech_v1.Model.Category> lstCategory;
        public frmCreateCategory()
        {
            InitializeComponent();
            lstCategory = new List<TmTech_v1.Model.Category>();
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
            LoadCbbParent();
        }
        
        private bool Create(TmTech_v1.Model.Category category)
        {
            
            if (category == null) return false;
            try
            {
                using(IUnitOfWork uow = new UnitOfWork())
                {
                    uow.CategoryRepository.Add(category);
                    uow.Commit();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public delegate void delgSetFormEnable(bool isEnable);
        private void frmCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form form = (frmMain)UtilityFunction.FindForm("frmMain");
            //if (form == null) return;
            //frmMain frmMain = (frmMain)form;
            //delgSetFormEnable delg = new delgSetFormEnable(frmMain.SetEnable);
            //delg(true);
        }

        private void cbbParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadCbbParent()
        {
            if (lstCategory != null)
            {
                lstCategory = Database.GetAll<TmTech_v1.Model.Category>("select * from Category");
                lstCategory.Add(new TmTech_v1.Model.Category { Id = 0, Name = "(để trống)" });
                lstCategory = lstCategory.OrderBy(p => p.Id).ToList();
                cbbParent.DataSource = null;
                cbbParent.DataSource = lstCategory;
                cbbParent.ValueMember = "Id";
                cbbParent.DisplayMember = "Name";
            }
        }
        private delegate void delgloadData(bool viewPermission);
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                FlatMessageBox.FlatMsgBox.Show("Bạn chưa nhập tên nhóm", "", FlatMessageBox.FlatMsgBox.Buttons.OK);
                return;
            }
            TmTech_v1.Model.Category cate = new TmTech_v1.Model.Category();
            cate.Name = txtName.Text;
            if (cbbParent.SelectedValue != null && (int)cbbParent.SelectedValue > 0)
                cate.ParentId = (int)cbbParent.SelectedValue;
            cate.Note = txtNote.Text;
            cate.CreateBy = UserManagement.UserSession.Id;
            cate.CreateDate = DateTime.Now;
            cate.ModifyDate = DateTime.Now;
            cate.ModifyBy = UserManagement.UserSession.Id;
            if (Create(cate) == true)
            {
                FlatMessageBox.FlatMsgBox.Show("Success");
                Lstcategory frmView = UtilityFunction.FindUserCtrl("Lstcategory") as Lstcategory;
                if (frmView != null)
                {
                    delgloadData delgLoad = new delgloadData(frmView.LoadGrid);
                    delgLoad(frmView.isLoadAll);
                    this.Close();
                }
            }
        }

        private void bootstrapButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

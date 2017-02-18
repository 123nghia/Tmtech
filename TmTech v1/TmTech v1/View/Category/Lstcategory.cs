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

namespace TmTech_v1.View
{
    public partial class Lstcategory : UserControl
    {
        IDbConnection db;
        public bool isLoadAll;
        public Lstcategory()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void Lstcategory_Load(object sender, EventArgs e)
        {
            LoadGrid(this.isLoadAll);
        }
        public void LoadGrid(bool viewPermission)
        {
            this.isLoadAll = viewPermission;
            LoadCategory(isLoadAll, metroGrid1);
        }
        private void LoadCategory(bool isloadAll, MetroGrid gridView)
        {
            db = DbTmTech.Create();
            gridView.DataSource = null;
            gridView.AutoGenerateColumns = false;
            string select = string.Empty;
            select = string.Format("select rank() over(order by c.Id) as Stt, * from Category c inner join Users u on c.ModifyBy = u.Id");
            if (isloadAll == false)
                select = string.Format("select rank() over(order by c.Id) as Stt,* from Category c inner join Users u on c.ModifyBy = u.Id where c.CreatedBy = " + UserManagement.UserSession.Id);
            List<TmTech_v1.Model.Category> lstCategory = new List<TmTech_v1.Model.Category>();
            lstCategory = db.Query<TmTech_v1.Model.Category, TmTech_v1.Model.Users, TmTech_v1.Model.Category>(select, (c, u) => { c.User = u; return c; }).ToList();
            gridView.DataSource = null;
            BindingSource source = new BindingSource();
            source.DataSource = lstCategory;
            gridView.DataSource = source;
            gridView.Columns[0].Width = 50;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (UserManagement.AllowCreate("Category") == true)
            {
                frmCreateCategory frmCreate = new frmCreateCategory();
                frmCreate.Show();
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền tạo mới");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UserManagement.AllowDelete("Category") == true)
            {
                DialogResult result = FlatMsgBox.Show("Bạn có chắc muốn xóa nhóm này này ?", "Cảnh báo", FlatMsgBox.Buttons.YesNo);
                if (result == DialogResult.Yes)
                {
                    TmTech_v1.Model.Category cate = null;

                    int selectedrow = metroGrid1.CurrentCell.RowIndex;
                    //if (selectedrow == 0) return;
                    cate = (TmTech_v1.Model.Category)metroGrid1.Rows[selectedrow].DataBoundItem as TmTech_v1.Model.Category;
                    if (cate == null) return;
                    bool ok = Database.DeleteById<TmTech_v1.Model.Category>("delete Category where Id = " + cate.Id);
                    if (ok == false)
                    {
                        FlatMsgBox.Show("Không thể xóa");
                        return;
                    }
                    metroGrid1.Rows.Remove(metroGrid1.Rows[selectedrow]);
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

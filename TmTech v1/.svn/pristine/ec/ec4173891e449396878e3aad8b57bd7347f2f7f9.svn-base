using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TmTech_v1.Repository;
using TmTech_v1.Interface;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmProduct : UserControl
    {
        public frmProduct()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public void LoadData(bool x)
        {
            ProductUtility ProductUtility = new ProductUtility(treeView1);
            List<Model.Category> lstCate = ProductUtility.GetAllRoot();
            ProductUtility.BuidRoot(lstCate);
        }
        public void LoadGrid(int cateId)
        {
            if (cateId <=0) return;
            IList<Model.Product> lstProduct;
            using(IUnitOfWork uow = new UnitOfWork())
            {
                lstProduct = uow.ProductRepository.FindByParentCategory(cateId);
                uow.Commit();
            }
            if(lstProduct!=null)
            {
                GridUtility.BindingData<Model.Product>(gridControl1, lstProduct);
            }
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            //LoadData();
            ComboboxUtility.BindCategory(cbbCategory);
            cbbCategory.SelectedValue = -1;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            if (node != null)
            {
                LoadGrid(int.Parse(node.Tag.ToString()));
            }
        }
        protected override Point ScrollToControl(Control activeControl)
        {
            return this.AutoScrollPosition;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            GridUtility.SetRowColor(gridView1);
            int i = gridView1.GetSelectedRows().First();
            Model.Product product = gridView1.GetRow(i) as Model.Product;
            if(product!=null)
            {
                using(IUnitOfWork uow = new UnitOfWork())
                {
                    product = uow.ProductRepository.Find(product.Id);
                    uow.Commit();
                }
                BindDataToTextBox(product);
            }
        }
        private void BindDataToTextBox(Model.Product product)
        {
            txtCode.Text = product.Code;
            txtName.Text = product.Name;
            cbbCategory.SelectedValue = product.CategoryId;
            //txtVolt.Text = product.InputVoltage.ToString();
            //txtWatt.Text = product.Watt.ToString();
            //txtLed.Text = product.Led;
            
        }

        private void bootstrapButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

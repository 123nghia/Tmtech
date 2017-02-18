using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Repository;

namespace TmTech_v1.View
{
    public class ProductUtility
    {
        TreeView m_Tree;
        public ProductUtility(TreeView tree)
        {
            m_Tree = tree;
        }
        public static List<Model.Category> GetAllRoot()
        {
            List<Model.Category> lstCategory;
            using(IUnitOfWork uow = new UnitOfWork())
            {
                lstCategory = uow.CategoryRepository.AllRootCategory();
                uow.Commit();
            }
            return lstCategory;
        }
        public static List<Model.Category> GetSubCategory(int parentId)
        {
            List<Model.Category> lstCategory;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstCategory = uow.CategoryRepository.FindByParentId(parentId);
                uow.Commit();
            }
            return lstCategory;
        }
        public void BuidTree(TreeNode root,List<Model.Category> lstCategory)
        {
            if (lstCategory == null) return;
            foreach (Model.Category cate in lstCategory)
            {
                TreeNode node = new TreeNode(cate.Name);
                node.Tag = cate.Id;

                List<Model.Category> lstSubCate = GetSubCategory(cate.Id);
                BuidTree(node, lstSubCate);
                root.Nodes.Add(node);
            }
        }
        public void BuidRoot(List<Model.Category> lstCategory)
        {
            if (lstCategory == null) return;
            foreach (Model.Category cate in lstCategory)
            {
                TreeNode node = new TreeNode(cate.Name);
                node.Tag = cate.Id;
                List<Model.Category> lstSubCate = GetSubCategory(cate.Id);
                BuidTree(node, lstSubCate);
                m_Tree.Nodes.Add(node);
            }
        }
    }
}

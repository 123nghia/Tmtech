using ModernUI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmTech_v1.Interface;
using TmTech_v1.Repository;

namespace TmTech_v1.Utility
{
    public static class ComboboxUtility
    {
        public static void BindData<T>(MetroSearchComboBox combobox, List<T> lstSoucre, string displayMember, string valueMember) where T : class
        {
            if (string.IsNullOrEmpty(displayMember) || string.IsNullOrWhiteSpace(displayMember)) return;
            combobox.DataSource = null;
            combobox.DataSource = lstSoucre;
            combobox.DisplayMember = displayMember;
            combobox.ValueMember = valueMember;
        }
        public static void BindData<T>(MetroComboBox combobox, List<T> lstSoucre, string displayMember, string valueMember) where T : class
        {
            if (string.IsNullOrEmpty(displayMember) || string.IsNullOrWhiteSpace(displayMember)) return;
            combobox.DataSource = null;
            combobox.DataSource = lstSoucre;
            combobox.DisplayMember = displayMember;
            combobox.ValueMember = valueMember;
        }
        public static void BindCategory(MetroComboBox combox)
        {
            IList<Model.Category> lstCate;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstCate = uow.CategoryRepository.All();
                uow.Commit();
            }
            if(lstCate!=null)
            {
                combox.DataSource = null;
                combox.DataSource = lstCate;
                combox.DisplayMember = "Name";
                combox.ValueMember = "Id";
            }
        }
    }
}

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using ModernUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmTech_v1.Utility
{
    public static class GridUtility
    {
        public static void BindingData<T>(MetroGrid grid, IList<T> lstSource) where T : class
        {
            BindingList<T> bi = new BindingList<T>(lstSource);
            grid.DataSource = null;
            grid.DataSource = bi;
        }
        //devexpress
        public static void BindingData<T>(GridControl grid, IList<T> lstSource) where T : class
        {
            BindingList<T> bi = new BindingList<T>(lstSource);
            grid.DataSource = null;
            grid.DataSource = bi;
        }
        public static void SetRowColor(GridView gridView1, string htmlColor = "#45CAEA")
        {
            gridView1.Appearance.SelectedRow.BackColor = ColorTranslator.FromHtml(htmlColor);
            gridView1.Appearance.FocusedCell.BackColor = ColorTranslator.FromHtml(htmlColor);
            gridView1.Appearance.FocusedRow.BackColor = ColorTranslator.FromHtml(htmlColor);
            gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            gridView1.Appearance.SelectedRow.ForeColor = Color.White;
            gridView1.Appearance.FocusedRow.ForeColor = Color.White;
            gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
        }
    }
}

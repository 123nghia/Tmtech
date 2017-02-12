using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModernUI.Forms;
using Dapper;
namespace Generate_Insert_Script
{
    public partial class frmPrimary : MetroForm
    {
        IDbConnection db = Connection.DbCon;
        public ConnectionInfo conInfo  {get;set;}
        string queryTable;
        string queryColumn;
        bool includePrimaryKey = false;
        public frmPrimary()
        {
            InitializeComponent();
            queryTable = string.Empty;
            queryColumn = string.Empty;
        }

        private void frmPrimary_Load(object sender, EventArgs e)
        {
            LoadTable(conInfo.DatabaseName);
        }
        public void LoadTable(string dbName)
        {
            if (string.IsNullOrEmpty(dbName) == true) return;
            else
            {
                queryTable = "USE " + conInfo.DatabaseName + " SELECT Name FROM sys.Tables";
                List<Table> lstTable = new List<Table>();
                lstTable = db.Query<Table>(queryTable).ToList();
                if (lstTable != null)
                {
                    cbbTable.DataSource = null;
                    cbbTable.DataSource = lstTable;
                    cbbTable.DisplayMember = "Name";
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cbbTable.SelectedItem == null) return;
            string tablename = ((Table)cbbTable.SelectedItem).Name;
            string insert = "insert into " + tablename + "(";
            string clause1, clause2;
            clause1 = clause2 = string.Empty;
            if (tablename != string.Empty)
            {
                queryColumn ="SELECT COLUMN_NAME as Name, DATA_TYPE as DataType FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + ((Table)cbbTable.SelectedItem).Name +"'";
                List<Column> lstColumn = new List<Column>();
                lstColumn = db.Query<Column>(queryColumn).ToList();
                if (lstColumn == null) return;
                string getPrimaryKey = string.Format(@"SELECT kcu.COLUMN_NAME as Name,colType.DATA_TYPE as Datatype
                                                        FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS tc INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS kcu
                                                        ON kcu.CONSTRAINT_NAME = tc.CONSTRAINT_NAME inner join (	 SELECT COLUMN_NAME, DATA_TYPE 
                                                        FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{0}') colType on kcu.COLUMN_NAME = colType.COLUMN_NAME
                                                        WHERE tc.CONSTRAINT_TYPE = 'PRIMARY KEY'
                                                        AND tc.TABLE_NAME = '{1}'", tablename, tablename);
                Column primaryCol = db.Query<Column>(getPrimaryKey).FirstOrDefault();
                if (primaryCol != null)
                {
                    Column col = lstColumn.Find(p => p.Name == primaryCol.Name && p.Datatype == primaryCol.Datatype);
                    if (col != null)
                        lstColumn.Single(p => p.Name == primaryCol.Name && p.Datatype == primaryCol.Datatype).IsPrimary = true;
                }

                bool first = true;
                foreach (Column column in lstColumn)
                {
                    if (first == true)
                    {
                        if ((column.IsPrimary == true && column.Datatype!="int")|| column.IsPrimary==false)
                        {
                            clause1 += column.Name;
                            clause2 += "@" + column.Name;
                            first = false;
                        }
                    }
                    else
                    {
                        if ((column.IsPrimary == true && column.Datatype != "int") || column.IsPrimary == false)
                        {
                            clause1 += "," + column.Name;
                            clause2 += ",@" + column.Name;
                        }
                    }
                }
                txtScript.Text = insert + clause1 + ") values (" + clause2 + ")";
                txtScript.Select();
                Clipboard.SetText(txtScript.Text);
            }
        }
        private void bootstrapButton1_Click(object sender, EventArgs e)
        {
            if (cbbTable.SelectedItem == null) return;
            string tablename = ((Table)cbbTable.SelectedItem).Name;
            string insert = "update  " + tablename + " set ";
            string clause1, clause2;
            clause1 = clause2 = string.Empty;
            if (tablename != string.Empty)
            {
                queryColumn = "SELECT COLUMN_NAME as Name, DATA_TYPE as DataType FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + ((Table)cbbTable.SelectedItem).Name + "'";
                List<Column> lstColumn = new List<Column>();
                lstColumn = db.Query<Column>(queryColumn).ToList();
                if (lstColumn == null) return;
                string getPrimaryKey = string.Format(@"SELECT kcu.COLUMN_NAME as Name,colType.DATA_TYPE as Datatype
                                                        FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS tc INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS kcu
                                                        ON kcu.CONSTRAINT_NAME = tc.CONSTRAINT_NAME inner join (	 SELECT COLUMN_NAME, DATA_TYPE 
                                                        FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{0}') colType on kcu.COLUMN_NAME = colType.COLUMN_NAME
                                                        WHERE tc.CONSTRAINT_TYPE = 'PRIMARY KEY'
                                                        AND tc.TABLE_NAME = '{1}'", tablename, tablename);
                Column primaryCol = db.Query<Column>(getPrimaryKey).FirstOrDefault();
                if (primaryCol != null)
                {
                    Column col = lstColumn.Find(p => p.Name == primaryCol.Name && p.Datatype == primaryCol.Datatype);
                    if (col != null)
                        lstColumn.Single(p => p.Name == primaryCol.Name && p.Datatype == primaryCol.Datatype).IsPrimary = true;
                }

                bool first = true;
                foreach (Column column in lstColumn)
                {
                    if (first == true)
                    {
                        if ((column.IsPrimary == true && column.Datatype != "int") || column.IsPrimary == false)
                        {
                            clause1 += column.Name + "= @" +column.Name;
                            first = false;
                        }
                    }
                    else
                    {
                        if ((column.IsPrimary == true && column.Datatype != "int") || column.IsPrimary == false)
                        {
                            clause1 += "," + column.Name + "= @" + column.Name;
                        }
                    }
                }
                txtScript.Text = insert + clause1 + " where ";
                txtScript.Select();
                Clipboard.SetText(txtScript.Text);
            }
        }
        private void btnSetupDb_Click(object sender, EventArgs e)
        {
            frmConnect frmconnect = UtilityFunction.FindForm("frmConnect") as frmConnect;
            if (frmconnect != null)
            {
                frmconnect.Show();
            }
        }

        private void frmPrimary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

    }



    public class Table
    {
        public string Name { get; set; }
    }
    public class Column
    {
        public string Name { get; set; }
        public string Datatype { get; set; }
        public bool IsPrimary{get;set;}
        public Column()
        {
            Name = Datatype = string.Empty;
            IsPrimary = false;
        }
    }
}

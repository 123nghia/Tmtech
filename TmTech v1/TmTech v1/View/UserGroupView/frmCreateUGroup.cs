
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
using Dapper;
using TmTech_v1.Model;
using ModernUI.Forms;
namespace TmTech_v1.View
{
    public partial class frmCreateUGroup : MetroForm
    {
        IDbConnection db = DbTmTech.DbCon;
        List<TableName> lstObjectPermission;
        CheckBox HeaderCheckBox = null;
        List<Permissions> m_lstPermissions = null;
        UserGroup m_uGroup = null;
        public frmCreateUGroup()
        {
            InitializeComponent();
            lstObjectPermission = new List<TableName>();
        }
        public frmCreateUGroup(UserGroup uGroup)
        {
            InitializeComponent();
            m_uGroup = uGroup;
            
            lstObjectPermission = new List<TableName>();
        }
        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();

            HeaderCheckBox.Size = new Size(15, 15);

            //Add the CheckBox into the DataGridView
            this.metroGrid1.Controls.Add(HeaderCheckBox);
        }
        private void frmCreate_Load(object sender, EventArgs e)
        {
            //AddHeaderCheckBox();
            List<Permissions> lstPermission = new List<Permissions>();
            List<ObjectPermission> lstObjectPermission = new List<ObjectPermission>();
            string select = @"SELECT rank() over(order by Id desc) as Stt,* from ObjectPermission";
            lstObjectPermission = db.Query<ObjectPermission>(select).ToList();
            if (lstObjectPermission != null)
            {
                int i = 0;
                foreach (ObjectPermission table in lstObjectPermission)
                {
                    Permissions permission = new Permissions();
                    permission.Stt = ++i;
                    permission.ObjectPermission = new ObjectPermission();
                    permission.ObjectPermission.TableName = table.TableName;
                    permission.ObjectPermissionId = table.Id;
                    permission.ViewAll = false;
                    permission.ViewOwn = false;
                    permission.Create = false;
                    permission.Edit = false;
                    permission.Delete = false;
                    lstPermission.Add(permission);
                }
            }
            if (m_uGroup == null)
            {
                metroGrid1.DataSource = null;
                metroGrid1.DataSource = lstPermission;
            }

            else
            {
                txtName.Text = m_uGroup.GroupName;
                txtNote.Text = m_uGroup.Note;
                m_lstPermissions = new List<Permissions>();
                //                    string select = @"select p.Id,p.Name,P.ViewOwn,p.ViewAll,p.Edit,p.[Create],p.[Delete]
                //                                        from Permissions p inner join ObjectPermission op on p.ObjectPermissionId = op.Id
                //                                         inner join UserGroup ug on p.UserGroupId = ug.Id where p.UserGroupId=" + m_uGroup.Id;
                string selectExist = @"select p.Id as Id,p.Name as Name,p.ViewOwn as ViewOwn,p.ViewAll as ViewAll,p.Edit,p.[Create] as [Create],p.[Delete] as [Delete],op.TableName,ug.GroupName
                                        from Permissions p inner join ObjectPermission op on p.ObjectPermissionId = op.Id inner join UserGroup ug on p.UserGroupId = ug.Id where  p.UserGroupId=" + m_uGroup.Id;
                m_lstPermissions = db.Query<Permissions, ObjectPermission, UserGroup, Permissions>(selectExist, (p, op, u) => { p.ObjectPermission = op; p.UserGroup = u; return p; }, splitOn: "TableName,GroupName").ToList();
                
                foreach (Permissions permision in lstPermission)
                {
                    foreach(Permissions existPermisison in m_lstPermissions)
                    {
                        if(permision.ObjectPermission.TableName==existPermisison.ObjectPermission.TableName)
                        {
                            permision.Id = existPermisison.Id;
                            permision.ViewOwn = existPermisison.ViewOwn;
                            permision.ViewAll = existPermisison.ViewAll;
                            permision.Create = existPermisison.Create;
                            permision.Edit = existPermisison.Edit;
                            permision.Delete = existPermisison.Delete;
                            permision.UserGroupId = existPermisison.UserGroupId;
                            permision.ObjectPermissionId = existPermisison.ObjectPermissionId;
                        }
                    }
                }
                metroGrid1.DataSource = null;
                metroGrid1.DataSource = lstPermission;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                FlatMessageBox.FlatMsgBox.Show("Bạn chưa nhập tên");
                return;
            }
            if (m_uGroup == null)
            {
                UserGroup ugroup = new UserGroup();
                ugroup.GroupName = txtName.Text;
                ugroup.Note = txtNote.Text;
                ugroup.CreateBy = UserManagement.UserSession.Id;
                ugroup.CreateDate = DateTime.Now;
                int result = CreateUGroup(ugroup);
                if (result > 0)
                {
                    List<Permissions> lstPermission = new List<Permissions>();
                    for (int i = 0; i < metroGrid1.RowCount; i++)
                    {
                        Permissions permission = metroGrid1.Rows[i].DataBoundItem as Permissions;
                        if (permission != null)
                        {
                            if (permission.ViewOwn == true || permission.ViewAll == true || permission.Create == true || permission.Edit == true || permission.Delete == true)
                            {
                                permission.UserGroupId = result;
                                permission.CreateBy = UserManagement.UserSession.Id;
                                permission.CreateDate = DateTime.Now;
                                lstPermission.Add(permission);
                            }
                        }
                    }
                    createPermission(lstPermission);
                }
            }
            else
            {
                List<Permissions> lstPermission = new List<Permissions>();
                 for (int i = 0; i < metroGrid1.RowCount; i++)
                    {
                        Permissions permission = metroGrid1.Rows[i].DataBoundItem as Permissions;
                        if (permission != null)
                        {
                            if (permission.ViewOwn == true || permission.ViewAll == true || permission.Create == true || permission.Edit == true || permission.Delete == true)
                            {
                                permission.UserGroupId = m_uGroup.Id;
                                permission.CreateBy = UserManagement.UserSession.Id;
                                permission.CreateDate = DateTime.Now;
                                lstPermission.Add(permission);
                            }
                        }
                    }
                 EditPermission(lstPermission);
            }
        }
        private int CreateUGroup(UserGroup uGroup)
        {
            if (uGroup == null)
                return 0;
            string insert = string.Format("insert into UserGroup(Name,Note,CreateDate,CreateBy,ModifyDate,ModifyBy) values(@Name,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy);SELECT Scope_Identity();");
            try
            {
                var result = db.ExecuteScalar(insert, uGroup);
                return int.Parse(result.ToString());
            }
            catch
            {
                return 0;
            }
        }
        private void createPermission(List<Permissions> lstPermission)
        {
            if (lstPermission == null)
                return;
            string insert = string.Format("insert into Permissions(Name,ViewOwn,ViewAll,[Create],Edit,[Delete],UserGroupId,ObjectPermissionId,Note,CreateDate,CreateBy,ModifyDate,ModifyBy) values(@Name,@ViewOwn,@ViewAll,@Create,@Edit,@Delete,@UserGroupId,@ObjectPermissionId,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            try
            {
                foreach(Permissions permission in lstPermission)
                {
                    db.Execute(insert, permission);
                }
            }
            catch
            {

            }
        }
        private void EditPermission(List<Permissions> lstPermission)
        {
            if (lstPermission == null)
                return;
            foreach (Permissions permission in lstPermission)
            {
                if (permission.Id > 0)
                {
                    string update = string.Format(@"update Permissions set ViewOwn ='{0}',ViewAll='{1}',[Create] ='{2}',Edit='{3}',[Delete]='{4}' where Id= {5}",
                                                        permission.ViewOwn == null ? false : permission.ViewOwn, 
                                                        permission.ViewAll == null ? false : permission.ViewAll, 
                                                        permission.Create==null?false:permission.Create,
                                                        permission.Edit == null ? false : permission.Edit,
                                                        permission.Delete == null ? false : permission.Delete, permission.Id);
                    try
                    {
                        db.Execute(update);
                    }
                    catch
                    {
                        FlatMessageBox.FlatMsgBox.Show("Error on update");
                    }
                }
                else
                {
                    string insert = string.Format("insert into Permissions(Name,ViewOwn,ViewAll,[Create],Edit,[Delete],UserGroupId,ObjectPermissionId,Note,CreateDate,CreateBy,ModifyDate,ModifyBy) values(@Name,@ViewOwn,@ViewAll,@Create,@Edit,@Delete,@UserGroupId,@ObjectPermissionId,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
                    try
                    {
                        db.Execute(insert, permission);
                    }
                    catch
                    {
                        FlatMessageBox.FlatMsgBox.Show("Error on insert");
                    }
                }

            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

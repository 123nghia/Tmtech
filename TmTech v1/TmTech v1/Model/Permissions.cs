using System;

namespace TmTech_v1.Model
{
    public class Permissions
    {
        public int Stt { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? ViewOwn { get; set; }
        public bool? ViewAll { get; set; }
        public bool? Create { get; set; }
        public bool? Edit { get; set; }
        public bool? Delete { get; set; }
        public int? UserGroupId { get; set; }
        public int? ObjectPermissionId { get; set; }
        public string Note { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifyBy { get; set; }
        public virtual ObjectPermission ObjectPermission {get;set;}
        public virtual UserGroup UserGroup { get; set; }
    }
    public class CustomPermission : Permissions
    {
        public string TableName { get; set; }
        public string ObjectName { get; set; }
    }
}

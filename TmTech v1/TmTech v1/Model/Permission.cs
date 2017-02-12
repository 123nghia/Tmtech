using System;

namespace TmTech_v1.Model
{
    public class Permission
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? ViewOwn { get; set; }
        public bool? ViewAll { get; set; }
        public bool? Create { get; set; }
        public bool? Update { get; set; }
        public bool? Delete { get; set; }
        public int? UserId { get; set; }
        public int? ObjectPermissionId { get; set; }
        public string Note { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }

        public virtual ObjectPermission ObjectPermission { get; set; }

    }
    
}
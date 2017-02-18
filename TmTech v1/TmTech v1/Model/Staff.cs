using System;

namespace TmTech_v1.Model
{
    public class Staff
    {
        public int Stt { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public Boolean Sex { get; set; }
        public string Name { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string Address { get; set; }
        public DateTime? Birthday { get; set; }
        public int? DepartmentId { get; set; }
        public int? PositionId { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public int CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int ModifyBy { get; set; }
        public virtual Department Department { get; set; }
        public virtual Users User { get; set; }
        public virtual StaffPosition StaffPosition { get; set; }
    }
}

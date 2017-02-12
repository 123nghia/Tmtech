
using System;

namespace TmTech_v1.Model
{
    public class Company
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Taxcode { get; set; }
        public string SwiftCode { get; set; }
        public int? Employee { get; set; }
        public double? DebitValue { get; set; }
        public int? ParentCompanyId { get; set; }
        public int? Branch { get; set; }
        public int? TagetValue { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public int? StaffId { get; set; }
        public string Note { get; set; }
        public int? TypeId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifyBy { get; set; }
        public int? NoBrank { get; set; }
        public int? NoStaff { get; set; }
           
    }
}

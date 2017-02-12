using System;

namespace TmTech_v1.Model
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int? CompanyId { get; set; }
        public string AccountBankNo { get; set; }
        public string AccountName { get; set; }
        public int? Type { get; set; }
        public string Note { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}

using System;

namespace TmTech_v1.Model
{
    public class Payment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? POId { get; set; }
        public int? CusId { get; set; }
        public double? Paid { get; set; }
        public int? StaffId { get; set; }
        public DateTime? PaidDate { get; set; }
        public int? PaymentMethodId { get; set; }
        public string Note { get; set; }
        public int? BankId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}

using System;

namespace TmTech_v1.Model
{
    public class QuotationDetail
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? QuotationId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public int? StandardId { get; set; }
        public string Price { get; set; }
        public double? Discount { get; set; }
        public string Note { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}

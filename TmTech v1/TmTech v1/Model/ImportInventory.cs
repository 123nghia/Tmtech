using System;

namespace TmTech_v1.Model
{
    public class ImportInventory
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? InventoryId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public string Note { get; set; }
    }
}

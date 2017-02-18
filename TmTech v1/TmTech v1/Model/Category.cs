using System;

namespace TmTech_v1.Model
{
    public class Category
    {
        public int Stt { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string Note { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifyBy { get; set; }
        public virtual Users User { get; set; }
    }
}
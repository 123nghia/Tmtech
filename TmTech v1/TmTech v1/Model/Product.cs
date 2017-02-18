using System;

namespace TmTech_v1.Model
{
    public class Product
    {
        public int Stt { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public double? Watt { get; set; }
        public double? InputVoltage { get; set; }
        public double? Long { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
        public double? IP { get; set; }
        public double Dimension { get; set; }
        public int? ColorId { get; set; }
        public string ClassId { get; set; }
        public double? Temperature { get; set; }
        public double? CRI { get; set; }
        public double? Angle { get; set; }
        public double? Head { get; set; }
        public string DataSheet { get; set; }
        public string InstallGuide { get; set; }
        public string ThreeD { get; set; }
        public double? InVoltage { get; set; }
        public double? Dim { get; set; }
        public string Led { get; set; }
        public string Control { get; set; }
        public string Finishing { get; set; }
        public string IPRate { get; set; }
        public double? IKRate { get; set; }
        public string ClassSafety { get; set; }
        public string ENEC { get; set; }
        public string Standard { get; set; }
        public string PhotoMeter { get; set; }
        public string Note { get; set; }
        public DateTime? CreateDate { get; set; }
        public int CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int ModifyBy { get; set; }
        public virtual SystemColor Color { get; set; }
        public virtual Users User { get; set; }
        public virtual Category Category { get; set; }
    }
}
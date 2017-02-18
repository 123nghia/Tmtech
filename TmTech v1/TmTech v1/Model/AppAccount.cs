using System;
namespace TmTech_v1.Model
{
    public class AppAccount
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RecoverEmail { get; set; }
        public int? UserId { get; set; }
        public int? UserTypeId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifyBy { get; set; }
        public virtual Staff Staff {get;set;}
        public virtual Company Company { get; set; }
    }
    public class CustomAccount : AppAccount
    {
        public int Stt { get; set; }
        public string Name { get; set; }
        public string UserType { get; set; }
        public string ModifyName { get; set; }
        public string CreateName { get; set; }
    }
}

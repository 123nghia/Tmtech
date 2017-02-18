using System;
using System.Data;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using Dapper;
using System.Collections.Generic;
using System.Linq;
namespace TmTech_v1.Repository
{
    public class CompanyRepository : RepositoryBase,ICompanyRepository
    {
        public CompanyRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Company entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format("insert into Company(Code,Name,Address,Phone1,Phone2,Fax,Taxcode,SwiftCode,Employee,DebitValue,ParentCompanyId,Branch,TagetValue,Website,Email,StaffId,Note,TypeId,CreateDate,CreateBy,ModifyDate,ModifyBy,NoBrank,NoStaff) values (@Code,@Name,@Address,@Phone1,@Phone2,@Fax,@Taxcode,@SwiftCode,@Employee,@DebitValue,@ParentCompanyId,@Branch,@TagetValue,@Website,@Email,@StaffId,@Note,@TypeId,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy,@NoBrank,@NoStaff");
            Connection.Execute(insert, entity, Transaction);
        }

        public List<Model.Company> All()
        {
            return Connection.Query<Model.Company>("Select * from Company", transaction: Transaction).ToList();
        }

        public Model.Company Find(int id)
        {
            return Connection.Query<Model.Company>("select  * from  Company where  Id = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("DELETE FROM Company WHERE Id = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.Company entity)
        {
            if (entity == null)
           
                throw new ArgumentNullException("entity");
               

        }

        public void Update(Model.Company entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"update  Company 
                                            set Code= @Code,Name= @Name,Address= @Address,Phone1= @Phone1,Phone2= @Phone2,Fax= @Fax,Taxcode= @Taxcode,SwiftCode= @SwiftCode,Employee= @Employee,DebitValue= @DebitValue,ParentCompanyId= @ParentCompanyId,Branch= @Branch,TagetValue= @TagetValue,Website= @Website,Email= @Email,StaffId= @StaffId,Note= @Note,TypeId= @TypeId,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy,NoBrank= @NoBrank,NoStaff= @NoStaff where  
                                             Id = @Id");
            Connection.Execute(update, entity, transaction: Transaction);
        }


    }
}

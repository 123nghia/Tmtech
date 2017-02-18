﻿using System;
using System.Data;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using Dapper;
using System.Collections.Generic;
using System.Linq;
namespace TmTech_v1.Repository
{
    public class DeputyRepository: RepositoryBase, IDeputyRepository
    {
        public DeputyRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Deputy entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into Deputy(Name,CompanyId,Address,Phone1,Phone2,Birthday,Fax,Skype,Email,Note,StaffId,UserId,CreateDate,CreateBy,ModifyDate,ModifyBy)
                                           values (@Name,@CompanyId,@Address,@Phone1,@Phone2,@Birthday,@Fax,@Skype,@Email,@Note,@StaffId,@UserId,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            Connection.Execute(insert, entity, Transaction);
        }

        public List<Model.Deputy> All()
        {
            return Connection.Query<Model.Deputy>("Select * from Deputy", transaction: Transaction).ToList();
        }

        public Model.Deputy Find(int id)
        {
            return Connection.Query<Model.Deputy>("select  * from  Deputy where  Id = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("DELETE FROM Deputy WHERE Id = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.Deputy entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

         
        }

        public void Update(Model.Deputy entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"updateupdate  Deputy set Name= @Name,CompanyId= @CompanyId,Address= @Address,Phone1= @Phone1,Phone2= @Phone2,Birthday= @Birthday,Fax= @Fax,Skype= @Skype,Email= @Email,Note= @Note,StaffId= @StaffId,UserId= @UserId,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy where  Id = @Id");
            Connection.Execute(update, entity, transaction: Transaction);
        }


    }
}

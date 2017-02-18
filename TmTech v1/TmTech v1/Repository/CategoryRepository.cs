using System;
using System.Data;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using Dapper;
using System.Collections.Generic;
using System.Linq;
namespace TmTech_v1.Repository
{
    public class CategoryRepository:RepositoryBase,ICategoryRepository
    {
        public CategoryRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Category entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into Category(Name,ParentId,Note,CreateDate,CreateBy,ModifyDate,ModifyBy)
                                            values (@Name,@ParentId,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            Connection.Execute(insert,entity,Transaction);
        }

        public List<Model.Category> All()
        {
            return Connection.Query<Model.Category>("Select * from Category", transaction: Transaction).ToList();
        }

        public Model.Category Find(int id)
        {
            return Connection.Query<Model.Category>("Select * from Category where Id = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("DELETE FROM Category WHERE Id = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.Category entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.Id);
        }

        public void Update(Model.Category entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"update  Category set Name= @Name,ParentId= @ParentId,Note= @Note,CreateDate= @CreateDate
                                            ,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy where  Id = @Id");
            Connection.Execute(update,entity,transaction: Transaction);
        }




        public List<Category> AllRootCategory()
        {
            return Connection.Query<Model.Category>("select * from Category where ParentId is null or ParentId =''", transaction: Transaction).ToList();
        }

        public List<Category> FindByParentId(int rootId)
        {
            return Connection.Query<Model.Category>("select * from Category where ParentId = @Id", new { Id = rootId }, transaction: Transaction).ToList();
        }
    }
}

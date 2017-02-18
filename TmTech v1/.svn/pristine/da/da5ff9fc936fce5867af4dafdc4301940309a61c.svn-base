using System;
using System.Data;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using Dapper;
using System.Collections.Generic;
using System.Linq;
namespace TmTech_v1.Repository
{
    public class ProductRepository:RepositoryBase,IProductRepository
    {
        public ProductRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into Product(Code,Name,CategoryId,Watt,InputVoltage,Long,Height,Width
                                            ,IP,ColorId,ClassId,Temperature,CRI,Angle,Head,DataSheet,InstallGuide,ThreeD,InVoltage
                                            ,Dim,Led,Control,Finishing,IPRate,IKRate,ClassSafety,ENEC,Standard,PhotoMeter,Note,CreateDate,CreateBy,ModifyDate,ModifyBy)
                                            values (@Code,@Name,@CategoryId,@Watt,@InputVoltage,@Long,@Height,@Width,@IP,@ColorId,@ClassId,@Temperature,@CRI,@Angle
                                            ,@Head,@DataSheet,@InstallGuide,@ThreeD,@InVoltage,@Dim,@Led,@Control,@Finishing,@IPRate,@IKRate,@ClassSafety,@ENEC,@Standard
                                            ,@PhotoMeter,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            Connection.Execute(insert,entity,Transaction);
        }

        public List<Model.Product> All()
        {
            return Connection.Query<Model.Product>("Select * from Product",transaction:Transaction).ToList();
        }

        public Model.Product Find(int id)
        {
            return Connection.Query<Model.Product>("Select * from Product where Id = @Id", param: new { Id = id },transaction:Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("DELETE FROM Product WHERE Id = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.Id);
        }

        public void Update(Model.Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"update  Product set Code= @Code,Name= @Name,CategoryId= @CategoryId,Watt= @Watt,InputVoltage= @InputVoltage
                                            ,Long= @Long,Height= @Height,Width= @Width,IP= @IP,ColorId= @ColorId,ClassId= @ClassId,Temperature= @Temperature
                                            ,CRI= @CRI,Angle= @Angle,Head= @Head,DataSheet= @DataSheet,InstallGuide= @InstallGuide,ThreeD= @ThreeD,InVoltage= @InVoltage
                                            ,Dim= @Dim,Led= @Led,Control= @Control,Finishing= @Finishing,IPRate= @IPRate,IKRate= @IKRate,ClassSafety= @ClassSafety
                                            ,ENEC= @ENEC,Standard= @Standard,PhotoMeter= @PhotoMeter,Note= @Note,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate
                                            ,ModifyBy= @ModifyBy where Id = @Id");
            Connection.Execute(update,entity,transaction: Transaction);
        }


        //public List<Product> AllRootProduct()
        //{
        //    return Connection.Query<Model.Product>("select * from Category where ParentId is null or ParentId =''", transaction: Transaction).ToList();
        //}

        //public List<Product> FindProductByRootId(int rootId)
        //{
        //    return Connection.Query<Model.Product>("select * from Category where ParentId = @Id", new{Id = rootId }, transaction: Transaction).ToList();
        //}


        public List<Product> FindByCategory(int categoryId)
        {
            return Connection.Query<Model.Product>("Select * from Product where CategoryId = @Id", new {Id = categoryId }, transaction: Transaction).ToList();
        }


        public List<Product> FindByParentCategory(int categoryId)
        {
            return Connection.Query<Model.Product>("select * from Product where CategoryId in (select Id from Category where ParentId = @Id or Id = @Id)", new { Id = categoryId }, transaction: Transaction).ToList();
        }
    }
}

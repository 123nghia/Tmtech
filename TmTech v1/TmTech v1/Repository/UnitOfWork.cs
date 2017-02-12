using System;
using System.Data;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
namespace TmTech_v1.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private bool _disposed;
        IProductRepository _productRepository;
        ICategoryRepository _categoryRepository;
        IStaffRepository _StaffRepository;
        ICompanyRepository _CompanyRepository;
        public UnitOfWork()
        {
            _connection = DbTmTech.Create();
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }
        public IProductRepository ProductRepository
        {
            get { return _productRepository ?? (_productRepository = new ProductRepository(_transaction)); }
        }
        public ICategoryRepository CategoryRepository
        {
            get { return _categoryRepository ?? (_categoryRepository = new CategoryRepository(_transaction)); }
        }
        public IStaffRepository StaffRepository
        {
            get { return  _StaffRepository??( _StaffRepository = new StaffRepository(_transaction)); }
        }

        public ICompanyRepository StaffRepository
        {
            get { return _CompanyRepository ?? (_CompanyRepository = new CompanyRepository(_transaction)); }
        }
        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                resetRepositories();
            }
        }
        private void resetRepositories()
        {
            _productRepository = null;
            _categoryRepository = null;
        }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposed = true;
            }
        }

        ~UnitOfWork()
        {
            dispose(false);
        }
    }
}

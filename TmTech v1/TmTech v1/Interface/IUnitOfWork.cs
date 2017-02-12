using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmTech_v1.Interface
{
    public interface IUnitOfWork :IDisposable
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IStaffRepository StaffRepository { get;}

        void Commit();
    }
}

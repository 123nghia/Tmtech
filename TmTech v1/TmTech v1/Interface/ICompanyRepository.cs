using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface ICompanyRepository
    {
        void Add(Company entity);
        List<Company> All();
        Company Find(int id);
        void Remove(int id);
        void Remove(Company entity);
        void Update(Company entity);
    }
}

using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IDeputyRepository
    {
        void Add(Deputy entity);
        List<Deputy> All();
        Deputy Find(int id);
        void Remove(int id);
        void Remove(Deputy entity);
        void Update(Deputy entity);
    }
}

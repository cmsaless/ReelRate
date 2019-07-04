using ReelRate.Project.Models;
using ReelRate.Project.Models;
using System.Linq;

namespace ReelRate.Project.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(string ID);
        T Find(string ID);
        void Insert(T t);
        void Update(T t);
    }
}

using System.Linq;
using MyShop.Core.Models;

namespace MyShop.DataAccess.Core.Contracts
{
    public interface IRespository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(string Id);
        T Find(string Id);
        void Insert(T t);
        void Update(T t);
    }
}
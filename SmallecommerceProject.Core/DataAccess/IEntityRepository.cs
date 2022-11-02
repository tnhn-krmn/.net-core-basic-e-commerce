using SmallecommerceProject.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SmallecommerceProject.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class , IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
    }
}

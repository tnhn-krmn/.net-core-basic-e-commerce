using SmallecommerceProject.Core.DataAccess;
using SmallecommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallecommerceProject.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }

    
}

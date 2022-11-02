using SmallecommerceProject.Core.DataAccess.EntityFramework;
using SmallecommerceProject.DataAccess.Abstract;
using SmallecommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallecommerceProject.DataAccess.Concrete.EntityFrmework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}

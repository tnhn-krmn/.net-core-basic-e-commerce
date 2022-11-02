using SmallecommerceProject.Entities.Concrete;
using System.Collections.Generic;

namespace SmallecommerceProject.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }
        public int CurrentCategory { get; internal set; }
    }
}

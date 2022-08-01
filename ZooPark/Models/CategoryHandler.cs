using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    public class CategoryHandler
    {
        public CategoryHandler()
        {
            Categories = new List<Category>();
        }

        public List<Category> Categories { get; private set; }

        public void Add(Category category)
        {
            Categories.Add(category);
        }
    }
}
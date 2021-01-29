using _DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BusinessLayer
{
    public class ProductBusiness
    {
        NorthwindEntities db = new NorthwindEntities();

        public List<Category> Categories()
        {
            return db.Categories.ToList();
        }
    }
}

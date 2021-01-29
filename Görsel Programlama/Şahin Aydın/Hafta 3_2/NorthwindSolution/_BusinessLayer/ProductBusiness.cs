using _DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BusinessLayer
{
    public class ProductBusiness : DatabaseBusiness<Product>
    {
        NorthwindEntities db = new NorthwindEntities();
        public override void Create(Product t)
        {
            db.Products.Add(t);
            db.SaveChanges();
        }

        public override void Delete(int id)
        {
            Product p= db.Products.Find(id);
            db.Products.Remove(p);
            db.SaveChanges();
        }

        public override void Delete(Product t)
        {
            throw new NotImplementedException();
        }

        public override List<Product> List()
        {
            throw new NotImplementedException();
        }

        public override Product Read(int id)
        {
            return db.Products.Find(id);
        }

        public List<SP_ProdStockByCat_Result> ProductsStockByCategory()
        {
            return db.SP_ProdStockByCat().ToList();
        }


        public override void Update(Product t)
        {
            //Product p = db.Products.Find(t.ProductID);
            db.Products.Attach(t);
            db.Entry<Product>(t).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}

using _DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BusinessLayer
{
    public class CategoryBusiness : DatabaseBusiness<Category>
    {
        private NorthwindEntities db = new NorthwindEntities();

        public override void Create(Category t)
        {
            db.Categories.Add(t);
            db.SaveChanges();
        }

        public override void Delete(int id)
        {
            Category cat = db.Categories.Find(id);
            db.Categories.Remove(cat);
            db.SaveChanges();
        }

        public override void Delete(Category t)
        {
            db.Categories.Remove(t);
            db.SaveChanges();
        }

        public override List<Category> List()
        {
            return db.Categories.ToList();
        }

        public List<Category> ListForComboBox()
        {
            List<Category> list = db.Categories.ToList();
            list.Insert(0, new Category { CategoryID = 0, CategoryName = "Seçiniz..." });
            return list;
        }

        public override Category Read(int id)
        {
            return db.Categories.SingleOrDefault(c => c.CategoryID == id);
        }

        public override void Update(Category t)
        {
            db.Categories.Attach(t);
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}

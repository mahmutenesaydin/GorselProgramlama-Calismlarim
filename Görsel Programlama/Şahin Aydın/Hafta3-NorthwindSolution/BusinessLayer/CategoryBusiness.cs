using Hafta3_NorthwindSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryBusiness : DatabaseBusiness<Category>
    {
        private NorthwindEntities db = new NorthwindEntities();

        public override void Create(Category t)
        {
            db.Categories.Add(t);
            db.SaveChanges();
        }

        public override void Delete(int ID)
        {
            Category ctg = db.Categories.Find(ID);
            db.Categories.Remove(ctg);
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

        public override Category Read(int ID)
        {
            return db.Categories.SingleOrDefault(c => c.CategoryID == ID);
        }

        public override void Update(Category t)
        {
            db.Categories.Attach(t);
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}

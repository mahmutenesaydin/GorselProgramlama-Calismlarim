using _DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BusinessLayer
{
    public class SupplierBusiness : DatabaseBusiness<Supplier>
    {
        NorthwindEntities db = new NorthwindEntities();
        public override void Create(Supplier t)
        {
            db.Suppliers.Add(t);
            db.SaveChanges();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Supplier t)
        {
            throw new NotImplementedException();
        }

        public override List<Supplier> List()
        {
            return db.Suppliers.ToList();
        }

        public List<Supplier> ListForComboBox()
        {
            List<Supplier> list = db.Suppliers.ToList();
            list.Insert(0, new Supplier { SupplierID = 0, CompanyName = "Seçiniz..." });
            return list;
        }

        public override Supplier Read(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Supplier t)
        {
            throw new NotImplementedException();
        }
    }
}

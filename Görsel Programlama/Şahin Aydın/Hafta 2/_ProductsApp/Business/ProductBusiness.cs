using _ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ProductsApp.Business
{
    public class ProductBusiness : DatabaseBusiness, IDatabaseBusiness<Product>
    {
        Database database = new Database();
        DatabaseBusiness db = new DatabaseBusiness();
        public void Delete(Product data)
        {
            ExecuteCommand("SP_DeleteP", new SqlParameter[]
               {
                    new SqlParameter("@Id", data.Id)
               });
        }

        public Product GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Product data)
        {
            ExecuteCommand("SP_InsertP", new SqlParameter[]
                {
                    new SqlParameter("@Name", data.Name),
                    new SqlParameter("@Price", data.Price),
                    new SqlParameter("@CategoryId", data.CategoryId)
                });
        }

        public List<Product> List()
        {
            var products = new List<Product>();
            DataTable dt = db.ExecuteAdapter("SP_ListP");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                products.Add(new Product
                {
                    Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                    Name = dt.Rows[i]["Name"].ToString(),
                    Price = Convert.ToDecimal(dt.Rows[i]["Price"]),
                    CategoryId = Convert.ToInt32(dt.Rows[i]["CategoryId"])
                });
            }
            return products;
        }

        public void Update(Product data)
        {
            ExecuteCommand("SP_UpdateP", new SqlParameter[]
               {
                   new SqlParameter("@Id", data.Id),
                    new SqlParameter("@Name", data.Name),
                    new SqlParameter("@Price", data.Price),
                    new SqlParameter("@CategoryId", data.CategoryId)
               });
        }
    }
}

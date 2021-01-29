using _ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ProductsApp.Business
{
    public class CategoryBusiness : IDatabaseBusiness<Category>
    {

        Database _database = new Database();
        public void Delete(Category data)
        {
            throw new NotImplementedException();
        }

        public Category GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category data)
        {
            throw new NotImplementedException();
        }

        public List<Category> List()
        {
            var categories = new List<Category>();

            SqlCommand _command = new SqlCommand("SP_List", _database.OpenConnection());
            SqlDataReader _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                categories.Add(new Category
                {
                    Id = Convert.ToInt32(_reader["Id"]),
                    Name = _reader["Name"].ToString()
                });
            }
            _database.CloseConnection();
            categories.Insert(0, new Category
            {
                Name = "Seçiniz...",
                Id = 0
            });
            return categories;
        }

        public void Update(Category data)
        {
            throw new NotImplementedException();
        }
    }
}

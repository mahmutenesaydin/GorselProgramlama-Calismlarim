using _ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ProductsApp.Business
{
    public interface IDatabaseBusiness<T>
    {
        void Insert(T data);
        void Update(T data);
        void Delete(T data);
        List<T> List();
        T GetData(int id);
    }
}

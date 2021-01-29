using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            decimal b = 8.65m;
            var sonuc = a * b;
            Console.WriteLine(sonuc);
            Console.Read();
        }
    }
}

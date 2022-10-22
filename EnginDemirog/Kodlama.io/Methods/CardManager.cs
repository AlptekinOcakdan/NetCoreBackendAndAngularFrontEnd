using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class CardManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi : "+ product.Name);
        }

        public void Add2(string name,string description, double price)
        {
            Console.WriteLine("Sepete Eklendi : " + name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit_8
{
    internal class Product
    {
        public string Name { get; set; }

        public Product(string name)
        {
            Name = name;
        }

        // Метод приготовления, который будет переопределяться в подклассах
        public virtual string Cook()
        {
            return "Метод приготовить не определен для этого продукта.";
        }
    }
}

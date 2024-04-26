using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inherit_8
{
    internal class Vegetable : Product
    {
        public double Weight { get; set; }
        public int Calories { get; set; }

        public Vegetable(string name, double weight, int calories) : base(name)
        {
            Weight = weight;
            Calories = calories;
        }

        public override string Cook()
        {
            int portions = (int)(Weight / 200);
            return $"{portions} порций по 200 грамм, вес порций {Weight}, название {Name}";
        }
    }
}

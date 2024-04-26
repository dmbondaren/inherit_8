using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inherit_8
{
    internal class Fruit : Product
    {
        public double Volume { get; set; }
        public int Vitamins { get; set; }

        public Fruit(string name, double volume, int vitamins) : base(name)
        {
            Volume = volume;
            Vitamins = vitamins;
        }

        public override string Cook()
        {
            int portions = (int)(Vitamins / 100);
            return $"{portions} порций по 100 единиц витаминов, вес порций {Volume}, название {Name}";
        }
    }
}

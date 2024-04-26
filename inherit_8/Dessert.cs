using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inherit_8
{
    internal class Dessert : Product
    {
        public int Calories { get; set; }
        public int CocoaPercentage { get; set; }

        public Dessert(string name, int calories, int cocoaPercentage) : base(name)
        {
            Calories = calories;
            CocoaPercentage = cocoaPercentage;
        }

        public override string Cook()
        {
            double portionWeight = (CocoaPercentage < 60) ? 200 : 150;
            int portions = (int)(1000 / portionWeight);
            return $"{portions} порций по {portionWeight} грамм, название {Name}";
        }
    }
}

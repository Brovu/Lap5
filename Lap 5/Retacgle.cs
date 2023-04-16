using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_5
{
    public class Rectacgle : Shape, IPaint, IComparable<Rectacgle>
    {
        double l;
        double w;

        public Rectacgle(String name, double l, double w, double unitPrice): base(name)
        {
            this.l = l;
            this.w = w;
            this.unitPrice = unitPrice;
        }

        public double unitPrice { get; set;}

        public  double calculateArea()
        {
            return l*w;
        }

        public double calculateCost()
        {
            return calculateArea() * unitPrice;
        }

        public int CompareTo(Rectacgle s)
        {
            return calculateCost().CompareTo(s.calculateCost()) * -1;
        }

        public void xuat()
        {
            Console.WriteLine($"Name: {name}, Area: {calculateArea()}, Cost: {calculateCost()}");
        }

    }
}

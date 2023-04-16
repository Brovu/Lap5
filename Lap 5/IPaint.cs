using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_5
{
    public interface IPaint
    {
        double unitPrice { get; set; }
        double calculateCost();
    }
}

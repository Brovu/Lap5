using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_5
{
    public interface IHocPhi
    {
        double tuition { get; set; }
        double calculateDiscount();
    }
}

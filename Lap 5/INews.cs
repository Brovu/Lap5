using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_5
{
    public interface INews
    {
         String id { get; set; }
         String title { get; set; }

         String author { get; set; }

        void Display(ConsoleKeyInfo key);
    }
}

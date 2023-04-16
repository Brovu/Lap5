using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_5
{
    public class HocVien: IHocPhi, IComparable<HocVien>
    {
        public String id;
        String fullName;
        String birth;
        String type;
        private HocVien hv;

        public HocVien() { }
       
        public HocVien(String id, String fullName, String birth, String type, double tuition)
        {
            this.id = id;
            this.fullName = fullName;
            this.birth = birth;
            this.tuition = tuition;
            this.type = type;
        }

        public HocVien(HocVien hv)
        {
            this.hv = hv;
        }

        public double tuition { get; set; }

        public void input()
        {
            Console.Write("ID: ");
            id = Console.ReadLine();
            Console.Write("Student's name: ");
            fullName = Console.ReadLine();
            Console.Write("Birth: ");
            birth = Console.ReadLine();
            Console.Write("Tuition: ");
            tuition = double.Parse(Console.ReadLine());
            Console.Write("Doi tuong: ");
            type = Console.ReadLine();
        }

        public double calculateDiscount() {
            if(type == "ngheo")
            {
                return 100;
            }
            if (type == "can ngheo")
            {
                return 50;
            }
            else return 0;
        }

        public double calculateTuition()
        {
            return tuition - calculateDiscount();
        }

        public override string ToString()
        {
            return "ID: " + id + ", " + "Name: " + fullName + ", " + "Birth: " + birth +", " + "Tuition: " + calculateTuition() + ", " + "Doi tuong: " + type  ;
        }

        public int CompareTo(HocVien hv)
        {
            return calculateTuition().CompareTo(hv.calculateTuition()) * -1;
        }

    }
}

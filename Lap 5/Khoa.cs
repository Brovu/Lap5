using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_5
{
    public class Khoa
    {
        String courseName;
        int quanity;

        public Khoa() { }

        List<HocVien> listHV = new List<HocVien>();

        public void inputListStudent()
        {
            Console.WriteLine("\nNhap ten khoa: ");
            courseName = Console.ReadLine();
            Console.Write("So luong hoc vien: ");
            quanity = int.Parse(Console.ReadLine());
            for (int i = 0; i < quanity; i++)
            {
                Console.WriteLine("\nStudent number: " + (i + 1));
                HocVien hv = new HocVien();
                hv.input();
                listHV.Add(hv);
            }
        }

        
        public void outputListStudent()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("Course's name: " + courseName);

            listHV.Sort();
            Console.WriteLine("List Student after sorting: ");
            foreach (HocVien hv in listHV)
            {
                Console.WriteLine(hv);
            }

        }

        public void findStudent()
        {
            Console.Write("Nhap ma so can tim: ");
            String x = Console.ReadLine();
            Console.WriteLine("\nSinh vien co ma so {0} la: \n{1}", x, listHV.Find(find => find.id.Contains(x)));
        }

        public void insertStudent()
        {
            Console.WriteLine("Nhap vi tri can them: ");
            int pos = int.Parse(Console.ReadLine()) - 1;
            Console.Write("ID: ");
            String id = Console.ReadLine();
            Console.Write("Student's name: ");
            String fullName = Console.ReadLine();
            Console.Write("Birth: ");
            String birth = Console.ReadLine();
            Console.Write("Tuition: ");
            double tuition = double.Parse(Console.ReadLine());
            Console.Write("Doi tuong: ");
            String type = Console.ReadLine();
            HocVien hv2 = new HocVien(id, fullName, birth, type, tuition);

            listHV.Insert(pos, hv2);
            outputListStudent();
        }

        public void deleteStudent()
        {
            bool check = false;
            for (int i = 0; i < quanity; i++)
            {
                HocVien hv = listHV[i];
                if (hv.tuition == 0)
                {
                    listHV.RemoveAt(i);
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine("ko tim thay!");
            }
            else
            {
                Console.WriteLine("Da xoa");
                Console.WriteLine("\nDanh sach sau khi xoa thang deo chiu dong hoc phi:\n");
                foreach(HocVien hv in listHV)
                {
                    Console.Write(hv);
                }
            }
        }

    }
}

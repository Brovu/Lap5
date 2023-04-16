using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lap_5
{
    internal class Program
    {

        static void SinhVien()
        {
            SinhVien s1 = new SinhVien();
            s1.studentInput();
            s1.studentOutput();
        }

        static void Retacgle()
        {
            List<Rectacgle> rectangles = new List<Rectacgle>();
            Console.Write("Nhap so hinh cn: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("Nhap thong tin hinh chu nhat thu {0}:", i + 1);
             
                Console.Write("Nhap chieu dai: ");
                double l = double.Parse(Console.ReadLine());
                Console.Write("Nhap chieu rong: ");
                double w = double.Parse(Console.ReadLine());

                Rectacgle r = new Rectacgle("Hinh chu nhat", l, w, 3);
                rectangles.Add(r);

            }

            rectangles.Sort();
            Console.WriteLine("\nDanh sach theo chi phi ve giam dan:\n");
            foreach (Rectacgle r in rectangles)
            {
                r.xuat();
            }

            Console.WriteLine("Nhap dien tich x: ");
            double x = double.Parse(Console.ReadLine());
            bool check = false;
            for(int i = 0; i < n; i++)
            {
                Rectacgle r = rectangles[i];
                if(r.calculateArea() < x)
                {
                    rectangles.RemoveAt(i);
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
                Console.WriteLine("\nDanh sach sau khi xoa:\n");
                foreach (Rectacgle r in rectangles)
                {
                    r.xuat();
                }
            }

            Console.WriteLine("Nhap vi tri can them: ");
            int y = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Nhap chieu dai: ");
            double l2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            double w2 = double.Parse(Console.ReadLine());
            Rectacgle rec2 = new Rectacgle("Hinh chu nhat", l2, w2, 3);
            rectangles.Insert(y, rec2);

            Console.WriteLine("\n sau khi them:\n");
            foreach (Rectacgle r in rectangles)
            {
                r.xuat();
            }

            double total = 0;
            foreach(Rectacgle r in rectangles)
            {
                IPaint p = r;
                total += p.calculateCost();
            }
            Console.Write("\nTong chi phi: " + total);
        }

        static void Khoa()
        {
            Khoa k = new Khoa();
            k.inputListStudent();
            //k.outputListStudent();
            //k.findStudent();
            //k.insertStudent();
            k.deleteStudent();
        }

        static void ListNews()
        {
            ListNews l = new ListNews();
            l.Input();

            Console.WriteLine("==========================");
            Console.WriteLine("MENU");
            Console.WriteLine("1. Insert Menu");
            Console.WriteLine("2. View list news");
            Console.WriteLine("3. Average rate");
            Console.WriteLine("4. Exit");
            Console.WriteLine("==========================");

            ConsoleKeyInfo key = Console.ReadKey();

            switch(key.KeyChar)
            {
                case '1':
                    l.insert();
                    break;
                case '2':
                    l.Output(key);
                    break;
                case '3':
                    l.Output(key);
                    break;
                
                case '4':
                    Console.WriteLine("\nBan se thoat sau 3 giay");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    break;
            }
        }
        static void Main(string[] args)
        {
            //SinhVien();
            //Retacgle();
            //Khoa();
            ListNews();
            Console.ReadKey();
        }
    }
}

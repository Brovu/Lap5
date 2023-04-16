using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lap_5
{
    class SinhVien
    {
        String id { get; set; }
        String fullName { get; set; }

        List<MonHoc> dsMH = new List<MonHoc>();


        public SinhVien() { }

        public void subjectInput()
        {
            using (StreamReader sr = new StreamReader("D:\\MonHoc.txt"))
            {
                while (!sr.EndOfStream)
                {
                    // doc 1 dong`
                    string line = sr.ReadLine();

                    // tach cac gia tri thanh cac chuoi rieng
                    string[] values = line.Split(';');

                    MonHoc monHoc = new MonHoc();

                    monHoc.maMH = values[0];
                    monHoc.tenMH = values[1];
                    monHoc.sdvht = int.Parse(values[2]);
                    monHoc.tlkt = double.Parse(values[3]);
                    monHoc.dkt = double.Parse(values[4]);
                    monHoc.tlgk = double.Parse(values[5]);
                    monHoc.dgk = double.Parse(values[6]);
                    monHoc.diemThi = double.Parse(values[7]);

                    dsMH.Add(monHoc);
                }
            }
        }
        public void studentInput()
        {
            Console.Write("Ma so sv: ");
            id = Console.ReadLine();
            Console.Write("Ten SV: ");
            fullName = Console.ReadLine();
            Console.WriteLine("Nhap so luong mon hoc: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin mon hoc thu {0}", i + 1);
                MonHoc mh = new MonHoc();
                subjectInput();
                dsMH.Add(mh);
            }
        }

        public double diemTBHocKy()
        {
            double diemTong = 0;
            double Sdvht = 0;
            
            foreach (MonHoc mh in dsMH)
            {
                double diemTB = mh.diemTB();
                int dvht = mh.sdvht;
                diemTong += diemTB * dvht;
                Sdvht += dvht;
            }
            return diemTong / Sdvht;
        }

        public bool checkHocBong()
        {
            double dtb = diemTBHocKy();

            bool isHocBong = true;

            foreach (MonHoc mh in dsMH)
            {
                double diemTB = mh.diemTB();
                double diemThi = mh.diemThi;

                if (diemTB < 5.5 && diemThi < 5.5)
                {
                    isHocBong = false;
                    break;
                }
            }

            return dtb > 7.0 && isHocBong;
        }

        public void studentOutput()
        {
            Console.WriteLine($"Ma sinh vien: {id}");
            Console.WriteLine($"Ho ten sinh vien: {fullName}");
            Console.WriteLine($"Diem trung binh hoc ky: {diemTBHocKy()}");

            if (checkHocBong())
            {
                Console.WriteLine("Sinh vien duoc xem xet nhan hoc bong.");
            }
            else
            {
                Console.WriteLine("Sinh vien khong duoc xem xet nhan hoc bong.");
            }
        }
    }



}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lap_5
{
    class MonHoc
    {

        public String maMH;
        public String tenMH; 

        public int sdvht;

        public double tlkt;
        public double dkt;
        public double tlgk;
        public double dgk;
        public double diemThi;

        public MonHoc() { }

        public MonHoc(string maMH, string tenMH, int sdvht, double tlkt, double dkt, double tlgk, double dgk, double diemThi)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.sdvht = sdvht;
            this.tlkt = tlkt;
            this.dkt = dkt;
            this.tlgk = tlgk;
            this.dgk = dgk;
            this.diemThi = diemThi;
        }

   

        public double diemTB()
        {
            return tlkt * dkt + tlgk * dgk + (1 - tlkt - tlgk) * diemThi;
        }

        public void subjectOutput()
        {
            Console.WriteLine("\n Ten mon: {0}", tenMH);
            Console.WriteLine("Diem kiem tra: {0}", dkt);
            Console.WriteLine("Diem giua ki: {0}", dgk);
            Console.WriteLine("Diem Thi: {0}", diemThi);
            Console.WriteLine("Diem trung binh: {0}", diemTB());
        }

        public static double operator +(int s, MonHoc mh)
        {
            return mh.sdvht + s;
        }

        public static double operator +(MonHoc mh, int s)
        {
            return mh.diemTB() + s;
        }

    }
}

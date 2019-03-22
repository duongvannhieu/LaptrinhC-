using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class SinhVien
    {
        public String maSV;
        float toan;
        float ly;
        float hoa;
        //default constructors
        public SinhVien()
        {
            this.maSV = "01";
            this.toan = (float)7.5;
            this.ly = (float)8.5;
            this.hoa = (float)6.0;
        }
        //tham so hoa constructor
        public SinhVien(String maSV, float toan, float ly, float hoa)
        {
            this.maSV = maSV;
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
        }

        public void nhap()
        {
            Console.WriteLine("Nhap maSV:");
            this.maSV = Console.ReadLine();
            Console.WriteLine("Nhap diem toan:");
            this.toan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly:");
            this.ly = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa:");
            this.hoa = float.Parse(Console.ReadLine());
        }
        public float tinhdiemtb()
        {
            return (float)((this.toan + this.ly + this.hoa) / 3);
        }
        public void IN()
        {
            Console.WriteLine("sinh vien ma {0} co  diem trung binh la: {1}", this.maSV, this.tinhdiemtb());

        }

    }
}

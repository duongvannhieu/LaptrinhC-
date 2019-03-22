using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap so sinh vien:");
            n = Int32.Parse(Console.ReadLine());
            SinhVien[] sv = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                sv[i] = new SinhVien();
                sv[i].nhap();
                sv[i].IN();
            }
            Console.ReadLine();
            float min = sv[0].tinhdiemtb();
            for (int i = 1; i < n; i++)
            {
                if (sv[i].tinhdiemtb() < min)
                    min = sv[i].tinhdiemtb();

            }

            Console.WriteLine("SV diem thap nhat la:{0}", min);

            for (int j = 0; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if (sv[k].tinhdiemtb() < sv[j].tinhdiemtb())
                    {
                        SinhVien sx = new SinhVien();
                        sx = sv[j];
                        sv[j] = sv[k];
                        sv[k] = sx;
                    }
                }
            }
            Console.WriteLine(" thong tin sinh vien sau khi xap sep la:");
            for (int j = 0; j < n; j++)
                Console.WriteLine("sinh vien ma {0} co diem TB la : {1}", sv[j].maSV, sv[j].tinhdiemtb());


            for (int i = 0; i < n; i++)
            {
                if (sv[i].maSV.Contains("IT"))
                    Console.WriteLine("sinh vien ma {0} co diem TB la:{1}", sv[i].maSV, sv[i].tinhdiemtb());

            }


            Console.ReadLine();
        }
    }
}

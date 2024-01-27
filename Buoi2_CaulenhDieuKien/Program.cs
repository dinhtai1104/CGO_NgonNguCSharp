using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_CaulenhDieuKien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DIEU KIEN
            //Console.WriteLine("Bai hoc 2 - Cau lenh dieu kien if");

            //bool c = false;
            //bool d = true;
            //int ab = 10;
            //int a = 22;
            //int b = 20;

            //if (a < b) // so sanh bang
            //{
            //    // Code
            //    Console.WriteLine("A < B");
            //}
            //else
            //{
            //    // Code
            //    Console.WriteLine("B < A");
            //}
            //Console.WriteLine("Ket thuc kiem tra dieu kien");

            // BT1 Kiem tra so a co chia het cho so b hay khong
            //int a = 10;
            //int b = 0;

            //if (b != 0 && a % b == 0)
            //{
            //    Console.WriteLine("A Chia het B");
            //}
            //else // phanDu != 0
            //{
            //    Console.WriteLine("A Khong chia het B va du: " );
            //}



            //int a = 10;
            //int b = 2;

            //if (b == 0)
            //{
            //    Console.WriteLine("A Khong chia het B");
            //}
            //else
            //{
            //    if (a % b == 0)
            //    {
            //        Console.WriteLine("A chia het B");
            //    }
            //    else
            //    {
            //        Console.WriteLine("A Khong chia het B");
            //    }
            //}

            //if (b == 0 || a % b != 0)
            //{
            //    Console.WriteLine("A Khong chia het B");
            //}
            //else 
            //{
            //    Console.WriteLine("A chia het B");
            //}

            //if (b == 0)
            //{
            //    Console.WriteLine("A Khong chia het B");
            //}
            //else
            //{
            //    if (a % b == 0)
            //    {
            //        Console.WriteLine("A chia het B");
            //    }
            //    else
            //    {
            //        Console.WriteLine("A Khong chia het B");
            //    }
            //}
            // =>
            //if (b == 0)
            //{
            //    Console.WriteLine("A Khong chia het B");
            //}
            //else if (a % b == 0) // b != 0
            //{

            //} 
            //else if (Qua  ngay moi hay chua)
            //{

            //}
            //else if (Da nhan qua moi hay chua) 
            //{

            //}
            //else
            //{

            //}
            #endregion

            // Giải phương trình bậc nhất(tìm x)
            // ax + b = c
            int a = 1, b = 10, c = 3;
            float x;

            Console.Write("Nhap a: ");
            string aString = Console.ReadLine();
            a = int.Parse(aString);

            Console.Write("Nhap b: ");
            string bString = Console.ReadLine();
            b = int.Parse(bString);

            Console.Write("Nhap c: ");
            string cString = Console.ReadLine();
            c = int.Parse(cString);

            Console.WriteLine("Giai phuong trinh");
            Console.WriteLine(a + "x + " + b + " = " + c);


             // x = (c-b)/a
            if (a == 0)
            {
                // (x.0) + b = c => b==c
                if (b != c)
                {
                    // khong bao gio cai nay
                    Console.WriteLine("Khong tim duoc x vi a == 0 va b != c");
                }
                else
                {
                    Console.WriteLine("Co vo so x");
                }
            }
            else
            {
                x = (float)(c - b) / a;
                Console.WriteLine("Tim duoc x = " + x);
            }

            Console.ReadKey();
        }
    }
}

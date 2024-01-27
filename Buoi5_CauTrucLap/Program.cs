using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5_CauTrucLap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bai 1
            // Tính tổng từ 1 -> n và n nhập từ bàn phím
            //int n;
            //int sum = 0;
            //int i;

            //Console.Write("N=");
            //n = int.Parse(Console.ReadLine());

            //int soHienTai = 1;
            //for (i = 1; i <= n; i += 1)
            //{
            //    sum = sum + soHienTai;
            //    soHienTai = soHienTai + 1;
            //}

            //Console.WriteLine("Sum: " + sum);
            #endregion
            #region Bai 2
            // In ra các ước của số n
            // Ước là gì? là số mà số n chia hết
            // 6 => ước: 1 2 3 6
            // 1 2 3 4 5 6

            //int n;
            //Console.Write("N=");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i += 1)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            #endregion
            #region Bai 3

            // Nhập n
            // In ra bảng cửu chương của n theo định dạng
            // n = 3
            // Bang cuu chuong cua 3
            // n + "x" + i + "=" + n * i
            // 3 x 1 = 3
            // 3 x 2 = 6
            // 3 x 3 = 9
            //...
            // 3 x 10 = 30

            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i += 1) // i = i + 1
            //{
            //    Console.WriteLine("Looop " + n);
            //}
            #endregion
            #region Bai 4
            /*
             ****************
             ****************
             ****************
             ****************
             ****************
             m = chiều dài
             n = chiều rộng;
             
            ****************
            for (int i = 0; i < m; i++) 
            {
                Console.Write("*");
            }
             */

            int m = 20;
            int n = 10;

            // Vẽ nhieuefg hình chữ nhật (Gồm nhiều hình nhữ nhật)
            for (int x = 0; x < 2; x++)
            {
                // Công việc vẽ một hình chữ nhật (Gồm nhiều đường thẳng)
                for (int dong = 0; dong < n; dong++)
                {
                    // Công việc vẽ một đường thẳng
                    for (int i = 0; i < m; i++)
                    {
                        Console.Write("*");
                    }
                    // In xuống dòng
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            #endregion
            Console.ReadKey();
        }
    }
}

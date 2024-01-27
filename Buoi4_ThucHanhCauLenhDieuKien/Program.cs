using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Buoi4_ThucHanhCauLenhDieuKien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bai_1
            //Console.Write("Moi ban nhap tuoi: ");
            //int tuoi = int.Parse(Console.ReadLine());

            //if (tuoi > 0 && tuoi <= 2)
            //{
            //    Console.WriteLine("Tre so sinh");
            //}
            //else if (tuoi > 2 && tuoi <= 10)
            //{
            //    Console.WriteLine("Nhi dong");
            //}
            //else if (tuoi > 10 && tuoi <= 17)
            //{
            //    Console.WriteLine("Vi thanh nien");
            //}
            //else if (tuoi > 17 && tuoi <= 39)
            //{
            //    Console.WriteLine("Thanh nien");
            //}
            //else if (tuoi > 39 && tuoi <= 50)
            //{
            //    Console.WriteLine("Trung nien");
            //}
            //else
            //{
            //    Console.WriteLine("Cao nien");
            //}

            #endregion
            #region Chuyen so thanh chu
            int number = int.Parse(Console.ReadLine());
            if (number <= 10)
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.Write("three");
                        break;
                    case 4:
                        Console.Write("four");
                        break;
                    case 5:
                        Console.Write("five");
                        break;
                    case 6:
                        Console.Write("six");
                        break;
                    case 7:
                        Console.Write("seven");
                        break;
                    case 8:
                        Console.Write("eight");
                        break;
                    case 9:
                        Console.Write("nine");
                        break;
                    case 10:
                        Console.Write("ten");
                        break;
                }
            }
            if (number > 10 && number <= 20)
            {
                if (number == 11)
                {
                    Console.Write("eleven");
                }
                else if (number == 12)
                {
                    Console.Write("twelve");
                }
                else if (number == 20)
                {
                    Console.Write("twenty");
                }
                else if (number == 13)
                {
                    Console.Write("thirdteen");
                }
                else if (number == 15)
                {
                    Console.Write("fifteen");
                }
                else
                {
                    int soHangDonVi = number % 10;
                    switch (soHangDonVi)
                    {
                        case 4:
                            Console.Write("four");
                            break;
                        case 6:
                            Console.Write("six");
                            break;
                        case 7:
                            Console.Write("seven");
                            break;
                        case 8:
                            Console.Write("eight");
                            break;
                        case 9:
                            Console.Write("nine");
                            break;
                    }
                    Console.Write("teen ");
                }
            }
            if (number < 100 && number > 20)
            {
                int soHangChuc = number / 10;
                int soHangDonVi = number % 10;

                if (soHangChuc == 2)
                {
                    Console.Write("twenty-");
                }
                else
                {
                    switch (soHangChuc)
                    {
                        case 3:
                            Console.Write("thirdty-");
                            break;
                        case 4:
                            Console.Write("fourty-");
                            break;
                        case 5:
                            Console.Write("fifty-");
                            break;
                        case 6:
                            Console.Write("sixty-");
                            break;
                        case 7:
                            Console.Write("seventy-");
                            break;
                        case 8:
                            Console.Write("eighty-");
                            break;
                        case 9:
                            Console.Write("ninty-");
                            break;
                    }
                }

                if (soHangDonVi != 0)
                {
                    switch (soHangDonVi)
                    {
                        case 1:
                            Console.WriteLine("one");
                            break;
                        case 2:
                            Console.WriteLine("two");
                            break;
                        case 3:
                            Console.Write("three");
                            break;
                        case 4:
                            Console.Write("four");
                            break;
                        case 5:
                            Console.Write("five");
                            break;
                        case 6:
                            Console.Write("six");
                            break;
                        case 7:
                            Console.Write("seven");
                            break;
                        case 8:
                            Console.Write("eight");
                            break;
                        case 9:
                            Console.Write("nine");
                            break;
                    }
                }

            }
            if (number >= 100)
            {
                int soHangTram = number / 100;
                int soHangChuc = (number / 10) % 10;
                int soHangDonVi = number % 10;

                switch (soHangTram)
                {
                    case 1:
                        Console.Write("one");
                        break;
                    case 2:
                        Console.Write("two");
                        break;
                    case 3:
                        Console.Write("three");
                        break;
                    case 4:
                        Console.Write("four");
                        break;
                    case 5:
                        Console.Write("five");
                        break;
                    case 6:
                        Console.Write("six");
                        break;
                    case 7:
                        Console.Write("seven");
                        break;
                    case 8:
                        Console.Write("eight");
                        break;
                    case 9:
                        Console.Write("nine");
                        break;
                }

                Console.Write("hundred ");

                if (soHangChuc != 0)
                {

                    if (soHangChuc == 2)
                    {
                        Console.Write("twenty-");
                    }
                    else
                    {
                        switch (soHangChuc)
                        {
                            case 1:
                                Console.Write("tenty-");
                                break;
                            case 2:
                                Console.Write("twenty-");
                                break;
                            case 3:
                                Console.Write("thirdty-");
                                break;
                            case 4:
                                Console.Write("fourty-");
                                break;
                            case 5:
                                Console.Write("fifty-");
                                break;
                            case 6:
                                Console.Write("sixty-");
                                break;
                            case 7:
                                Console.Write("seventy-");
                                break;
                            case 8:
                                Console.Write("eighty-");
                                break;
                            case 9:
                                Console.Write("ninty-");
                                break;
                        }
                    }
                }
                if (soHangDonVi != 0)
                {
                    switch (soHangDonVi)
                    {
                        case 1:
                            Console.WriteLine("one");
                            break;
                        case 2:
                            Console.WriteLine("two");
                            break;
                        case 3:
                            Console.Write("three");
                            break;
                        case 4:
                            Console.Write("four");
                            break;
                        case 5:
                            Console.Write("five");
                            break;
                        case 6:
                            Console.Write("six");
                            break;
                        case 7:
                            Console.Write("seven");
                            break;
                        case 8:
                            Console.Write("eight");
                            break;
                        case 9:
                            Console.Write("nine");
                            break;
                    }
                }
            }
            #endregion
            #region B3
            //int hourWork;
            //int salary;
            //float sum = 0;

            //Console.Write("Input Salary: ");
            //salary = int.Parse(Console.ReadLine());

            //Console.Write("Input Hourwork: ");
            //hourWork = int.Parse(Console.ReadLine());

            //if (hourWork >= 200)
            //{
            //    sum = salary * 0.2f;
            //}
            //else if (hourWork < 200 && hourWork >= 100)
            //{
            //    sum = salary * 0.1f;
            //}
            //else
            //{
            //    sum = 0;
            //}
            //Console.Write("Thuong: " + sum);
            #endregion

            //float N;
            //Console.Write("Nhap N: ");
            //N = float.Parse(Console.ReadLine());

            //int giaTriNguyen = (int)N;
            //// 1.
            //if (giaTriNguyen == N)
            //{
            //    Console.WriteLine("So Nguyen");

            //    //2.
            //    if (N % 2 == 0)
            //    {
            //        Console.WriteLine("So Chan");
            //    }
            //    else
            //    {
            //        Console.WriteLine("So Le");
            //    }

            //    if (N % 2 == 0 && N >= 0)
            //    {
            //        Console.WriteLine("So Chan Duong");
            //    }
            //    else if (N % 2 == 1 && N > 0)
            //    {
            //        Console.WriteLine("So Le Duong");
            //    }
            //    else if (N < 0 && (-N) % 2 == 0)
            //    {
            //        Console.WriteLine("So Chan Am");
            //    }
            //    else if (N < 0 && (-N) % 2 == 1)
            //    {
            //        Console.WriteLine("So Le Am");
            //    }

            //    float canbachaiN = (float)Math.Sqrt(N);
            //    int phanNguyenCuaCanBacHai = (int)canbachaiN;
            //    if (phanNguyenCuaCanBacHai == canbachaiN)
            //    {
            //        Console.WriteLine("So chinh phuong");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ko chinh phuong");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("So Thap Phan");
            //    Console.WriteLine("So Thap Phan khong co tinh chan le");
            //}

            //2.



            // (int)1.2 
            // (int)1.0 = 1 => 1.0 == 1
            // 1.2 => (int)1.2 = 1 != 1.2
            // (int)N == N

            Console.ReadKey();
        }
    }
}

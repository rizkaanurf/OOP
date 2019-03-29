using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
//    abstract class Hitung
//    {
//        public abstract double Perhitungan();
//    }

//    class Segitiga : Hitung
//    {
//        public int sisi1;
//        public int sisi2;
//        public int sisi3;

//        //constructor
//        public Segitiga(int a, int b, int c)
//        {
//            sisi1 = a;
//            sisi2 = b;
//            sisi3 = c;
//        }

//        //override
//        public override double Perhitungan()
//        {
//            return (sisi1 * sisi2 * sisi3);
//        }
//    }

//    class Lingkaran : Hitung
//    {
//        public int jarijari;

//        //contructor
//        public Lingkaran(int r)
//        {
//            jarijari = r;
//        }

//        //override
//        public override double Perhitungan()
//        {
//            return (2 * (22 / 7) * jarijari);
//        }
//    }

//    class PersegiPanjang : Hitung
//    {
//        public int panjang;
//        public int lebar;

//        //constructor
//        public PersegiPanjang(int p, int l)
//        {
//            panjang = p;
//            lebar = l;
//        }

//        public override double Perhitungan()
//        {
//            return (2 * (panjang + lebar));
//        }
//    }

//    class Trapesium : Hitung
//    {
//        public int A;
//        public int B;
//        public int C;
//        public int D;

//        //constructor
//        public Trapesium(int a, int b, int c, int d)
//        {
//            A = a;
//            B = b;
//            C = c;
//            D = d;
//        }

//        //override
//        public override double Perhitungan()
//        {
//            return ((A * B) + (B * C) + (C * D) + (D * A));
//        }
//    }

//    class Polymorphism
//    {
//        public static void Main(String[] args)
//        {
//            int n;
//            Console.WriteLine("-------------------------------");
//            Console.WriteLine("PERHITUNGAN KELILING");
//            Console.WriteLine("-------------------------------");
//            Console.WriteLine("1. Segitiga");
//            Console.WriteLine("2. Lingkaran");
//            Console.WriteLine("3. Persegi Panjang");
//            Console.WriteLine("4. Trapesium");
//            Console.WriteLine("-------------------------------");
//            Console.Write("Masukkan pilihan mu : ");
//            n = Convert.ToInt16(Console.ReadLine());
//            Console.WriteLine("-------------------------------");

//            switch (n)
//            {
//                case 1:
//                    Console.WriteLine();
//                    Console.WriteLine("Keliling Segitiga");
//                    Console.Write("Masukkan Sisi 1 : ");
//                    int s1 = Convert.ToInt16(Console.ReadLine());
//                    Console.Write("Masukkan Sisi 2 : ");
//                    int s2 = Convert.ToInt16(Console.ReadLine());
//                    Console.Write("Masukkan Sisi 3 : ");
//                    int s3 = Convert.ToInt16(Console.ReadLine());
//                    Hitung s = new Segitiga(s1, s2, s3);
//                    double kelSegitiga = s.Perhitungan();
//                    Console.Write("Keliling = " + kelSegitiga);
//                    break;

//                case 2:
//                    Console.WriteLine();
//                    Console.WriteLine("Keliling Lingkaran");
//                    Console.Write("Masukkan Jari-jari : ");
//                    int r = Convert.ToInt16(Console.ReadLine());
//                    Hitung l = new Lingkaran(r);
//                    double kelLingkaran = l.Perhitungan();
//                    Console.Write("Keliling = " + kelLingkaran);
//                    break;

//                case 3:
//                    Console.WriteLine();
//                    Console.WriteLine("Keliling Persegi Panjang");
//                    Console.Write("Masukkan Panjang : ");
//                    int p = Convert.ToInt16(Console.ReadLine());
//                    Console.Write("Masukkan Lebar : ");
//                    int lb = Convert.ToInt16(Console.ReadLine());
//                    Hitung pp = new PersegiPanjang(p, lb);
//                    double kelPersegiPanjang = pp.Perhitungan();
//                    Console.Write("Keliling = " + kelPersegiPanjang);
//                    break;

//                case 4:
//                    Console.WriteLine();
//                    Console.WriteLine("Keliling Trapesium");
//                    Console.Write("Masukkan nilai A : ");
//                    int a = Convert.ToInt16(Console.ReadLine());
//                    Console.Write("Masukkan nilai B : ");
//                    int b = Convert.ToInt16(Console.ReadLine());
//                    Console.Write("Masukkan nilai C : ");
//                    int c = Convert.ToInt16(Console.ReadLine());
//                    Console.Write("Masukkan nilai D : ");
//                    int d = Convert.ToInt16(Console.ReadLine());
//                    Hitung t = new Trapesium(a, b, c, d);
//                    double kelTrapesium = t.Perhitungan();
//                    Console.Write("Keliling = " + kelTrapesium);
//                    break;

//                default:
//                    Console.Write("Masukkan anda tidak tepat");
//            }
//            Console.Read();
//        }
//    }
}

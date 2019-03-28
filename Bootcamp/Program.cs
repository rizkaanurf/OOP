using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    //class Program
    //{
    //    static Program calling = new Program();
    //    static void Main(string[] args)
    //    {
    //        calling.view();
    //    }

    //    void view()
    //    {
    //        //deklarasi variabel
    //        int a, b;

    //        //inputan dari user
    //        Console.Write("Insert a number : ");
    //        a = Convert.ToInt16(Console.ReadLine());
    //        Console.Write("Insert b number : ");
    //        b = Convert.ToInt16(Console.ReadLine());

    //        //pemanggilan method perkalian
    //        Console.Write("Hasil : " + calling.Perkalian(a, b));
    //        Console.Read();
    //    }

    //    public int Perkalian(int a, int b)
    //    {
    //        int sum = 0;
    //        if (b < 0)
    //        {
    //            for (int i = 0; i > b; i--)
    //            {
    //                sum = sum + (a * (-1));
    //            }
    //        }
    //        else
    //        {
    //            for (int i = 0; i < b; i++)
    //            {
    //                sum = sum + a;
    //            }
    //        }
    //        return sum;
    //    }
    //}

    //public class Parent
    //{
    //    public int a;
    //    public int b;
    //}

    //public class Child : Parent, Isupp
    //{
    //    public int getDataFromParent()
    //    {
    //        return (a * b);
    //    }
    //}

    //public interface Isupp
    //{

    //}
    
    //public class Mahasiswa
    //{
    //    private string name;
    //    private string nim;

    //    public void View()
    //    {
    //        //this.name = "Rizka";
    //    }
    //}
    

    //public class Jurusan
    //{
    //    static void Main(string[] args)
    //    {
    //    Mahasiswa mhs = new Mahasiswa();
    //        mhs.View();
    //     }
    //}

    abstract class Process
    {
        public abstract decimal Processing();
    }

    class Rectangle : Process
    {
        public int length;
        public int width;

        //contructor
        public Rectangle(int a, int b)
        {
            length = a;
            width = b;
        }

        //overide
        public override decimal Processing()
        {
            return (length * width);
        }
    }

    class Circle : Process
    {
        public int jarijari;

        //contructor
        public Circle(int a)
        {
            jarijari = a;
        }

        public override decimal Processing()
        {
            return (2*(22/7)*jarijari);
        }
    }

    class RectangleProcess
    {
        //public static void Main(String[] args)
        //{
        //    Process r = new Rectangle(10, 7);
        //    decimal l = r.Processing();
        //    Console.Write("Luas : " + l);
        //    Console.WriteLine();

        //    Process c = new Circle(4);
        //    decimal k = c.Processing();
        //    Console.Write("Keliling : " + k);
        //    Console.Read();
        //}
    }
}

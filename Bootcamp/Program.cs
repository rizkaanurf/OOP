using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //deklarasi class model
            Context context = new Context();
            Supplier supplier = new Supplier();
            Item item = new Item();
            string Name;
            int Id, Supplier_Id;

            //Menampilkan data
            //var get = context.Supplier.ToList().Where(x => x.IsDelete == false);
            //foreach (var list in get)
            //{
            //    Console.WriteLine(list.Id);
            //    Console.WriteLine(list.Name);
            //}
            //Console.Read();

            //Insert data Supplier
            //Console.Write("Insert your name : ");
            //Name = Console.ReadLine();
            //supplier.Name = Name;
            //context.Supplier.Add(supplier);
            //var result = context.SaveChanges();
            //if(result > 0)
            //{
            //    Console.Write("Insert Successfully");
            //}else
            //{
            //    Console.Write("Insert Failed");
            //}
            //Console.Read();

            //Edit data Supplier
            //Console.Write("Insert Your Id : ");
            //Id = Convert.ToInt16(Console.ReadLine());
            //var get = context.Supplier.Find(Id);
            ////var get2 = context.Supplier.SingleOrDefault(x => x.Id == Id);
            //if(get != null)
            //{
            //    Console.Write("Insert your Name : ");
            //    Name = Console.ReadLine();
            //    get.Name = Name;
            //    context.Entry(get).State = EntityState.Modified;
            //    var result = context.SaveChanges();
            //    if(result > 0)
            //    {
            //        Console.Write("Update Successfully");
            //    }
            //    else
            //    {
            //        Console.Write("Update Failed");
            //    }
            //}
            //else
            //{
            //    Console.Write("No data found");
            //}
            //Console.Read();

            //soft delete Supplier
            //Console.Write("Insert Your Id : ");
            //Id = Convert.ToInt16(Console.ReadLine());
            //var get = context.Supplier.Find(Id);
            ////var get2 = context.Supplier.SingleOrDefault(x => x.Id == Id);
            //if(get != null)
            //{
            //    get.IsDelete = true;
            //    context.Entry(get).State = EntityState.Modified;
            //    var result = context.SaveChanges();
            //    if(result > 0)
            //    {
            //        Console.Write("Delete Successfully");
            //    }
            //    else
            //    {
            //        Console.Write("Delete Failed");
            //    }
            //}
            //else
            //{
            //    Console.Write("No data found");
            //}
            //Console.Read();

            //Insert data Item
            //Console.Write("Insert your name : ");
            //Name = Console.ReadLine();
            //Console.Write("Insert your supplier id: ");
            //Supplier_Id = Convert.ToInt16(Console.ReadLine());
            //var getSupplier = context.Supplier.Find(Supplier_Id);
            //if (getSupplier != null)
            //{
            //    item.Name = Name;
            //    item.Supplier = getSupplier;
            //    context.Item.Add(item);
            //    var result = context.SaveChanges();
            //    if (result > 0)
            //    {
            //        Console.Write("Insert Successfully");
            //    }
            //    else
            //    {
            //        Console.Write("Insert Failed");
            //    }
            //}
            //else
            //{
            //    Console.Write("No Data Found");
            //}
            //Console.Read();

            //Edit data Item (KURANG KALO SUPPLIER ID NYA ENGGA ADA)
            Console.Write("Insert Your Id : ");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = context.Item.Find(Id);
            if (get != null)
            {
                Console.Write("Insert your Name : ");
                Name = Console.ReadLine();
                get.Name = Name;
                Console.Write("Insert supplier id : ");
                Supplier_Id = Convert.ToInt16(Console.ReadLine());
                get.Supplier = context.Supplier.Find(Supplier_Id);
                context.Entry(get).State = EntityState.Modified;
                var result = context.SaveChanges();
                if (result > 0)
                {
                    Console.Write("Update Successfully");
                }
                else
                {
                    Console.Write("Update Failed");
                }
            }
            else
            {
                Console.Write("No data found");
            }
            Console.Read();

            //hard delete Item (KURANG PERTANYAAN UNTUK CONFIRM DELETE)
            //Console.Write("Insert Your Id : ");
            //Id = Convert.ToInt16(Console.ReadLine());
            //var get = context.Item.Find(Id);
            //if (get != null)
            //{
            //    context.Entry(get).State = EntityState.Deleted;
            //    var result = context.SaveChanges();
            //    if (result > 0)
            //    {
            //        Console.Write("Delete Successfully");
            //    }
            //    else
            //    {
            //        Console.Write("Delete Failed");
            //    }
            //}
            //else
            //{
            //    Console.Write("No data found");
            //}
            //Console.Read();
        }
    }
}

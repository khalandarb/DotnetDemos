using System;
using System.Collections.Generic;
using System.Linq;
namespace ShoppingAssignment
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Category category = new Category();
            List<Category> catList = new List<Category>();
            List<Stationary> stList = new List<Stationary>();
            List<Laptops> lpList = new List<Laptops>();
            List<Grocery> grList = new List<Grocery>();

            Category cat1 = new Category (){ id = 1, category = "Stationary" };
            Category cat2 = new Category() { id = 2, category = "Laptops" };
            Category cat3 = new Category() { id = 3, category = "Grocery" };
            catList.Add(cat1);
            catList.Add(cat2);
            catList.Add(cat3);

            Stationary st1 = new Stationary() { id = 1, cat_id = cat1.id, product = "Books", price = 20 };
            Stationary st2 = new Stationary() { id = 2, cat_id = cat1.id, product = "Pen", price = 10 };
            Stationary st3 = new Stationary() { id = 3, cat_id = cat1.id, product = "Pencil", price = 5 };
            stList.Add(st1);
            stList.Add(st2);
            stList.Add(st3);
            Laptops lp1 = new Laptops() { id = 1, cat_id = cat2.id, product = "Apple", price = 125000.0 };
            Laptops lp2 = new Laptops() { id = 2, cat_id = cat2.id, product = "Lenovo", price = 50000.0 };
            Laptops lp3 = new Laptops() { id = 3, cat_id = cat2.id, product = "Dell", price = 40000.0 };
            lpList.Add(lp1);
            lpList.Add(lp2);
            lpList.Add(lp3);

            Grocery gr1 = new Grocery() { id = 4, cat_id = cat3.id, product = "Rice", price = 400.0 };
            Grocery gr2 =  new Grocery() { id = 5, cat_id = cat3.id, product = "Wheat", price = 800.0 };
            Grocery gr3 = new Grocery { id = 6, cat_id = cat3.id, product = "Pulses", price = 250.0 };
            grList.Add(gr1);
            grList.Add(gr2);
            grList.Add(gr3);

            Console.WriteLine("WELCOME \n please enter your choice");
            Console.WriteLine("1.STATIONARY");
            Console.WriteLine("2.LAPTOPS");
            Console.WriteLine("3.GROCERY");
            
            choice = Convert.ToInt32(Console.ReadLine());
            int prod = 0;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("1.BOOKS");
                    Console.WriteLine("2.PEN");
                    Console.WriteLine("3.PENCIL \n");
                        Console.WriteLine("Select Product");
                        int product = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Quantity");
                        int qty = Convert.ToInt32(Console.ReadLine());
                    double disc = 0;
                    if (qty < 4)
                    {
                         disc = 5;
                    }else if (qty > 4 && qty<6)
                    {
                        disc = 7;
                    }
                    else
                    {
                        disc = 10;
                    }
                    List<Stationary> li = stList.FindAll(cat => cat.id == product);

                    foreach (var item in li)
                    {
                        Console.WriteLine($"{item.id} \t {item.cat_id} \t {item.product} \t {item.price} \n");
                        Console.WriteLine("Actual Amount"+ (item.price * qty));
                        Console.WriteLine("Discounted Amount is:" +((item.price*qty) - ((item.price * qty) * (disc / 100))));
                    }
                    
                    break;
                    case 2:
                        Console.WriteLine("1.Apple");
                        Console.WriteLine("2.Lenovo");
                        Console.WriteLine("3.Dell \n");
                        Console.WriteLine("Select Product");
                    Console.WriteLine("Select Product");
                     product = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Quantity");
                     qty = Convert.ToInt32(Console.ReadLine());

                    if (qty < 4)
                    {
                        disc = 5;
                    }
                    else if (qty > 4 && qty < 6)
                    {
                        disc = 7;
                    }
                    else
                    {
                        disc = 10;
                    }
                    List<Stationary> li2 = stList.FindAll(cat => cat.id == product);

                    foreach (var item in li2)
                    {
                        Console.WriteLine($"{item.id} \t {item.cat_id} \t {item.product} \t {item.price} \n");
                        Console.WriteLine("Actual Amount" + (item.price * qty));
                        Console.WriteLine("Discounted Amount is:" + ((item.price * qty) - ((item.price * qty) * (disc / 100))));
                    }

                    break;
                    case 3:

                    Console.WriteLine("1.Rice");
                    Console.WriteLine("2.Wheat");
                    Console.WriteLine("3.Pulses \n");
                    Console.WriteLine("Select Product");
                    product = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Quantity");
                    qty = Convert.ToInt32(Console.ReadLine());

                    if (qty < 4)
                    {
                        disc = 5;
                    }
                    else if (qty > 4 && qty < 6)
                    {
                        disc = 7;
                    }
                    else
                    {
                        disc = 10;
                    }
                    List<Stationary> li3 = stList.FindAll(cat => cat.id == product);

                    foreach (var item in li3)
                    {
                        Console.WriteLine($"{item.id} \t {item.cat_id} \t {item.product} \t {item.price} \n");
                        Console.WriteLine("Actual Amount" + (item.price * qty));
                        Console.WriteLine("Discounted Amount is:" + ((item.price * qty) - ((item.price * qty) * (disc / 100))));
                    }
                    break;
                    default:
                        Console.WriteLine("Enter Your Choice");
                        break;
                }
            
        }
    }
}

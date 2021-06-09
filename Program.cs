using System;
using System.Collections.Generic;
 
namespace Slotkin_CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Ilene Wright");
            names.Add("Anita Room");
            names.Add("Dynah Mite");
            names.Add("Al E. Gaightore");
            names.Add("Krystal Bahl");
            names.TrimExcess();
            names.RemoveAt(3);
            names.Remove("Krystal Bahl");

            //for (int i = 0; i < names.Count; ++i)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //Program.DisplayNames(names);

            //Console.WriteLine("Count of list: " + names.Count); //implicitly converts to string; use ToString() to explicitly convert
            //Console.WriteLine("Capacity of list: " + names.Capacity); //implicitly converts to string; use ToString() to explicitly convert

            string doAnother = "y";
            do
            {
                Program.DisplayNames(names);
                Console.Write("(A)dd, (R)emove, (S)earch: ");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "A":
                        Console.Write("Name to add: ");
                        names.Add(Console.ReadLine());
                        break;
                    case "R":
                        Console.Write("Index or name to remove: ");
                        string nameOrIndex = Console.ReadLine();
                        int index;
                        if (int.TryParse(nameOrIndex, out index))
                        {
                            names.RemoveAt(index - 1);
                        }
                        else
                        {
                            names.Remove(nameOrIndex);
                        }
                        break;
                    case "S":
                        Console.Write("Name to search: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Index is " + names.IndexOf(name) + 1);
                        break;
                }

                Console.Write("Do another(y/n)? ");
                doAnother = Console.ReadLine();

            } while (doAnother == "y");  
        }

        private static void DisplayNames(List<string> names)
        {
            for (int i = 0; i < names.Count; ++i)
            {
                Console.WriteLine((i + 1) + ". " + names[i]);
            }
            Console.WriteLine();
        }
    }
}


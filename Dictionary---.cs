using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict__eg2
{ 
        class dictionary
        {
            static void Main(string[] args)
            {
                Dictionary<int, string> D = new Dictionary<int, string>();
                D.Add(1, "Bangalore");
                D.Add(2, "Mumbai");
                D.Add(3, "Pune");
                D.Add(4, "Hyderbad");
                D.Add(5, "Chennai");
                D.Add(6, "kolkata");
                D.Add(7, "Ahmedabad");

                foreach (KeyValuePair<int, string> x in D)
                {
                    Console.WriteLine("All the elements are :" + x.Key + "" + x.Value);
                }
                Console.WriteLine("removing or popping 6 ele are");
                D.Remove(1);
                D.Remove(2);
                D.Remove(3);
                D.Remove(4);
                D.Remove(5);
                D.Remove(6);
                foreach (KeyValuePair<int, string> x in D)
                {
                    Console.WriteLine("Remainign elements are :" + x.Key + "" + x.Value);
                }


                ////we should push here
                Console.WriteLine("pushing again ele");
                D.Add(8, "Bangalore");
                D.Add(9, "Mumbai");
                D.Add(10, "Pune");
                D.Add(11, "Hyderbad");
                D.Add(12, "Chennai");
                foreach (KeyValuePair<int, string> x in D)
                {
                    Console.WriteLine("Remainign elements are :" + x.Key + "" + x.Value);
                }
                Console.WriteLine("again popping the 5 elemts");
                D.Remove(7);
                D.Remove(8);
                D.Remove(9);
                D.Remove(10);
                D.Remove(11);
                foreach (KeyValuePair<int, string> x in D)
                {
                    Console.WriteLine("Remainign elements are :" + x.Key + "" + x.Value);
                }
                //pushing elemts again to the data
                Console.WriteLine("pushing ele");
                D.Add(13, "Kolakata");
                D.Add(14, "Ahmebad");
                D.Add(15, "Bangalore");
                D.Add(16, "Mumbai");
                foreach (KeyValuePair<int, string> x in D)
                {
                    Console.WriteLine("Remainign elements are :" + x.Key + "" + x.Value);
                }
                Console.WriteLine("popping 4 times");
                D.Remove(12);
                D.Remove(13);
                D.Remove(14);
                D.Remove(15);
                foreach (KeyValuePair<int, string> x in D)
                {
                    Console.WriteLine("Remainign elements are :" + x.Key + "" + x.Value);
                }
                Console.WriteLine("pushing ele");
                D.Add(17, "Pune");
                D.Add(18, "hyderbad");
                D.Add(19, "chennai");
                foreach (KeyValuePair<int, string> x in D)
                {
                    Console.WriteLine("Remainign elements are :" + x.Key + "" + x.Value);
                }
                Console.WriteLine("popping 3 times");
                D.Remove(16);
                D.Remove(17);
                D.Remove(18);
                foreach (KeyValuePair<int, string> x in D)
                {
                    Console.WriteLine("Remainign elements are :" + x.Key + "" + x.Value);
                }
                Console.WriteLine("pushing here!!");
                D.Add(20, "kolkata");
                D.Add(21, "Ahemabad");
                foreach (KeyValuePair<int, string> x in D)
                {
                    Console.WriteLine("Remainign elements are :" + x.Key + "" + x.Value);
                }
                Console.WriteLine("popping 2 times");
                D.Remove(19);
                D.Remove(20);
                foreach (KeyValuePair<int, string> x in D)
                {
                    Console.WriteLine("Remainign elements are :" + x.Key + "" + x.Value);
                }
                Console.ReadKey();

            }
        }
    }
}
    }
}

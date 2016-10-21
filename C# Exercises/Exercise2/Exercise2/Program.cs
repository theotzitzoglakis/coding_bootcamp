using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        public class Coffee
        {
            public Size size { get; private set; }

            public enum Size
            {
                Small = 50,
                Normal = 150,
                Double = 300
            }

            public Coffee(Size size)
            {
                this.size = size;
            }

            public class Order
            {
                public List<Coffee> items = new List<Coffee>();

                public void Add(Coffee coffee)
                {
                    items.Add(coffee);
                }


                public double CalculateCost()
                    {
                        double price = 0;
                        foreach (Coffee c in items)
                        {
                           switch(c.size)
                            {
                                case Coffee.Size.Small:
                                    price += 0.5;
                                    break;
                                case Coffee.Size.Normal:
                                    price += 1.5;
                                    break;
                                case Coffee.Size.Double:
                                    price += 2.5;
                                    break;
                                default:
                                    break;
                            }
                    }
                    return price;
                }
            }         
        }
        static void Main(string[] args)
        {
            Coffee c1 = new Coffee(Coffee.Size.Small);
            Console.WriteLine("{0} coffee is {1}ml", Coffee.Size.Small, (int)Coffee.Size.Small);

            Coffee.Order order = new Coffee.Order();
            order.Add(c1);
            order.Add(new Coffee(Coffee.Size.Small));
            Coffee c2 = new Coffee(Coffee.Size.Double);
            order.Add(c2);
            order.Add(new Coffee(Coffee.Size.Normal));

            Console.WriteLine("The totel cost is {0}", order.CalculateCost());

            Console.ReadKey();
        }
    }
}

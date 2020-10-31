using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualTax
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please Enter the Salary:");
            //int salary = Convert.ToInt32(Console.Read());
            int salary =Convert.ToInt32(Console.ReadLine());
            int annual = salary * 12;
            Console.WriteLine($"Annual Salary:{annual}");
            if (annual >= 800000)
            {
                if (annual >= 1200000)
                {
                    if (annual >= 2000000)
                    {
                        if (annual <= 2600000)
                        {
                            int a1, a2, a3, a4, a5;
                            float tax1 ;
                            float tax2 ;
                            float tax3 ;
                            float totaltax ;
                            Console.WriteLine("Annual Salary:" + annual);
                            a1 = annual - 800000;
                            a2 = 400000;
                            a3 = a1 - a2;
                            tax1 = a2 * 5 / 100;
                            Console.WriteLine("Tax between above 8 Lac to 12 Lac:" + tax1);
                            a4 = 800000;
                            tax2 = a4 * 10 / 100;
                            Console.WriteLine("Tax between above 12 Lac to 20 Lac:" + tax2);
                            a5 = a3 - a4;
                            tax3 = a5 * 15 / 100;
                            Console.WriteLine("Tax between above 20 Lac to 26 Lac:" + tax3);
                            totaltax = tax1 + tax2 + tax3;
                            Console.WriteLine(" TotalTax:" + totaltax);

                        }
                        else
                        {
                            Console.WriteLine("Limit Exceeded");
                        }

                    }
                    else
                    {
                        if (annual >= 1200000 || annual <= 2000000)
                        {
                            int a1, a2, a3;
                            float tax1 = 0f;
                            float tax2 = 0f;
                            
                            float totaltax = 0f;
                            a1 = annual - 800000;
                            a2 = 400000;
                            a3 = a1 - a2;
                            tax1 = a2 * 5 / 100;
                            Console.WriteLine("Tax between above 8 Lac to 12 Lac:" + tax1);
                            tax2 = a3 * 10 / 100;
                            Console.WriteLine("Tax between above 12 Lac to 20 Lac:" + tax2);
                            totaltax = tax1 + tax2;
                            Console.WriteLine(" TotalTax:" + totaltax);


                        }
                    }

                }
                else
                {
                    if (annual >= 800000 || annual <= 1200000)
                    {
                        int a1;
                        float tax1;
                        a1 = annual - 800000;

                        tax1 = a1 * 5 / 100;
                        Console.WriteLine("Tax between above 8 Lac to 12 Lac:" + tax1);

                    }
                }

            }
            else
            {
                Console.WriteLine("You are Tax Free:");
            }
            Console.WriteLine("Success");
            Console.ReadKey();

        }
    }
}

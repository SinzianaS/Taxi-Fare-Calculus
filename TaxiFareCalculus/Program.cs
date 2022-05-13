using System;

namespace TaxiFareCalculus
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeOfDay = Convert.ToInt32(Console.ReadLine());
            int distKm = Convert.ToInt32(Console.ReadLine());
            int totalPay = 0;
            if (timeOfDay >= 8 && timeOfDay < 21)
            {
                if (distKm < 20)
                {
                    totalPay = distKm * 5;
                }

                else if (distKm >= 21 && distKm <= 60)
                {
                    totalPay = distKm * 4 * 2;
                }

                else if (distKm > 60)
                {
                    totalPay = distKm * 3 * 2;
                }
            }

            else
            { 
                if (distKm <= 20)
                {
                    totalPay = distKm * 7;
                }

                else if (distKm > 20 && distKm <= 60)
                {
                    totalPay = distKm * 5 * 2;
                }

                else 
                {
                    totalPay = distKm * 4 * 2;
                }
            }
            

            Console.WriteLine(totalPay);
            Console.ReadLine();
        }
    }
}


using System;

namespace Exchange_rate_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string[] currency = { "usd", "euro", "try", "rub" };
                string[] commandBox = { "/show-recent-currency-rates", "/find-currency-rate-by-code", "/calculate-amount-by-currecy", "/exit" };
                string exit = "/exit";
                int error = 0;

                double[] currencyRate = { 0.59, 0.55, 9.66, 37.27 };

                for (int i = 0; i < commandBox.Length; i++)
                {
                    Console.WriteLine(commandBox[i]);
                }
                string requiredCommand = Console.ReadLine();



                while (true)
                {
                    Console.WriteLine("---------------------------------------------------------");
                    for (int i = 0; i < currency.Length; i++)
                    {
                        Console.WriteLine($" 1 AZN = { currencyRate[i]} {currency[i]} ");
                    }
                    Console.WriteLine("If you want to stop program /exit ");

                    Console.Write("Type the desired currency as described above (usd,euro,try,rub)  : ");
                    string requiredRate = Console.ReadLine();

                    if (requiredRate == exit)
                    {
                        Console.WriteLine("Thank you for choosing our service");
                        break;
                    }


                    Console.Write("Please enter a price : ");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("");

                    for (int i = 0; i < currency.Length; i++)
                    {
                        if (requiredRate != currency[i])
                        {
                            error++;
                        }
                        else if (requiredRate == currency[i])
                        {
                            Console.WriteLine($"Exchange rate code : {requiredRate}");
                            Console.WriteLine($"{amount} AZN = {amount * currencyRate[i]} {requiredRate}");
                        }

                    }

                    if (error == currency.Length)
                    {
                        Console.WriteLine("Enter the information correctly!");
                    }

                    Console.WriteLine("");
                    Console.WriteLine("----------------------------------------------------------");
                

            }

            }

            

        }
    }
}

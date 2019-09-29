using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            double valueA = 0, valueB = 0, valueC = 0, total, average, max, min;
            bool runAgain = true, checkValueA, checkValueB, checkValueC;
            char repeatConfirm;

            while (runAgain == true)
            {
                checkValueA = true;
                checkValueB = true;
                checkValueC = true;

                Console.WriteLine("Please enter your first monetary amount.");

                while (checkValueA == true)
                {
                    checkValueA = false;

                    try
                    {
                        valueA = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please only enter a numeric value.");
                        checkValueA = true;
                    }
                }

                Console.WriteLine("Please enter your second monetary amount.");

                while (checkValueB == true)
                {
                    checkValueB = false;

                    try
                    {
                        valueB = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please only enter a numeric value.");
                        checkValueB = true;
                    }
                }

                Console.WriteLine("Please enter your third monetary amount.");

                while (checkValueC == true)
                {
                    checkValueC = false;

                    try
                    {
                        valueC = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please only enter a numeric value.");
                        checkValueC = true;
                    }
                }

                total = valueA + valueB + valueC;

                average = Math.Round((total / 3), 2);

                max = Math.Max(valueA, Math.Max(valueB, valueC));

                min = Math.Min(valueA, Math.Min(valueB, valueC));

                Console.WriteLine("The average of the values you entered is {0}.", average);
                Console.WriteLine("The highest value entered was: {0}.", max);
                Console.WriteLine("The lowest value entered was: {0}.", min);

                //Added due to Thai Baht currency symbol displaying as '?'
                Console.OutputEncoding = System.Text.Encoding.Unicode;

                Console.WriteLine("The total in US Dollars would be: {0:C}.", total);
                Console.WriteLine("The total in Swedish Krona would be: {0}.", (total.ToString("c", CultureInfo.GetCultureInfo("sv-SE"))));
                Console.WriteLine("The total in Japanese Yen would be: {0}.", (total.ToString("c", CultureInfo.GetCultureInfo("ja-JP"))));
                Console.WriteLine("The total in Thai Baht would be: {0}.", (total.ToString("c", CultureInfo.GetCultureInfo("th-TH"))));

                Console.WriteLine("Press 'R' to run the program again.");
                repeatConfirm = Convert.ToChar(Console.ReadLine());

                if (repeatConfirm == 'R' || repeatConfirm == 'r')
                {
                    runAgain = true;
                }
                else
                {
                    runAgain = false;
                }
            }
        }
    }
}

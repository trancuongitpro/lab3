using System;

namespace lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sin validator");
            Console.WriteLine("==============");
            while (true)
            {
                Console.WriteLine("Sin (0 to quit)");
                var sin = Console.ReadLine();
                if (sin ! = null && sin.Equals("0"))
                {
                    Console.WriteLine("Have a Nice Day!");
                }
                else
                {
                    Console.WriteLine(CheckValindSin(sin)) ?"This is vail SIN.": "This is not a valid SIN.";
                }
            }
        }

        static void CheckValindSin(String sin)
        {
            int lastNumber;
            var totalEvenLineNumber = 0;
            var totalOddLineNumber = 0;
            var sinInCharArray = sin.ToCharArray();
            int[] numberOfSin = new int[9];
            int currentIndexOfNumberArray = 0;
            for (int i = 0; i < sinInCharArray.Length; i++)
            {
                if (sinInCharArray[i].ToString().Trim().Length ==0)
                {
                    continue;
                    ;
                }

                numberOfSin[currentIndexOfNumberArray] = Convert.ToInt32(sinInCharArray[i].ToString());
            }

            lastNumber = numberOfSin[currentIndexOfNumberArray - 1];
            for (int i = 0; i < numberOfSin.Length; i++)
            {
                if ((i + 1) % 2 !=0)
                {
                    totalOddLineNumber += numberOfSin[i];
                }
                else
                {
                    var doubleOfNumber = numberOfSin[i] * 2;
                    var charArry = doubleOfNumber.ToString().ToCharArray();
                    for (int j = 0; j < charArry.Length; j++)
                    {
                        totalEvenLineNumber += Convert.ToInt32(charArry[i].ToString());
                    }
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSEC_tasks
{
    abstract class BasicString
    {
        static void Main(string[] args)
        {
            List<char> LettersArray = new List<char>();
            List<char> DigitsArray = new List<char>();
            List<int> HelperArray = new List<int>();
            List<int> IntDigitsArray = new List<int>();
            Console.WriteLine("Введите строку Basic String" + "\r\n");
            string InputString = Console.ReadLine();
            char[] CharString = InputString.ToCharArray();
            int item = 0;
            
            for (int i = 0; i < CharString.Length; i++)
            {
                if (Char.IsDigit(CharString[i]))
                {
                    int j = i;
                    while (j < CharString.Length && Char.IsDigit(CharString[j]))
                    {
                        //Convert.ToInt32(CharString[j]);
                        int p = (int)Char.GetNumericValue(CharString[j]);
                        HelperArray.Add(p);
                        j++;
                    }
                    for (int k = (HelperArray.Count - 1); k >= 0; k--)
                    {
                        double stepen = HelperArray.Count - 1 - k;
                        item = item + HelperArray[k] * (Math.Pow(10.0, stepen));
                    }
                    IntDigitsArray.Add(item);
                    i = j-1;
                    item = 0;
                }
                else
                {
                    if (Char.IsLetter(CharString[i]))
                    {
                        LettersArray.Add(CharString[i]);
                    }
                }



                    /*if (Char.IsLetter(CharString[i]))
                {
                    LettersArray.Add(CharString[i]);
                }
                else
                {
                    if (Char.IsDigit(CharString[i]))
                    {
                        if (!Char.IsDigit(CharString[i++]))
                        {
                            DigitsArray.Add(CharString[i]);
                        }
                        else
                        {

                        }
                    }
                }*/
            }

            foreach (char symbol in LettersArray)
            {
                Console.WriteLine(symbol);
            }

            foreach (int element in IntDigitsArray)
            {
                Console.WriteLine(element + "\r\n");
            }

            string WaitString = Console.ReadLine();

            //Console.WriteLine("\r\n" + "Пользователь ввел строку " + InputString + "\r\n");
            //string WaitString = Console.ReadLine(); Console.WriteLine(CharString[i] + "\r\n");
        }
    }
}

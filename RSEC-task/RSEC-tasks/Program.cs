using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSEC_tasks
{
    abstract class BasicString
    {
        
        //Exponentiation method 
        static int StepenDesyatki(int x)
        {
            int result = 0;
            if (x == 0)
            {
                result = 1;
            }
            else
            {
                if (x == 1)
                {
                    result = 10;
                }

                else
                {
                    result = 10;
                    for (int m = 0; m <= (x - 2); m++)
                    {
                        result = result * 10;
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            string FinalLettersArray = "";
            string FinalDigitsArray = "";
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
                        int stepen = HelperArray.Count - 1 - k;
                        item = item + HelperArray[k] * StepenDesyatki(stepen);
                    }
                    IntDigitsArray.Add(item);
                    i = j - 1;
                    item = 0;
                    HelperArray.Clear();
                }
                else
                {
                    if (Char.IsLetter(CharString[i]))
                    {
                        LettersArray.Add(CharString[i]);
                    }
                }
            }

            foreach (char symbol in LettersArray)
            {
                FinalLettersArray += symbol.ToString();
            }

            foreach (int element in IntDigitsArray)
            {
                FinalDigitsArray += element.ToString();
            }


            /*foreach (char symbol in LettersArray)
            {
                Console.WriteLine(symbol);
            }

            Console.WriteLine("\n\r");

            foreach (int element in IntDigitsArray)
            {
                Console.WriteLine(element);
            }

            string WaitString = Console.ReadLine();*/

            Console.WriteLine("\r\n" + "Пользователь ввел строку " + InputString + "\r\n");
            Console.WriteLine("Массив букв " + FinalLettersArray + "\r\n");
            Console.WriteLine("Массив цифр " + FinalDigitsArray + "\r\n");
            string WaitString = Console.ReadLine();
        }
    }
}
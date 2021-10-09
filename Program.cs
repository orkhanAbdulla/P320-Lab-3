using System;
using System.Text;

namespace LAB_3
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Lab-3

            //Task-1

            Calculator
            Console.WriteLine("Input-1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Operator: + - * /");
            char opr = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Input-2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Calc(num1, opr, num2);

            //Task-2
            Console.WriteLine(ReplaceChar("Salam Baki"));

            //Task-3 

            int[] numArr = { 1, 5, 8, 4, 6, 12 };
            AddToArray(ref numArr, 58);
            foreach (var item in numArr)
            {
                Console.WriteLine(item);
            }
            //Task-4
            /
            int[] numbers = { 5, 10, 27, 92, 14, 17, 58, 35, 14 };
            ChangeToEven(ref numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //Task-5

            string[] fullName = { "Orkhan Abdullayev", "Tebriz Guliyev", "Agha Hasanli" };
            string[] names = MakeNamesArr(fullName);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            #endregion

        }
        #region Lab-3
            //Task - 1
            static int Calc(int num1, char opr, int num2)
            {
                int result = 0;

                switch (opr)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine($"{num1}{opr}{num2}={result}");
                        break;
                    case '-':
                        result = num1 - num2;
                        Console.WriteLine($"{num1}{opr}{num2}={result}");
                        break;
                    case '*':
                        result = num1 * num2;
                        Console.WriteLine($"{num1}{opr}{num2}={result}");
                        break;
                    case '/':
                        result = num1 / num2;
                        Console.WriteLine($"{num1}{opr}{num2}={result}");
                        break;

                    default:
                        Console.WriteLine("operator yanlishdi");
                        break;
                }
                return result;
            }
            //Task-2
            static string ReplaceChar(string str)
            {
                string newStr = str.Replace('a', '+');
                return newStr;
            }
            //Task - 3
            static void AddToArray(ref int[] arr, int num)
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = num;
            }

            //Task-4
            static void ChangeToEven(ref int[] nmbrArray)
            {
                int[] evenArray = new int[0];
                for (int i = 0; i < nmbrArray.Length; i++)
                {
                    if (nmbrArray[i] % 2 == 0)
                    {
                        Array.Resize(ref evenArray, evenArray.Length + 1);
                        evenArray[evenArray.Length - 1] = nmbrArray[i];
                    }
                }
                nmbrArray = evenArray;
            }
            //Task-5
            static string[] MakeNamesArr(string[] fullName)
            {
                string[] names = new string[fullName.Length];
                for (int i = 0; i < fullName.Length; i++)
                {
                    names[i] = fullName[i].Substring(0, fullName[i].IndexOf(" "));
                }
                return names;
            }



            #endregion
        
    }
}

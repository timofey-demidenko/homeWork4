using System;
using System.Text;
using static System.Console;

namespace Program
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //#1

            /*WriteLine("Enter number: ");
            int number = int.Parse(ReadLine());
            string binary = Convert.ToString(number, 2);
            WriteLine(binary);*/

            //#2

            /*string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            WriteLine("Write number: ");
            string word = ReadLine();
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] == word)
                    WriteLine(i);*/

            //#4

            /*String str = ReadLine();
            int a = Convert.ToInt32(str[0]);
            int b = Convert.ToInt32(str[2]);
            if (str[1] == '<') {
                if (a < b)
                    WriteLine("True");
                else
                    WriteLine("False");
            }
            else if (str[1] == '>') {
                if (a > b)
                    WriteLine("True");
                else 
                    Write("False");
            }
            else if (str[1] == '=') {
                if (a == b) 
                    WriteLine("True");
                else
                    WriteLine("False");
            }*/

        }

    }
    //#3

    internal class Passport
    {
        private string name = "";
        private string info = "";
        private string returndate = "";

        Passport(string name = "A.I.G", string info = "...", string returndate = "20.06.2022")
        {
            this.name = name;
            this.info = info;
            this.returndate = returndate;
        }
        public string Name { get { return name; } }
        public string Info { get { return info; } }
        public string Returndate { get { return returndate; } }


    }
}
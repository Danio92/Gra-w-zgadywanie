using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_zgadywanie
{
    class Program
    {
        private static int nbr;

        public static int Nbr { get => nbr; set => nbr = value; }

        private static void RandomNumber()
        {
            if (Nbr == 0)
            {
                Random rnd = new Random();
                int number = (int)rnd.Next(1, 10) + 1;

                Nbr = number;
            }
        }

        private static bool checkAnswer(int answer, out String text)
        {
            if (answer > Nbr)
            {
                text = $"TO HIGH NUMBER IT WAS: {Nbr}";
                return false;
            }

            else if (answer < Nbr)
            {
                text = $"TO LOW NUMBER IT WAS: {Nbr}";
                return false;
            }
            else
            {
                text = $"YOU WIN!!! IT WAS: {Nbr}";
                return true;
            }
        }

        public static bool RunGame()
        {
            int number = 0;
            String txt;
            RandomNumber();
            Console.WriteLine("Podaj liczbę:    ");
            try
            {
                number = (int)int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($@"
------------------------------------------------------
Wpisano niepoprawną liczbę!!! Ustawiam odpowiedź na 0.
------------------------------------------------------");
                Console.WriteLine();
                Console.ResetColor();
            }
            bool state = checkAnswer(number, out txt);
            Console.WriteLine(txt);
            if (state == true) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            do
            { }
            while (RunGame() != true);

            Console.ReadKey();
        }
    }
}

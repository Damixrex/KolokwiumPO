using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {

            char input = 'D';

            while (input != 'X')
            {
                Console.WriteLine("\nCo chcesz zrobić? \nA - Ustaw Napastnika\nB - Ustaw Obrocne\nC - Ustaw Nazwe\nD - Wypisanie Zawodników\nX - Wyjscie z Aplikacji");
                input = Console.ReadKey().KeyChar;

                switch (input)
                {
                    case 'A':
                        {
                            Console.WriteLine("\nWstawianie Napastnika");
                            break;
                        }
                    case 'B':
                        {
                            Console.WriteLine("\nWstawianie Obrońcy");
                            break;
                        }
                    case 'C':
                        {
                            Console.WriteLine("\nUstawienie Nazwy");
                            break;
                        }
                    case 'D':
                        {
                            Console.WriteLine("\nWypisanie Zawodników");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\n Proszę wybrać funkcje A B C D lub X aby wyjść.");
                            break;
                        }
                }

            }
        }
    }
}
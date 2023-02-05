using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHareAndTheTortoise
{
    internal static class Race
    {
        static int tortoise = 1;
        static int hare = 1;
        const int startingGate = 1;
        const int finishline = 30;

        public static void Go()
        {
            Console.WriteLine("ON YOUR MARK,\nGET SET,\nBANG!!!!!\nAND THEY’RE OFF!!!!!");
            Console.WriteLine();
            do
            {
                TortoiseMethod();
                HareMethod();
                ShowRace();

             Task.Delay(100).Wait();
            } while (tortoise < finishline && hare < finishline);

            if (tortoise == hare)
            {
                Console.WriteLine("\nIt’s a TIE!");
            }

            else if (tortoise > hare)
            {
                Console.WriteLine("\nTORTOISE WINS!!! YAY!!!");
            }

            else if (hare > tortoise)
            {
                Console.WriteLine("\nHare Wins.");
            }
        }
        static void TortoiseMethod()
        {
            Random randomNumbers = new Random();
            int move = randomNumbers.Next(1, 11);
 
            if (move >= 1 && move <= 5) //fast plod
            {
                tortoise += 3;
            }

            else if (move >= 6 && move <= 8) //slow plod
            {
                ++tortoise;
            }

            else if (move == 9 || move == 10) //slip
            {
                tortoise -= 6;
            }

            if (tortoise < startingGate)
            {
                tortoise = startingGate;
            }

            else if (tortoise > finishline)
            {
                tortoise = finishline;
            }

        }
        static void HareMethod()
        {
            Random randomNumbers = new Random();
            int move = randomNumbers.Next(1, 11);
            if (move == 1 || move == 2) // stay in place
            {
                hare += 0;
            }
            else if (move == 3 || move == 4) //big hop
            {
                hare += 9;
            }
            else if (move == 5) //big slip
            {
                hare -= 12;
            }
            else if (move > 5 && move <= 8) //small hop
            {
                ++hare;
            }
            else if (move == 9 || move == 10) //small slip
            {
                hare -= 2;
            }
            if (hare < startingGate)
            {
                hare = startingGate;
            }
            else if (hare > finishline)
            {
                hare = finishline;
            }
        }
        static void ShowRace()
        {
            for (int _move = 1; _move <= finishline; ++_move)
            {
                if (_move == tortoise && _move == hare)
                {
                    Console.Write("OUCH!!!");
                }

                else if (_move == tortoise)
                {
                    Console.Write("T");
                }
                else if (_move == hare)
                {
                    Console.Write("H");
                }
                else
                {
                    Console.Write(".");
                }
            }
        }     
    }
}

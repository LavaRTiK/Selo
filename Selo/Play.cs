using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selo
{
    class Play
    {
        private int MapWidth = 30 * 3; //Резмер консольки по точкам В ширину  
        private int MapHeight = 20 * 3; //Размер консоли по точкам В висоту запись (ширина,висота)
        Diler diler = new Diler();
        private const ConsoleColor BorderColor = ConsoleColor.Gray;
        static int a = new Settings().returnLanguage();
        public void PlayGame()
        {
            bool game = true;
            Console.Clear();
            new Rusificator().BlackJack();
            DrawBorder();
            Console.SetCursorPosition(35, 30);
            Console.Write("NamePlayer:");
            string name = Console.ReadLine();
            Console.SetCursorPosition(35, 31);
            Console.Write("MoneyPlayer:");
            int money = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Player player1 = new Player(name, money);
            while (game)
            {

                DrawBorder();
                player1.Start(); //Роздача игроку 2 карты 
                PlayerDisplay();//Вивод имени на екран 

                bool run = true;
                while (run)
                {

                    //Control
                    var c = Console.ReadKey().Key;
                    switch (c)
                    {
                        case ConsoleKey.Enter:
                            player1.GetCards();
                            break;
                        case ConsoleKey.Spacebar:
                            run = false;
                            break;
                        case ConsoleKey.Escape:
                            game = false;
                            run = false;
                            break;
                    }
                    if (player1.Sum > 21)
                    {
                        if (player1.PravoTusa > 0)
                        {
                            player1.PravoTusa--;
                            player1.Tus();
                            PlayerDisplay();
                        }
                        else
                        {
                            player1.Sum = -1;
                            PlayerDisplay();
                            Console.SetCursorPosition(40, 47);
                            Console.Write("Перебор");
                            Thread.Sleep(2000);
                            run = false;

                        }
                    }
                    PlayerDisplay();
                }
                diler.DillerPlay();
                DrawDillerInterface();
                if (player1.Sum == -1)
                {
                    Console.SetCursorPosition(40, 20);
                    Console.WriteLine("Diller WINSS");
                    Thread.Sleep(3000);
                }
                else
                {
                    if (diler.Sum == -1)
                    {
                        Console.SetCursorPosition(40, 20);
                        Console.WriteLine(player1.Name + "Winns");
                        Thread.Sleep(3000);
                    }
                }
                if (diler.Sum > player1.Sum)
                {
                    Console.SetCursorPosition(40, 20);
                    Console.WriteLine("Diller WINSS");
                    Thread.Sleep(2000);
                }
                else if (player1.Sum > diler.Sum)
                {
                    Console.SetCursorPosition(40, 20);
                    Console.WriteLine(player1.Name + "Winns");
                    Thread.Sleep(2000);
                }
                else if (player1.Sum == diler.Sum)
                {
                    Console.SetCursorPosition(40, 20);
                    Console.WriteLine("NICHIYA");
                    Thread.Sleep(2000);
                }
                Console.Clear();
                player1.PravoTusa = 0;
                diler.PravoTusa = 0;
                
            }
            void PlayerDisplay()
            {
                Console.SetCursorPosition(40, 48);
                Console.Write(player1.Name);
                Console.SetCursorPosition(40, 49);
                Console.Write(player1.Sum);
                //Console.WriteLine(player1.Id);

            }
            void DrawBorder()
            {
                for (int i = 1; i < MapWidth - 1; i++)
                {
                    new Pixel(i, 0, BorderColor).Draw();
                    new Pixel(i, MapHeight - 1, BorderColor).Draw();
                }

                for (int i = 1; i < MapHeight - 1; i++)
                {
                    new Pixel(0, i, BorderColor).Draw();
                    new Pixel(MapWidth - 1, i, BorderColor).Draw();
                }
            }
            void DrawDillerInterface()
            {
                Console.SetCursorPosition(40, 10);
                Console.Write("Diller");
                Console.SetCursorPosition(40, 13);
                Console.Write(diler.Sum);
            }
        }
    }
}


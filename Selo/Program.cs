using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selo
{

    public class Program 
    {
        private const int MapWidth = 30 * 3; //Резмер консольки по точкам В ширину  
        #region Идея
        //Сделать потом измения розширения екрана путем выборки умножения консоли , и кординаты будут стандартные зависсит от умножения 
        //Сделать в меню вкладку сетинг и там добавить зменинения будет крат минимум  2 или 3 , после теста точный результат и до 5, бошльше пяти нужно рисовать букви ,будет их почти не видно
        #endregion
        private const int MapHeight = 20*3; //Размер консоли по точкам В висоту запись (ширина,висота)
        private const ConsoleColor BorderColor = ConsoleColor.Gray;

        static void Main()
        {

            while (true)
            {     
                Console.SetWindowSize(MapWidth, MapHeight);
                Console.SetBufferSize(MapWidth, MapHeight);
                Console.Title = "BlackJack";
                Console.CursorVisible = true;
                int select = 0;
                int selectcursor = 27;
                int playgame = 0;
                DrawMenu drawMenu = new DrawMenu();
                drawMenu.DrawText();
                DrawBorder();
                Console.SetCursorPosition(30, selectcursor);
                drawMenu.DrawLine();
                while (playgame == 0)
                {
                    var a = Console.ReadKey().Key;
                    switch (a)
                    {
                        case ConsoleKey.UpArrow:
                            if (select == 0)
                            {
                                break;
                            }
                            for (int i = selectcursor; i > selectcursor - 7; i--)

                            {
                                Console.Clear();
                                drawMenu.DrawText();
                                DrawBorder();
                                Console.SetCursorPosition(30, i);
                                drawMenu.DrawLine();
                                Thread.Sleep(1);
                            }
                            selectcursor = selectcursor - 6;
                            select--;
                            break;
                        case ConsoleKey.DownArrow:
                            if (select == 2)
                            {
                                break;
                            }
                            for (int i = selectcursor; i < selectcursor + 6; i++)

                            {
                                Console.Clear();
                                drawMenu.DrawText();
                                DrawBorder();
                                Console.SetCursorPosition(30, i);
                                drawMenu.DrawLine();
                                Thread.Sleep(1);
                            }
                            selectcursor = selectcursor + 6;
                            select++;
                            break;
                        case ConsoleKey.Enter:
                            if (select == 0)
                            {
                                playgame++;
                                Console.Clear();
                                break;
                            }
                            else if (select == 1)
                            {
                                //drawMenu.Settings();
                            }
                            else if (select == 2)
                            {
                                Environment.Exit(0);
                                break;
                            }
                            break;
                    }
                }
                    //Тут должно быть заполниния игроков на поле (Имя,Денги)
                    Console.SetCursorPosition(20, 20);
                Console.Write(@"                                              
                     ____  _            _       _            _    
                    | __ )| | __ _  ___| | __  | | __ _  ___| | __
                    |  _ \| |/ _` |/ __| |/ /  | |/ _` |/ __| |/ /
                    | |_) | | (_| | (__|   < |_| | (_| | (__|   < 
                    |____/|_|\__,_|\___|_|\_\___/ \__,_|\___|_|\_\
                          ");
                DrawBorder();



                Console.SetCursorPosition(35, 30);
                Console.Write("NamePlayer:");
                string name = Console.ReadLine();
                Console.SetCursorPosition(35, 31);
                Console.Write("MoneyPlayer:");
                int money = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                DrawBorder();
                Player player1 = new Player(name, money);
                while (true)
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
                    Console.Clear();
                }
                void PlayerDisplay()
                {
                    Console.SetCursorPosition(40, 48);
                    Console.Write(player1.Name);
                    Console.SetCursorPosition(40, 49);
                    Console.Write(player1.Sum);

                }
                Console.ReadKey();
            }
        }

        static void DrawBorder()
        {
            for(int i = 1; i < MapWidth -1 ; i++)
            {
                new Pixel(i, 0, BorderColor).Draw();
                new Pixel(i, MapHeight -1, BorderColor).Draw();
            }

            for (int i = 1; i < MapHeight -1; i++)
            {
                new Pixel(0, i, BorderColor).Draw();
                new Pixel(MapWidth -1, i, BorderColor).Draw();
            }
        }
    }
    
}

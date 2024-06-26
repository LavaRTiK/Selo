﻿using System;
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
                Console.SetCursorPosition(30, selectcursor);
                while (playgame == 0)
                {
                    Rusificator rusificator = new Rusificator(new Settings().returnLanguage());
                    Console.Clear();
                    rusificator.DrawTextMenu();
                    DrawBorder();
                    if (select == 0)
                    {
                        Console.SetCursorPosition(30, 26);
                    }
                    else if (select == 1)
                    {
                        Console.SetCursorPosition(30, 32);
                    }
                    else if (select == 2)
                    {
                        Console.SetCursorPosition(30, 38);
                    }
                    rusificator.DrawLine();
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
                                Console.SetCursorPosition(30, i + 1);
                                Console.Write("                        ");
                                if (i == selectcursor - 4) { rusificator.DrawTextMenu() ; }
                                Console.SetCursorPosition(30, i);
                                rusificator.DrawLine();
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
                                Console.SetCursorPosition(30, i -1);
                                Console.Write("                        ");
                                if(i == selectcursor + 3) { rusificator.DrawTextMenu();  }
                                Console.SetCursorPosition(30, i);
                                rusificator.DrawLine();
                                Thread.Sleep(1); 
                            }
                            selectcursor = selectcursor + 6;
                            select++;
                            break;
                        case ConsoleKey.Enter:
                            if (select == 0)
                            {
                                new Play().PlayGame();
                                break;
                            }
                            else if (select == 1)
                            {
                                Settings settings = new Settings();
                                settings.DrawSettings();
                            }
                            else if (select == 2)
                            {
                                Environment.Exit(0);
                                break;
                            }
                            break;
                    }
                    
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

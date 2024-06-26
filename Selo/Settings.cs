﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selo
{
    class Settings
    {
        private int MapWidth = 30 * 3; //Резмер консольки по точкам В ширину  
        private int MapHeight = 20 * 3; //Размер консоли по точкам В висоту запись (ширина,висота)
        private const ConsoleColor BorderColor = ConsoleColor.Gray;

        static public int Language = 0;


    public void DrawSettings()
        {
            int select = 0;
            int selectcursor = 27;
            bool selector = true;
            while (selector)
            {
                Console.Clear();
                DrawText_leng();
                if (select == 0)
                {
                    Console.SetCursorPosition(10, 26);
                }
                else if (select == 1)
                {
                    Console.SetCursorPosition(10, 32);
                }
                else if (select == 2)
                {
                    Console.SetCursorPosition(10, 38);
                }
                DrawLine();

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
                            Console.SetCursorPosition(10, i + 1);
                            Console.Write("                        ");
                            Console.SetCursorPosition(10, i);
                            DrawLine();
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
                            Console.SetCursorPosition(10, i - 1);
                            Console.Write("                        ");
                            Console.SetCursorPosition(10, i);
                            DrawLine();
                            Thread.Sleep(1);
                        }
                        selectcursor = selectcursor + 6;
                        select++;
                        break;

                    case ConsoleKey.Escape:
                        selector = false;
                        break;

                    case ConsoleKey.LeftArrow:
                        if (select == 1)
                        {
                            Language--;
                            if (Language < 0) { Language = 2; }
                        }
                        else if (select == 0)
                        {
                            //size++;
                            //if(size < 0){size = 2;}
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (select == 1)
                        {
                            Language++;
                            if (Language > 2) { Language = 0; }

                        }
                        else if (select  == 0)
                        {
                            //size--
                            //if(size > 2) {Size = 0;}
                        }

                        break;
                }
            }



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
        void DrawText()
        {
            new Rusificator(Language).DrawTextSttings();
        }
        public void DrawLine()//Рисуе линию для выбора
        {
            Console.Write("************************");
        }

        public void DrawText_leng()
        {
            if (Language == 0)
            {
                Console.SetCursorPosition(30, 26);
                Console.Write(@"
                                                               _______ _   _  ______  
                                                              / / ____| \ | |/ ___\ \ 
                                                             / /|  _| |  \| | |  _ \ \
                                                             \ \| |___| |\  | |_| |/ /
                                                              \_\_____|_| \_|\____/_/ ");


            }
            else if (Language == 1)
            {
                Console.SetCursorPosition(55, 26);
                Console.Write(@"
                                                               ______  _   _ ____ __  
                                                              / /  _ \| | | / ___ \ \ 
                                                             / /| |_) | | | \___ \ \ \
                                                             \ \|  _ <| |_| |___)  / /
                                                              \_\_| \_\\___/|____ /_/ ");
              
            }
            else if (Language == 2)
            {
                Console.SetCursorPosition(55, 26);
                Console.Write(@"
                                                               ___   _   _        __  
                                                              / / | | | / \       \ \ 
                                                             / /| | | |/ _ \       \ \
                                                             \ \| |_| / ___ \      / /
                                                              \_\\___/_/   \_\    /_/ ");
                

            }
            DrawText();
            DrawBorder();

        }
         public int returnLanguage()
        {
            return Language;
        }

    }
}

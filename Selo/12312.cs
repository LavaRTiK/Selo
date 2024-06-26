﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selo
{
     class _12312
    {
        class Settings
        {
            private const int MapWidth = 30 * 3; //Резмер консольки по точкам В ширину  
            private const int MapHeight = 20 * 3; //Размер консоли по точкам В висоту запись (ширина,висота)
            private const ConsoleColor BorderColor = ConsoleColor.Gray;

            static int Language = 0;

            public void DrawSettings()
            {
                int select = 0;
                int selectcursor = 27;
                Console.SetCursorPosition(60, 26);
                Console.Write(@"
                                                               _______ _   _  ______  
                                                              / / ____| \ | |/ ___\ \ 
                                                             / /|  _| |  \| | |  _ \ \
                                                             \ \| |___| |\  | |_| |/ /
                                                              \_\_____|_| \_|\____/_/ ");
                DrawText();
                DrawBorder();
                Console.SetCursorPosition(10, selectcursor);
                DrawLine();
                bool selector = true;
                while (selector)
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
                                if (Language == 0)
                                {
                                    Console.SetCursorPosition(55, 26);
                                    Console.Write(@"
                                                               _______ _   _  ______  
                                                              / / ____| \ | |/ ___\ \ 
                                                             / /|  _| |  \| | |  _ \ \
                                                             \ \| |___| |\  | |_| |/ /
                                                              \_\_____|_| \_|\____/_/ ");
                                    DrawText();
                                    DrawBorder();

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
                                    DrawText();
                                    DrawBorder();

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
                                    DrawText();
                                    DrawBorder(); ;

                                }
                                DrawText();
                                DrawBorder();
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
                                Console.Clear();
                                if (Language == 0)
                                {
                                    Console.SetCursorPosition(55, 26);
                                    Console.Write(@"
                                                               _______ _   _  ______  
                                                              / / ____| \ | |/ ___\ \ 
                                                             / /|  _| |  \| | |  _ \ \
                                                             \ \| |___| |\  | |_| |/ /
                                                              \_\_____|_| \_|\____/_/ ");
                                    DrawText();
                                    DrawBorder();

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
                                    DrawText();
                                    DrawBorder();

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
                                    DrawText();
                                    DrawBorder(); ;

                                }
                                DrawText();
                                DrawBorder();
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
                                if (Language == 0)
                                {
                                    Console.SetCursorPosition(55, 26);
                                    Console.Write(@"
                                                               _______ _   _  ______  
                                                              / / ____| \ | |/ ___\ \ 
                                                             / /|  _| |  \| | |  _ \ \
                                                             \ \| |___| |\  | |_| |/ /
                                                              \_\_____|_| \_|\____/_/ ");
                                    DrawText();
                                    DrawBorder();
                                    Console.SetCursorPosition(10, 32);
                                    DrawLine();

                                }
                                if (Language > 0)
                                {
                                    Language--;
                                    if (Language == 0)
                                    {
                                        Console.SetCursorPosition(55, 26);
                                        Console.Write(@"
                                                               _______ _   _  ______  
                                                              / / ____| \ | |/ ___\ \ 
                                                             / /|  _| |  \| | |  _ \ \
                                                             \ \| |___| |\  | |_| |/ /
                                                              \_\_____|_| \_|\____/_/ ");
                                        DrawText();
                                        DrawBorder();
                                        Console.SetCursorPosition(10, 32);
                                        DrawLine();

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
                                        DrawText();
                                        DrawBorder();
                                        Console.SetCursorPosition(10, 32);
                                        DrawLine();

                                    }
                                    else if (Language == 2)
                                    {
                                        Console.SetCursorPosition(55, 26);
                                        Console.Write(@"
                                                              ___   _   _      __  
                                                             / / | | | / \     \ \ 
                                                            / /| | | |/ _ \     \ \
                                                            \ \| |_| / ___ \    / /
                                                             \_\\___/_/   \_\  /_/ ");
                                        DrawText();
                                        DrawBorder();
                                        Console.SetCursorPosition(10, 32);
                                        DrawLine();

                                    }
                                }
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (select == 1)
                            {
                                if (Language == 0)
                                {
                                    Console.SetCursorPosition(55, 26);
                                    Console.Write(@"
                                                               _______ _   _  ______  
                                                              / / ____| \ | |/ ___\ \ 
                                                             / /|  _| |  \| | |  _ \ \
                                                             \ \| |___| |\  | |_| |/ /
                                                              \_\_____|_| \_|\____/_/ ");
                                    DrawText();
                                    DrawBorder();
                                    Console.SetCursorPosition(10, 32);
                                    DrawLine();

                                }
                                if (Language < 2)
                                {
                                    Language++;
                                    if (Language == 0)
                                    {
                                        Console.SetCursorPosition(55, 26);
                                        Console.Write(@"
                                                               _______ _   _  ______  
                                                              / / ____| \ | |/ ___\ \ 
                                                             / /|  _| |  \| | |  _ \ \
                                                             \ \| |___| |\  | |_| |/ /
                                                              \_\_____|_| \_|\____/_/ ");
                                        DrawText();
                                        DrawBorder();
                                        Console.SetCursorPosition(10, 32);
                                        DrawLine();

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
                                        DrawText();
                                        DrawBorder();
                                        Console.SetCursorPosition(10, 32);
                                        DrawLine();

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
                                        DrawText();
                                        DrawBorder();
                                        Console.SetCursorPosition(10, 32);
                                        DrawLine();

                                    }
                                }
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
                Console.SetCursorPosition(10, 20);
                Console.Write(@"
            ____  _         
           / ___|(_)_______ 
           \___ \| |_  / _ \
            ___) | |/ /  __/
           |____/|_/___\___|
                                   ");
                Console.SetCursorPosition(10, 26);
                Console.Write(@"
            _                                             
           | |    __ _ _ __   __ _ _   _  __ _  __ _  ___ 
           | |   / _` | '_ \ / _` | | | |/ _` |/ _` |/ _ \
           | |__| (_| | | | | (_| | |_| | (_| | (_| |  __/
           |_____\__,_|_| |_|\__, |\__,_|\__,_|\__, |\___|
                             |___/             |___/      ");
                Console.SetCursorPosition(10, 32);
                Console.Write(@"
            __  __           _      
           |  \/  |_   _ ___(_) ___ 
           | |\/| | | | / __| |/ __|
           | |  | | |_| \__ \ | (__ 
           |_|  |_|\__,_|___/_|\___| dont work(sorry)
                                          ");
            }
            public void DrawLine()//Рисуе линию для выбора
            {
                Console.Write("************************");
            }
        }
    }
}

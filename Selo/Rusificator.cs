using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selo
{
    public class Rusificator
    {
        public int Language { get; set; }
        public Rusificator(int Language)
        {
            this.Language = Language;
        }

        public void DrawTextSttings()
        {
            Console.WriteLine(Language);
            if (Language == 0)
            {

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
            }
            else if (Language == 1)
            {
                {


                    {
                        Console.SetCursorPosition(10, 20);
                        Console.Write(@"
            ____                               
           |  _ \ __ _ _____ __ ___   ___ _ __ 
           | |_) / _` |_  / '_ ` _ \ / _ \ '__|
           |  _ < (_| |/ /| | | | | |  __/ |   
           |_| \_\__,_/___|_| |_| |_|\___|_|   
                                          ");
                        Console.SetCursorPosition(10, 26);
                        Console.Write(@"
           __   __              _    
           \ \ / /_ _ _____   _| | __
            \ V / _` |_  / | | | |/ /
             | | (_| |/ /| |_| |   < 
             |_|\__,_/___|\__, |_|\_\
                          |___/      
                                          ");
                        Console.SetCursorPosition(10, 32);
                        Console.Write(@"
            __  __                 _         
           |  \/  |_   _ _____   _| | ____ _ 
           | |\/| | | | |_  / | | | |/ / _` |
           | |  | | |_| |/ /| |_| |   < (_| |
           |_|  |_|\__,_/___|\__, |_|\_\__,_|
                              |___/      dont work(sorry)
                                          ");
                    }
                }


            }
            else if (Language == 2)
            {
                {


                    {
                        Console.SetCursorPosition(10, 20);
                        Console.Write(@"
            ____                    _      
           |  _ \ ___ _____ __ ___ (_)_ __ 
           | |_) / _ \_  / '_ ` _ \| | '__|
           |  _ < (_) / /| | | | | | | |   
           |_| \_\___/___|_| |_| |_|_|_|   
                                          ");
                        Console.SetCursorPosition(10, 26);
                        Console.Write(@"      
           __   __        _ _    
           \ \ / /_ _ ___(_) | __
            \ V / _` / __| | |/ /
             | | (_| \__ \ |   < 
             |_|\__,_|___/_|_|\_\
                                          ");
                        Console.SetCursorPosition(10, 32);
                        Console.Write(@"
            __  __                 _         
           |  \/  |_   _ _____   _| | ____ _ 
           | |\/| | | | |_  / | | | |/ / _` |
           | |  | | |_| |/ /| |_| |   < (_| |
           |_|  |_|\__,_/___|\__, |_|\_\__,_|
                              |___/      dont work(sorry)
                                          ");
                    }
                }
            }
        }
        public void DrawTextMenu()
        {
            if (Language == 0)
            {
                Console.SetCursorPosition(10, 20);
                Console.Write(@"
                                 ____  _             
                                |  _ \| | __ _ _   _ 
                                | |_) | |/ _` | | | |
                                |  __/| | (_| | |_| |
                                |_|   |_|\__,_|\__, |
                                                |___/ ");
                Console.SetCursorPosition(10, 26);
                Console.Write(@"
                          ____       _   _   _                 
                         / ___|  ___| |_| |_(_)_ __   __ _ ___ 
                         \___ \ / _ \ __| __| | '_ \ / _` / __|
                          ___) |  __/ |_| |_| | | | | (_| \__ \
                         |____/ \___|\__|\__|_|_| |_|\__, |___/
                                                     |___/      ");
                Console.SetCursorPosition(10, 32);
                Console.Write(@"
                                  _____      _ _   
                                 | ____|_  _(_) |_ 
                                 |  _| \ \/ / | __|
                                 | |___ >  <| | |_ 
                                 |_____/_/\_\_|\__|
                                                    ");

            }
            else if (Language == 1)
            {
                Console.SetCursorPosition(10, 20);
                Console.Write(@"
                              _   _                 _   _ 
                             | | | | __ _ _ __ __ _| |_( )
                             | | | |/ _` | '__/ _` | __|/ 
                             | |_| | (_| | | | (_| | |_   
                              \___/ \__, |_|  \__,_|\__|  
                                    |___/          ");
                Console.SetCursorPosition(10, 26);
                Console.Write(@"
                      _   _           _                   _          
                     | \ | | __ _ ___| |_ _ __ ___  _   _| | ___   _ 
                     |  \| |/ _` / __| __| '__/ _ \| | | | |/ / | | |
                     | |\  | (_| \__ \ |_| | | (_) | |_| |   <| |_| |
                     |_| \_|\__,_|___/\__|_|  \___/ \__,_|_|\_\\__,_|
                                                ");
                Console.SetCursorPosition(10, 32);
                Console.Write(@"
                             __     __                   _ 
                             \ \   / /   ___  _____   __| |
                              \ \ / / | | \ \/ / _ \ / _` |
                               \ V /| |_| |>  < (_) | (_| |
                                \_/  \__,_/_/\_\___/ \__,_|       
                                                 ");

            }
            else if (Language == 2)
            {
                Console.SetCursorPosition(10, 20);
                Console.Write(@"
                              ___                _   
                             |_ _|__ _ _ __ __ _| |_ 
                              | |/ _` | '__/ _` | __|
                              | | (_| | | | (_| | |_ 
                             |___\__, |_|  \__,_|\__|
                                 |___/                ");
                Console.SetCursorPosition(10, 26);
                Console.Write(@"
                        _   _           _             _    _  
                       | | | | __ _ ___| |_ _ __ ___ | | _(_) 
                       | |_| |/ _` / __| __| '__/ _ \| |/ / | 
                       |  _  | (_| \__ \ |_| | | (_) |   <| | 
                       |_| |_|\__,_|___/\__|_|  \___/|_|\_\_| 
                                                            ");
                Console.SetCursorPosition(10, 32);
                Console.Write(@"
                           __     ___               _ 
                           \ \   / (_)_  _____   __| |
                            \ \ / /| \ \/ / _ \ / _` |
                             \ V / | |>  < (_) | (_| |
                              \_/  |_/_/\_\___/ \__,_|
                                                    ");

            }
        }
        public void DrawLine()//Рисуе линию для выбора
        {
            Console.Write("************************");
        }
    }
}

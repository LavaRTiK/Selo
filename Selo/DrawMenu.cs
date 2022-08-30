using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selo
{
     class DrawMenu
    {
        public void DrawText()
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
        public void DrawLine()//Рисуе линию для выбора
        {
            Console.Write("************************");
        }

    }
}

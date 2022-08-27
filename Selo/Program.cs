using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selo
{

    class Program : Cards
    {
        private const int MapWidth = 30 * 3;
        private const int MapHeight = 20*3;
        private const ConsoleColor BorderColor = ConsoleColor.Gray;

        static void Main()
        {
            Console.SetWindowSize(MapWidth, MapHeight);
            Console.SetBufferSize(MapWidth, MapHeight);
            Console.Title = "BlackJack";
            Console.CursorVisible = true;
            //Тут должно быть заполниния игроков на поле (Имя,Денги)

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
                        PlayerDisplay();
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
                    }
                    player1.Sum = -1;
                    PlayerDisplay();
                    player1.Sum = 0;
                    player1.Start();
                }
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

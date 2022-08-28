using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selo
{
    class Player
    {
        #region Что нужно сделать
        /*Видача карти  начальные 2 потом добавлять по одной
         * оброботать 11 как 11 и 1 в случае перебора 
         * сделать отрисовку карт и цыфр для лушей орентации есть ли 11 и можно ли рисковать 
         * дабвать дилера 
         * прописать логику дилера по которой он будет брать карты 
         * дилер будет брать карты если у него менше 14 - 15 дальше шансом в 50 процентов он будет брать карту или пасовать 
         * Улучщить качество выдачи карт изпользовать схематику по шрифту и рисовки по сиволу 
         */
        #endregion
        private const int WithCards = 5;
        private const int HeightCards = 7;

        Random random = new Random();
        static int Count;
        static int Right = 0;
        public int Id { get; set; }
        public string Name {get;set;}
        public int Sum { get; set; }
        public int Money { get; set; }
        public int PravoTusa { get; set; }

        public Player(string Name, int Money)
        {
            if (String.IsNullOrWhiteSpace(Name))
            {
                this.Name = "Player";
            }
            else
            {
                this.Name = Name;
            }
            this.Money = Money;
            Count++;
            Id = Count;
        }
        public override string ToString()
        {
            return ($"Имя:{Name} Сумма{Sum}");
        }

        public void GetCards()
        {
            int a = random.Next(2, 12);
            if (a == 11)
            {
                PravoTusa++;
            }
            Sum = Sum + a;
            DrawCards(a);
        }

        public void Tus()
        {
            Sum = Sum - 10;
        }

        public int Start()
        {
            var a = random.Next(2, 12);
            //Console.WriteLine("Первая Карта" + a);
            var b = random.Next(2, 12);
            //Console.WriteLine("Вторая Карта" + b);
            this.Sum = a + b;
            if (a == 11 || b == 11)
            {
                PravoTusa++;
            }
            DrawCards(a, b);
            return this.Sum;
        }
        public void DrawCards(int a)
        {
            for (int i = 47+Right; i < 52+Right; i++)
            {
                new Pixel(i, 58, ConsoleColor.Gray).Draw(); //Первая карта бока
                new Pixel(i, 50, ConsoleColor.Gray).Draw();
            }

            for (int i = 51; i < 58; i++)
            {
                new Pixel(46+Right, i, ConsoleColor.Gray).Draw(); // Первая карта верх низ
                new Pixel(52+Right, i, ConsoleColor.Gray).Draw();
            }
            if (a == 11 || a == 10)
            {
                Console.SetCursorPosition(50+Right, 57);
                Console.Write(a);
                Console.SetCursorPosition(47+Right, 51);
                Console.Write(a);
            }
            else
            {
                Console.SetCursorPosition(51+Right, 57);
                Console.Write(a);
                Console.SetCursorPosition(47+Right, 51);
                Console.Write(a);
            }
            Right = Right + 8;




        }
        public void DrawCards(int a, int b)
        {
            //Console.SetCursorPosition(32, 58);
            for (int i = 31; i < 36; i++)
            {
                new Pixel(i, 58, ConsoleColor.Gray).Draw(); //Первая карта бока
                new Pixel(i, 50, ConsoleColor.Gray).Draw();
            }
            for (int i = 39; i < 44; i++)
            {
                new Pixel(i, 58, ConsoleColor.Gray).Draw(); //Вторая карта бока
                new Pixel(i, 50, ConsoleColor.Gray).Draw();
            }

            for (int i = 51; i < 58; i++)
            {
                new Pixel(30, i, ConsoleColor.Gray).Draw(); // Первая карта верх низ
                new Pixel(36, i, ConsoleColor.Gray).Draw();
            }
            for (int i = 51; i < 58; i++)
            {
                new Pixel(38, i, ConsoleColor.Gray).Draw(); // Вторая карта верх низ
                new Pixel(44, i, ConsoleColor.Gray).Draw();
            }
            if (a == 11 || a == 10)
            {
                Console.SetCursorPosition(34, 57);
                Console.Write(a);
                Console.SetCursorPosition(31, 51);
                Console.Write(a);
            }
            else
            {
                Console.SetCursorPosition(35, 57);
                Console.Write(a);
                Console.SetCursorPosition(31, 51);
                Console.Write(a);
            }
            if (b == 11 || b == 10)
            {
                Console.SetCursorPosition(42, 57);
                Console.Write(b);
                Console.SetCursorPosition(39, 51);
                Console.Write(b);
            }
            else
            {
                Console.SetCursorPosition(43, 57);
                Console.Write(b);
                Console.SetCursorPosition(39, 51);
                Console.Write(b);
            }
            Right = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selo
{
     class Player
    {
        Random random = new Random();
        static int Count; 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sum { get; set; }
        public int Money { get; set; }
        public int PravoTusa { get; set; }

        public Player(string Name, int Money)
        {
            this.Name = Name;
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
            int a=random.Next(2, 11);
            if( a == 11)
            {
                PravoTusa++;
            }
            Sum = Sum + a;
        }

        public void Tus()
        {
            Sum = Sum - 10;
        }

        public int Start()
        {
            var a = random.Next(2, 11);
            //Console.WriteLine("Первая Карта" + a);
            var b = random.Next(2, 11);
            //Console.WriteLine("Вторая Карта" + b);
            this.Sum = a + b;
            if (a == 11 || b == 11)
            {
                PravoTusa++;
            }
            return this.Sum;
        }
        
    }
}

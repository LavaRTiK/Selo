﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selo
{
    class Diler
    {
        Random random = new Random();
        public string Name { get; set; }
        public int Sum { get; set; }
        public int PravoTusa { get; set; }

        public Diler(string Name, int Sum)
        {
            this.Name = Name;
            this.Sum = Sum;
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
            return this.Sum;
        }
        public void RuleDiller()
        {
            if (Sum < 17)
            {
                GetCards();
            }
            
        }
    }
}

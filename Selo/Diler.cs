using System;
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
        
        public int[] cardsdiller { get; set; }

        public Diler()
        {

        }
        public override string ToString()
        {
            return ($"Имя:{Name} Сумма{Sum}");
        }

        public void DillerPlay()
        {

            Start();
            RuleDiller();
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
            while (Sum < 17) 
            {
                if(Sum == -1)
                {
                    return;
                }
                GetCards();
                if (Sum > 21 & PravoTusa == 0)
                {
                    Sum = -1;
                }
                else if (PravoTusa > 0)
                {
                    Tus();
                    PravoTusa--;
                }
                
            }
            
        }
    }
}

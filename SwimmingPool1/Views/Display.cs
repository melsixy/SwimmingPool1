using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingPool.Views
{
    public class Display
    {

        //свойства за обем и дебит на тръбите
        public double V
        {
            get;
            set;
        }
        public double P1
        {
            get;
            set;
        }
        public double P2
        {
            get;
            set;
        }
        public double H
        {
            get;
            set;
        }
        public double TotalWater
        {
            get;
            set;
        }
        public double PoolPercent
        {
            get;
            set;
        }
        public double P1Percent
        {
            get;
            set;
        }
        public double P2Percent
        {
            get;
            set;
        }
        public double Overflow
        {
            get;
            set;
        }

        // метод за въвеждане на данни от потребителя
        public void Input()
        {
            Console.Write("Колко е обема на басейна: ");
            this.V = double.Parse(Console.ReadLine());
            Console.Write("Колко е дебита на първата тръба:");
            this.P1 = double.Parse(Console.ReadLine());
            Console.Write("Колко е дебита на втората тръба:");
            this.P2 = double.Parse(Console.ReadLine());
            Console.Write("Часове в които работника отсъства:");
            this.H = double.Parse(Console.ReadLine());
        }

        // метод за изчисляване и показване на резултата
        public void Output()
        {
            // изчисляване на количеството вода от двете тръби
            if (this.TotalWater < V)
            {


                Console.WriteLine($"Басейнът е {this.PoolPercent:F2}% пълен. Тръба 1:{this.P1Percent:F2}%. Тръба 2:{this.P2Percent:F2}%.");
            }
            else
            {

                Console.WriteLine($"За {this.H} часа басейнът е прелял с {this.Overflow:F2} литра.");
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingPool.Models
{
    public class Pool
    {
        // Полета за обема на басейна и дебита на двете тръби
        public double Volume { get; set; }            // Обем на басейна в литри
        public double Pipe1FlowRate { get; set; }    // Дебит на първата тръба в литри на час
        public double Pipe2FlowRate { get; set; }    // Дебит на втората тръба в литри на час
        public double Hours { get; set; }          // Времето на отсъствие в часове
      
        public double TotalWater()
        {
            return Hours * Pipe1FlowRate + Hours * Pipe2FlowRate;
        }

    }
}

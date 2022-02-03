using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    struct Train
    {
        public string Destination { get; set; }
        public int TrainNumber { get; set; }
        public string DepartureTime { get; set; }

        public Train(string destination, int trainNumber, string departureTime)
        {
            Destination = destination;
            TrainNumber = trainNumber;
            DepartureTime = departureTime;
        }

        public override string ToString()
            => $"Поезд номер {TrainNumber}, до города {Destination}, время отправления {DepartureTime}";
    }
}

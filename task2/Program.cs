using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Введите данные о поезде в формате (город номер время), {0} из 8", i+1);
                string[] trainInfo = Console.ReadLine().Split(' ');
                trains[i].Destination = trainInfo[0];
                trains[i].TrainNumber = Convert.ToInt32(trainInfo[1]);
                trains[i].DepartureTime = trainInfo[2];
                }

            for (int i = 1; i < trains.Length; i++)
                for (int j = 0; j < trains.Length - i; j++)
                    if (trains[j].TrainNumber > trains[j + 1].TrainNumber)
                    {
                        var temp = trains[j];
                        trains[j] = trains[j + 1];
                        trains[j + 1] = temp;
                    }

            while (true)
            {
                Console.Write("Введите номер поезда: ");
                var number = Convert.ToInt32(Console.ReadLine());
                string result = null;
                for (int i = 0; i < trains.Length; i++)
                    if (trains[i].TrainNumber == number)
                        result = trains[i].ToString();
                if (result != null)
                    Console.WriteLine(result);
                else
                    Console.WriteLine("Нет данных о поезде");
            }
        }
    }
}

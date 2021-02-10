using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Crossroads
    {
        static void Main()
        {
            int greenDuration = int.Parse(Console.ReadLine());
            int windowDuration = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int carsPassed = 0;

            while (line != "END")
            {
                if (line == "green")
                {
                    int secondsLeft = greenDuration;
                    string car;

                    while (cars.Count > 0 && secondsLeft > 0)
                    {
                        car = cars.Peek();

                        if (car.Length <= secondsLeft)
                        {
                            car = cars.Dequeue();
                            carsPassed++;
                            secondsLeft -= car.Length;
                        }
                        else
                        {
                            if (car.Length <= secondsLeft + windowDuration)
                            {
                                cars.Dequeue();
                                carsPassed++;
                                secondsLeft = 0;
                            }
                            else
                            {
                                car = cars.Dequeue();
                                char ch = car[car.Length - secondsLeft - 1];
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {ch}.");
                                return;
                            }
                        }
                    }
                }
                else
                {
                    cars.Enqueue(line);
                }
                line = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
        }
    }
}

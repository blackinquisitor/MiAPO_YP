using System;
using ConsoleApp_YP.Functions;

namespace ConsoleApp_YP
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int variant;
            do
            {
                Console.WriteLine("Выберите функцию" +
                                  "\n1. Факториал\n2. Рисунок\n3. Сыграть в игру\n4. Выход");
                variant = Convert.ToInt32(Console.ReadLine());


                switch (variant)
                {
                    case 1:
                    {
                        Console.WriteLine("Введите число для факторила");
                        int digital = Convert.ToInt32(Console.ReadLine());
                        Factorial factorial = new Factorial(digital);
                        Factorial.Display();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Введите высоуту");
                        int sizeY = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите длину");
                        int sizeX = Convert.ToInt32(Console.ReadLine());
                        Image image = new Image(sizeY, sizeX); 
                        break;
                    }
                    case 3:
                    /*{
                        Game game = new Game();
                        break;
                    }*/
                    default:
                    {
                        Console.Clear();
                        running = false;
                        break;
                    }
                }
            } while (running);
        } 
    }
}
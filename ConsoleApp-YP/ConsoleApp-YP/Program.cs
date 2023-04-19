using System;

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
                        
                        break;
                    }
                    case 2:
                    {
                        Image image = new Image(); 
                        break;
                    }
                    case 3:
                    {
                        Game game = new Game();
                        break;
                    }
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
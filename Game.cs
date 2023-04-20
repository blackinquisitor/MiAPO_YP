namespace ConsoleApp_YP.Functions;

internal class Game
{
    private static int _randomNumber { get; set; }
    private static int _points { get; set; }

    public Game(int number)
    {
        Random random = new Random();
        _randomNumber = random.Next(1, 3);

        if (number == _randomNumber)
        {
            _points += 1;
            Console.WriteLine($"Вы выиграли!\nВаши очки: {_points}");
        }
        else if (number == 0)
        {
            _points = 0;
            Console.WriteLine("Вы вышли из игры, очки будут сбрешенны.");
        }
        else
        {
            _points = 0;
            Console.WriteLine($"Вы проиграли!\nВаши очки: {_points}");
        }
    }
}
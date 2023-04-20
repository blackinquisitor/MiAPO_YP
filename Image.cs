namespace ConsoleApp_YP.Functions;

internal class Image
{
    private static int _sizeX { get; set; }
    private static int _sizeY { get; set; }

    public Image(int sizeX, int sizeY)
    {
        _sizeX = sizeX;
        _sizeY = sizeY;
        for (int i = _sizeY; i > 0; i--)
        {
            for (int j = 0; j < _sizeX; j++)
            {
                Console.Write(".");
            }
            Console.Write("\n");
        }
    }
}

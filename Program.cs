namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            Draw(p1.x, p1.y, p1.sym);

            Point p2 = new();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            Draw(p1.x, p1.y, p1.sym);
            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Draw(x2, y2, sym2);
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);

        }
    }
}

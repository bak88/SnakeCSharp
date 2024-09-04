namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {


            HorizontalLine upLine = new(0, 78, 0, '+');
            HorizontalLine downLine = new(0, 78, 24, '+');
            VerticalLine leftLine = new(0, 0, 24, '+');
            VerticalLine rightLine = new(78, 0, 24, '+');

            upLine.DrawLine();
            downLine.DrawLine();
            leftLine.DrawLine();
            rightLine.DrawLine();

            Point p = new Point(4, 5, '*');
            Snake snake = new(p, 4, EnumDirection.RIGHT);
            snake.DrawLine();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            
        }


    }
}

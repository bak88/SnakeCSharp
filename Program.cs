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
        }

       
    }
}

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
            p1.Draw();

            Point p2 = new();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw(); 
            

            
        }

       
    }
}

namespace Exercises
{
    public class DrawPar
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
 
                //loop 
                for (int j = 0; j < 20; j++)
                {
                    Console.Write("*");
                }
 
                Console.WriteLine();
 
                //loop for spaces
                for (int l = 0; l <= i; l++)
                {
                    Console.Write("  ");
                }
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            DrawParallelogram();
        }
    }
}
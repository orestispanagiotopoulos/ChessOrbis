using System;

namespace SampleProgram
{
    public static class Program
    {
        public static void Main()
        {
            try 
            {
                Run();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                Console.WriteLine("Press any key ...");
                Console.ReadKey();
            }
        }

        private static void Run()
        {
            // var game = new Game();
            var game = new ComplexGame();

            game.Setup();
            game.Play(15);

            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    }
}
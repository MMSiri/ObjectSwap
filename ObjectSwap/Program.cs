using System;

namespace ObjectSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            Elephant intermediate;

            while (true)
            {
                Console.WriteLine("Press 1 for Lloyd | 2 for Lucinda | 3 to swap");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out int whoAmIChoice))
                {
                    Console.WriteLine("You chose a wrong option, pal. You knew what you were doing.");
                    Console.Write('\n');
                    if (QuitConsole(true)) return;
                }
                else
                {
                    if (whoAmIChoice == 1)
                    {
                        Console.WriteLine($"You pressed {whoAmIChoice}");
                        Console.WriteLine("Calling lloyd.WhoAmI()");
                        lloyd.WhoAmI();
                        Console.Write('\n');
                    }
                    if (whoAmIChoice == 2)
                    {
                        Console.WriteLine($"You pressed {whoAmIChoice}");
                        Console.WriteLine("Calling lucinda.WhoAmI()");
                        lucinda.WhoAmI();
                        Console.Write('\n');
                    }
                    if (whoAmIChoice == 3)
                    {
                        intermediate = lloyd;
                        lloyd = lucinda;
                        lucinda = intermediate;
                        Console.WriteLine("References successfully swapped.");
                        Console.Write('\n');
                    }
                    if (whoAmIChoice > 3)
                    {
                        Console.WriteLine("A number between 1 and 3 will do just fine, please.");
                        Console.Write('\n');
                    }
                    if (QuitConsole(true)) return;
                }
            }

        }

        public static bool QuitConsole(bool quit)
        {
            Console.WriteLine("Press Q to quit, any other key to continue");
            Console.Write('\n');
            char quitKeyChar = Console.ReadKey(true).KeyChar;
            if ((quitKeyChar == 'Q' || quitKeyChar == 'q')) return quit = true;
            else return quit = false;
        }
    }
}

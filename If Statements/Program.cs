namespace If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dyelm, noWater;
            int books, score;
            double first, second;

            //Simple Calculator
            Console.WriteLine("First number:");
            first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second number:");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($" {first} + {second} = {first+second}");
            Console.WriteLine();

            //Mini Quiz
            score = 0;
            Console.WriteLine("Quiz Time!");
            Console.WriteLine();
            Console.WriteLine("Fill in the blank");
            Console.WriteLine("Raccoons can crawl into holes and small as ____ inches");
            books = Convert.ToInt32(Console.ReadLine());
            if (books == 4)
                Console.WriteLine("Correct!");
                //score = (score + 1);
            else 
            {
                Console.WriteLine("Incorrect");
            }


            Console.WriteLine();
            Console.WriteLine("AAOTWYNTGATOYFNALTOYBTWCFBOYETIEWJASBAITTNNTBOBBAATDGBTGDWNDSGMOLBCATINIYITWTTIOTBYKTILYbdyelm?");
            dyelm = Console.ReadLine();
            if (dyelm.ToLower() == "huh?")
                Console.WriteLine("Correct!");
                //score = (score + 1);
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.WriteLine();
            Console.WriteLine("Which of the following doesn't have water in it?");
            Console.WriteLine("A. Fishbowl/Aquarium");
            Console.WriteLine("B. Orange");
            Console.WriteLine("C. Doughnut");
            Console.WriteLine("D. Glass of water");
            noWater = Console.ReadLine();
            if (noWater.ToLower() == "C" || noWater.ToLower() == "Dougnut" )
                Console.WriteLine("Correct!");
                //score = (score + 1);
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}

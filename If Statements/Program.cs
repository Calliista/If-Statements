namespace If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dyelm, noWater, bobColor;
            int inches, score, earthWeight;
            double first, second;

            //Space boxing
            Console.WriteLine("Space boxing");
            Console.WriteLine("Please enter your current earth weight:");
            earthWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I have information for the following planets:");
            Console.WriteLine("   1. Venus   2. Mars   3. Jupiter");
            Console.WriteLine("   1. Saturn   2. Uranus   3. Neptune");
            Console.WriteLine("Which planet are you visiting?:");
            Console.WriteLine();

            //Simple Calculator
            Console.WriteLine("First number:");
            Double.TryParse(Console.ReadLine(), out first);

            Console.WriteLine("Second number:");
            Double.TryParse(Console.ReadLine(), out second);

            Console.WriteLine($" {first} + {second} = {first+second}");
            Console.WriteLine();

            //Mini Quiz
            score = 0;
            Console.WriteLine("Quiz Time!");
            Console.WriteLine();
            Console.WriteLine("Fill in the blank");
            Console.WriteLine("Raccoons can crawl into holes and small as ____ inches");
            inches = Convert.ToInt32(Console.ReadLine());
            if (inches == 4)
                Console.WriteLine("Correct!");
                //score = (score + 1);
            else 
            {
                Console.WriteLine("Incorrect");
            }

            Console.WriteLine();
            Console.WriteLine("What color is Doodle Bob?");
            bobColor = Console.ReadLine();
            if (bobColor.ToLower() == "white")
                Console.WriteLine("Correct!");
            //score = (score + 1);
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.WriteLine();
            Console.WriteLine("AAOTWYNTGATOYFNALTOYBTWCFBOYETIEWJASBAITTNNTBOBBAATDGBTGDWNDSGMOLBCATINIYITWTTIOTBYKTILY!bdyelm?");
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
            Console.WriteLine("B. Lemonade");
            Console.WriteLine("C. Doughnut");
            Console.WriteLine("D. Glass of water");
            noWater = Console.ReadLine();
            if (noWater.ToLower() == "C" || noWater.ToLower() == "Doughnut" )
                Console.WriteLine("Correct!");
                //score = (score + 1);
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}

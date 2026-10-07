namespace If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dyelm, noWater, bobColor, planet;
            int inches, score, earthWeight;
            double first, second, venus, mars, jupiter, saturn, uranus, neptune;

            //Space boxing
            venus = 0.78;
            mars = 0.39;
            jupiter = 2.65;
            saturn = 1.17;
            uranus = 1.05;
            neptune = 1.23;
            Console.WriteLine("Space boxing");
            Console.WriteLine("Please enter your current earth weight:");
            earthWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I have information for the following planets:");
            Console.WriteLine("   Venus    Mars     Jupiter");
            Console.WriteLine("   Saturn   Uranus   Neptune");
            Console.WriteLine("Which planet are you visiting?:");
            planet = Console.ReadLine();
            if (planet.ToLower() == "venus")
                Console.WriteLine($"Your weight would be {earthWeight * venus} on that planet");
            if (planet.ToLower() == "mars")
                Console.WriteLine($"Your weight would be {earthWeight * mars} on that planet");
            if (planet.ToLower() == "jupiter")
                Console.WriteLine($"Your weight would be {earthWeight * jupiter} on that planet");
            if (planet.ToLower() == "saturn")
                Console.WriteLine($"Your weight would be {earthWeight * saturn} on that planet");
            if (planet.ToLower() == "uranus")
                Console.WriteLine($"Your weight would be {earthWeight * uranus} on that planet");
            if (planet.ToLower() == "neptune")
                Console.WriteLine($"Your weight would be {earthWeight * neptune} on that planet");
            else
            {
                Console.WriteLine("Wrong answer");
            }
            Console.WriteLine();

            //Simple Calculator
            Console.WriteLine("Simple Calculator");
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
            {
                Console.WriteLine("Correct!");
                score = (score + 1);
            }
                
            else 
            {
                if (inches >= 4)
                    Console.WriteLine("Incorrect. Hint: The answer is lower than " + inches);
                if (inches <= 4)
                    Console.WriteLine("Incorrect. Hint: The answer is higher than " + inches);
            }

            Console.WriteLine();
            Console.WriteLine("What color is Doodle Bob?");
            bobColor = Console.ReadLine();
            if (bobColor.ToLower() == "white")
            {
                Console.WriteLine("That's right!");
                score = (score + 1);
            }
            else
            {
                Console.WriteLine("Incorrect. Hint: Doodle Bob is like spongebob. But if he were white instead of yellow and drawn poorly");
            }

            Console.WriteLine();
            Console.WriteLine("AAOTWYNTGATOYFNALTOYBTWCFBOYETIEWJASBAITTNNTBOBBAATDGBTGDWNDSGMOLBCATINIYITWTTIOTBYKTILY!bdyelm?");
            dyelm = Console.ReadLine();
            if (dyelm.ToLower() == "yes")
            {
                Console.WriteLine("*chomp*");
            }
            if (dyelm.ToLower() == "huh?" || dyelm.ToLower() == "huh")
            {
                Console.WriteLine(">:(");
                score = (score + 1);
            }
            else
            {
                Console.WriteLine("(Wrong answer)");
            }

            Console.WriteLine();
            Console.WriteLine("Which of the following doesn't have water in it?");
            Console.WriteLine("A. Fishbowl/Aquarium");
            Console.WriteLine("B. Lemonade");
            Console.WriteLine("C. Doughnut");
            Console.WriteLine("D. Glass of water");
            noWater = Console.ReadLine();
            if (noWater.ToLower() == "c" || noWater.ToLower() == "doughnut")
            {
                Console.WriteLine("yes.");
                score = (score + 1);
            }
            else
            {
                Console.WriteLine("no, that has water in it.");
            }
            Console.WriteLine();
            if (score == 0)
            {
                Console.WriteLine("0/4 You didn't get any of the questions right! F-. 0.0%");
            }
            if (score == 4)
            {
                Console.WriteLine("4/4 Congrats! You answered them all correctly! 100.0 percent!");
            }
            else 
            {
                Console.WriteLine($"{score}/4 You answered {score} questions correctly! That's {(score / 4.0) * 100}%! "); 
            }
        }
    }
}

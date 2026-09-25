namespace If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dyelm;
            int books, score;

            score = 0;
            Console.WriteLine("Quiz Time!");
            Console.WriteLine("How many books are there in the Harry Potter series?: ");
            books = Convert.ToInt32(Console.ReadLine());
            if (books == 7)
                Console.WriteLine("Correct!");
                score = (score + 1);
            else {};
                Console.WriteLine("Incorrect");
            Console.WriteLine();
            Console.WriteLine("AAOTWYNTGATOYFNALTOYBTWCFBOYETIEWJASBAITTNNTBOBBAATDGBTGDWNDSGMOLBCATINIYITWTTIOTBYKTILY!bdyelm?");
            dyelm = Console.ReadLine();
            if (dyelm == "huh?");
                Console.WriteLine("Correct!");
                score = (score + 1);
        }
    }
}

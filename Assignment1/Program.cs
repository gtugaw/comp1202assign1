namespace Assignment1
{
    internal class Program
    {
        static void GetUserDetails()
        {
            Console.WriteLine("Please enter your course: ");
            string course = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
        }

        static void DisplayCongratulateScore(int currentScore)
        {
            Console.WriteLine("Congratulations you got it correct. SCORE: {0}",currentScore);
        }

        static void Main(string[] args)
        {
            GetUserDetails();
            DisplayCongratulateScore(99);
            Console.ReadKey();
        }
    }
}


//Course: COMP1202
//Name: TUGAWIN, GENESIS
//Student ID: 101579615

namespace Comp1202
{
    internal class Assignment01
    {
        static string GetUserName()
        {
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            return firstName + " " + lastName;
        }

        static string GetUserCourseCode()
        {
            Console.Write("Enter your course code: ");
            string courseCode = Console.ReadLine();
            return courseCode;
        }

        static void DisplayCongratsMessageScore(int currentScore)
        {
            Console.WriteLine("You got it correct! Current score: {0}", currentScore);
        }

        static void DisplayQuestion()
        {
            Random randomNumber = new Random();
            int randomQuestionNumber = randomNumber.Next(0, 3);

            switch (randomQuestionNumber)
            {
                case 1:
                    Console.WriteLine("Question No. {0}: What is the fastest land animal?", randomQuestionNumber);
                    Console.WriteLine("\tA. Lion\n\tB. Cheetah\n\tC. Greyahound\n\tD: Horse\n\tE. Kangaroo");
                    break;
                case 2:
                    Console.WriteLine("Question No. {0}: What planet in our solar system has the most moons?", randomQuestionNumber);
                    Console.WriteLine("\tA. Earth\n\tB. Mars\n\tC. Jupiter\n\tD: Saturn\n\tE. Neptune");
                    break;
                case 3:
                    Console.WriteLine("Question No. {0}: What is the national dish of Japan?", randomQuestionNumber);
                    Console.WriteLine("\tA. Sushi\n\tB. Ramen\n\tC. Tempura\n\tD: Curry Rice\n\tE. Okonomiyaki");
                    break;
                case 4:
                    Console.WriteLine("Question No. {0}: Which of these board games is based on buying and trading properties?", randomQuestionNumber);
                    Console.WriteLine("\tA. Chess\n\tB. Scrabble\n\tC. Monopoly\n\tD: Risk\n\tE. Clue");
                    break;
                default:
                    Console.WriteLine("No more questions available.");
                    break;
            }
        }

        static void DisplayProgressReport(string fullname, string courseCode, int attemptsQuestionOne, int attemptsQuestionTwo, int attemptsQuestionThree, int attemptsQuestionFour)
        {
            int maximumTotalPoints = 100;

            int totalScoredPoints = GetPoints(attemptsQuestionOne) +
                          GetPoints(attemptsQuestionTwo) +
                          GetPoints(attemptsQuestionThree) +
                          GetPoints(attemptsQuestionFour);



            Console.WriteLine("PROGRESS REPORT");
            Console.WriteLine("Name: {0}", fullname);
            Console.WriteLine("Course Code: {0}", courseCode);

            int questionNumber = 1;

            
            Console.WriteLine("Question 1: Attempts({0}), Points({1})", attemptsQuestionOne, GetPoints(attemptsQuestionOne));
            Console.WriteLine("Question 2: Attempts({0}), Points({1})", attemptsQuestionTwo, GetPoints(attemptsQuestionTwo));
            Console.WriteLine("Question 3: Attempts({0}), Points({1})", attemptsQuestionThree, GetPoints(attemptsQuestionThree));
            Console.WriteLine("Question 4: Attempts({0}), Points({1})", attemptsQuestionFour, GetPoints(attemptsQuestionFour));
            Console.WriteLine("Total points scored: {0}", totalScoredPoints);
            Console.WriteLine("Percentage score: {0:F2}%", totalScoredPoints * 100 / maximumTotalPoints);
        }

        static int GetPoints(int attempts)
        {
            switch (attempts)
            {
                case 1:
                    return 25;
                case 2:
                    return 15;
                case 3:
                    return 5;
                case 4:
                    return 0;
                default:
                    return 0;
            }
        }



        static void Main(string[] args)
        {
            string courseCode = "";
            string firstName = "";
            string lastname = "";
            string fullname = "";

            int firstQuestionAttempts = 1;
            int secondQuestionAttempts = 4;
            int thirdQuestionAttempts = 2;
            int fourthQuestionAttempts = 3;

            int totalScore = 0;
            double percentageScore = 0;



            fullname = GetUserName();
            courseCode = GetUserCourseCode();


            DisplayQuestion();
            DisplayCongratsMessageScore(99);

            DisplayProgressReport(fullname, courseCode,firstQuestionAttempts, secondQuestionAttempts, thirdQuestionAttempts, fourthQuestionAttempts);

            Console.ReadKey();
        }
    }
}


//Course: COMP1202
//Name: TUGAWIN, GENESIS
//Student ID: 101579615

namespace Assignment1
{
    internal class Program
    {
        static string GetUserName()
        {
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            return firstName + " " + lastName;
        }

        static string GetUserCourseCode()
        {
            Console.Write("Please enter your course: ");
            string courseCode = Console.ReadLine();
            return courseCode;
        }

        static void DisplayCongratulateScore(int currentScore)
        {
            Console.WriteLine("Congratulations you got it correct. SCORE: {0}", currentScore);
        }

        static void DisplayQuestion()
        {
            Random randomNumber = new Random();
            int randomQuestionNumber = randomNumber.Next(0, 3);

            switch (randomQuestionNumber)
            {
                case 1:
                    Console.WriteLine("Question 1: What is the capital of France?");
                    break;
                case 2:
                    Console.WriteLine("Question 2: What is the largest planet in our solar system?");
                    break;
                case 3:
                    Console.WriteLine("Question 3: Who wrote 'To Kill a Mockingbird'?");
                    break;
                case 4:
                    Console.WriteLine("Question 3: Who wrote 'To Kill a Mockingbird'?");
                    break;
                default:
                    Console.WriteLine("No more questions available.");
                    break;
            }
        }

        static void DisplayProgressReport(string fullname, string course, int attemptsQuestionOne, int attemptsQuestionTwo, int attemptsQuestionThree, int attemptsQuestionFour)
        {
            int maximumTotalPoints = 100;

            int totalScoredPoints = GetPoints(attemptsQuestionOne) +
                          GetPoints(attemptsQuestionTwo) +
                          GetPoints(attemptsQuestionThree) +
                          GetPoints(attemptsQuestionFour);



            Console.WriteLine("PROGRESS REPORT");
            Console.WriteLine("Name: {0}\tCourse Code: {1}", fullname, course);
            Console.WriteLine("Total points scored: {0} of {1}", totalScoredPoints, maximumTotalPoints);
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
            DisplayCongratulateScore(99);

            DisplayProgressReport(fullname, courseCode,firstQuestionAttempts, secondQuestionAttempts, thirdQuestionAttempts, fourthQuestionAttempts);

            Console.ReadKey();
        }
    }
}

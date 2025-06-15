
//Course: COMP1202
//Name: TUGAWIN, GENESIS
//Student ID: 101579615

namespace Comp1202
{
    internal class Assignment01
    {
        static void Main(string[] args)
        {
            //Prompt user for their course code
            Console.Write("Enter your course code: ");
            string courseCode = Console.ReadLine();

            //Prompt user for their last name and first name
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            int currentScore = 0;

            int attempts;

            string quizBreakDown = "";

            //Display question
            for (int questionNumber = 1; questionNumber <= 4; questionNumber++)
            {
                string correctAnswer = "";
                string userAnswer = "";
                attempts = 0; // Reset attempts for each question

                switch (questionNumber)
                {
                    case 1:
                        Console.WriteLine("Question No. {0}: What is the fastest land animal?", questionNumber);
                        Console.WriteLine("\tA. Lion\n\tB. Cheetah\n\tC. Greyahound\n\tD: Horse\n\tE. Kangaroo");
                        correctAnswer = "B"; // Cheetah is the correct answer
                        break;
                    case 2:
                        Console.WriteLine("Question No. {0}: What planet in our solar system has the most moons?", questionNumber);
                        Console.WriteLine("\tA. Earth\n\tB. Mars\n\tC. Jupiter\n\tD: Saturn\n\tE. Neptune");
                        correctAnswer = "C"; // Jupiter is the correct answer
                        break;
                    case 3:
                        Console.WriteLine("Question No. {0}: What is the national dish of Japan?", questionNumber);
                        Console.WriteLine("\tA. Sushi\n\tB. Ramen\n\tC. Tempura\n\tD: Curry Rice\n\tE. Okonomiyaki");
                        correctAnswer = "A"; // Sushi is the correct answer
                        break;
                    case 4:
                        Console.WriteLine("Question No. {0}: Which of these board games is based on buying and trading properties?", questionNumber);
                        Console.WriteLine("\tA. Chess\n\tB. Scrabble\n\tC. Monopoly\n\tD: Risk\n\tE. Clue");
                        correctAnswer = "C"; // Monopoly is the correct answer
                        break;
                    default:
                        Console.WriteLine("No more questions available.");
                        break;
                }

                bool answerNotCorrect = true;

                do
                {
                    //Prompt user for answer
                    if (attempts == 0)
                    {
                        Console.Write("(Attempt {0}) Enter your answer: ", attempts + 1);
                    }
                    else
                    { 
                        Console.Write("(Attempt {0}) Incorrect answer, please try again: ", attempts + 1);
                    }

                    userAnswer = Console.ReadLine();
                    answerNotCorrect = userAnswer != correctAnswer; // Check if the answer is correct
                    attempts++;
                }
                while (answerNotCorrect && attempts < 4); // Allow up to 4 attempts

                int questionPoints = 0; 

                //Get points based on attempts
                switch (attempts)
                {
                    case 1:
                        questionPoints = 25;  
                        break;
                    case 2:
                        questionPoints = 15;
                        break;
                    case 3:
                        questionPoints = 5;
                        break;
                    case 4:
                        questionPoints = 0;
                        break;
                    default:
                        questionPoints = 0;
                        break;
                }

                currentScore = currentScore + questionPoints;

                quizBreakDown = quizBreakDown + "Question No. " + questionNumber + ": No. of Attempts (" + attempts + "), Points (" + questionPoints + ")\n";

                //Display congrats message with current score
                if (answerNotCorrect == false)
                {
                    Console.WriteLine("Congratulations! you got it correct. You got {0} points and {1} total scored points.", questionPoints, currentScore);
                }
                else
                {
                    Console.WriteLine("Sorry wrong answer. Zero points and {0} total scored points.", currentScore);
                }
                
            }


            //Display progress report
            Console.WriteLine("\nPROGRESS REPORT");
            //Display user's full name and course code
            Console.WriteLine("Name: {0}, {1}", lastName, firstName);
            Console.WriteLine("Course Code: {0}", courseCode);
            //Display user's total score
            Console.WriteLine("\nTotal points scored: {0}", currentScore);
            Console.WriteLine("\nQuiz Breakdown:\n{0}", quizBreakDown);
            //Display user's percentage score
            Console.WriteLine("Percentage score: {0}%", currentScore * 100 / 100);
                        
            Console.ReadKey();
        }
    }
}

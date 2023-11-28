using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using LibraryMathGame.GameSettings;

namespace LibraryMathGame.Games
{
    public class MultiplicationGame
    {
        public static void StartMultiplicationGame()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\x1b[1mMultiplication Game\x1b[0m - Enter 'q' at any time to exit.");

            while (true)
            {
                int min, max;
                int numberOfQuestionsToPlay = 0;
                int correctAnswers = 0;
                List<string> generatedQuestions = new List<string>();
                List<string> userAnswers = new List<string>();
                List<int> expectedAnswers = new List<int>();

                // Choose difficulty level
                string difficulty = Difficulty.GetDifficultyLevel();
                if (difficulty == null)
                    return; // User is exited to the main menu

                // Choose the number of questions
                numberOfQuestionsToPlay = NumberOfQuestions.GetNumberOfQuestions();
                if (numberOfQuestionsToPlay == -1)
                {
                    return;
                }

                // Set min and max int range based on difficulty
                Difficulty.SetDifficultyRange(difficulty, out min, out max);

                correctAnswers = PlayGame.RunPlayGame(min, max, numberOfQuestionsToPlay, "Multiplication", generatedQuestions, userAnswers, expectedAnswers);

                // Record the game session
                GameSessionManager.RecordGameSession("Multiplication", difficulty, numberOfQuestionsToPlay, correctAnswers, generatedQuestions, userAnswers, expectedAnswers);

                if (!ContinueGame.AskToContinueGame())
                    return; // Exit subtraction game

            }
        }
    }
}


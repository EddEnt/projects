using LibraryMathGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class PastGameSessions
    {
        internal static void ViewPastGameSessions()
        {
            List<GameSessionManager.GameSession> pastSessions = GameSessionManager.GetPastGameSessions();
            Console.WriteLine("Past Game Sessions:");

            if (pastSessions.Count > 0)
            {
                foreach (var session in pastSessions)
                {
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                    Console.WriteLine($"Game Type: {session.GameType}, Difficulty: {session.Difficulty}, " +
                                      $"Questions Played: {session.Questions}, Correct Answers: {session.CorrectAnswers}");

                    Console.WriteLine("\nGenerated Questions and User Answers:");
                    for (int i = 0; i < session.GeneratedQuestions.Count; i++)
                    {
                        Console.WriteLine($"Question: {session.GeneratedQuestions[i]}");
                        Console.WriteLine($"User Answer: {session.UserAnswers[i]}");
                        Console.WriteLine($"Answer: {session.ExpectedAnswers[i]}");
                        Console.WriteLine("--------------------------");

                    }
                }
            }
            else
            {
                Console.WriteLine("No past game sessions to display.");
            }
        }
    }
}

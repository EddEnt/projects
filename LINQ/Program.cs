

int[] scores = [103, 24, 87, 66, 60, 18, 9, 156, 99, 71, 11, 4, 109];
string userNumberQuery;
int userNumberQueryParsed;
bool userNumberParseSuccess;

for (int i = 0; i < scores.Length; i++)
{
    Console.Write(scores[i] + " ");
    if (i == scores.Length - 1)
    {
        Console.WriteLine("\n");
    }
}

while (true)
{


    Console.Write("Please enter the number you want to filter above. Enter 'exit' to quit: ");
    userNumberQuery = Console.ReadLine();
    userNumberParseSuccess = int.TryParse(userNumberQuery, out userNumberQueryParsed);

    if (userNumberParseSuccess)
    {

        IEnumerable<int> scoreQuery =
            from score in scores
            where score >= userNumberQueryParsed
            select score;

        Console.WriteLine("--- LINQ Query ---");
        foreach (int score in scoreQuery)
        {
            Console.Write(score + ", ");

        }
        Console.WriteLine("\n------------------");

    }
    else if (userNumberQuery.ToLower() == "exit")
    {
        Environment.Exit(1);
    }
    else
    {
        Console.WriteLine("Invalid input, please enter a whole number.");
    }



}
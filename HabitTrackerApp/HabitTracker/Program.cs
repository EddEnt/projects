using Microsoft.Data.Sqlite;

string connectionStringHabits = "Data Source = drinking_water.db";

using (var connection = new SqliteConnection(connectionStringHabits))
{
    connection.Open();
    var tableCommand = connection.CreateCommand();

    tableCommand.CommandText = @"CREATE TABLE IF NOT EXISTS daily_water (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Date TEXT,
                                Quantity INTEGER
                                )";
    tableCommand.ExecuteNonQuery();

    connection.Close();
}

static void GetUserInput()
{
    Console.Clear();
    bool closeApp = false;
    while (closeApp == false)
    {
        Console.WriteLine("\nCRUD Options Program");
        Console.WriteLine("-------------------------");        
        Console.WriteLine("1 - View Records");
        Console.WriteLine("2 - Insert Record");
        Console.WriteLine("3 - Delete Record");
        Console.WriteLine("4 - Update Record");
        Console.WriteLine("Q - Quit");
        Console.WriteLine("-------------------------");

        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                //ViewAllRecords();
                break;
            case "2":
                //InsertRecord();
                break;
            case "3":
                //DeleteRecord();
                break;
            case "4":
               // UpdateRecord();
                break;
            case "q":
                Console.WriteLine("Exiting...");
                closeApp = true;
                break;
            default:
                Console.WriteLine("Unknown entry. Please enter another option...\n");
                break;

        }
    }
}


Console.WriteLine("Hello, World!");


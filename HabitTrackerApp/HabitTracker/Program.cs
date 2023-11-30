using Microsoft.Data.Sqlite;
using HabitTrackerLibrary;
using HabitTracker;

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

Menu.MainMenu();


Console.WriteLine("Hello, World!");


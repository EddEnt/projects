using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace HabitTrackerLibrary
{
    public class databaseMethods
    {

        static string connectionStringHabits = "Data Source = drinking_water.db";

        public static void DBCreate()
        {
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
        }

        public static void DBInsertRecord()
        {
            string date = API.Create.GetDateInput();
            int waterQuantity = API.Create.GetNumberInput("\nPlease insert the number of glasses or other measurment (No decimals allowed!)\n");

            using (var connection = new SqliteConnection(connectionStringHabits))
            {
                connection.Open();
                var tableCommand = connection.CreateCommand();
                tableCommand.CommandText = $"INSERT INTO daily_water(date, quantity) VALUES('{date}', {waterQuantity})";
                tableCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void DBViewAllRecords()
        {
            using (var connection = new SqliteConnection(connectionStringHabits))
            {
                connection.Open();
                var tableCommand = connection.CreateCommand();
                tableCommand.CommandText = $"SELECT * FROM daily_water ";

                List<DrinkingWater> tableData = new();

                SqliteDataReader tableDataReader = tableCommand.ExecuteReader();
                if (tableDataReader.HasRows)
                {
                    while (tableDataReader.Read())
                    {
                        tableData.Add(new DrinkingWater
                        {
                            id = tableDataReader.GetInt32(0),
                            Date = DateTime.ParseExact(tableDataReader.GetString(1), "dd-mm-yy", new CultureInfo("en-CA")),
                            Quantity = tableDataReader.GetInt32(2)
                        });
                    }
                }
                else
                {
                    Console.WriteLine("No rows found!");
                }
                connection.Close();
                Console.WriteLine("-----------------------------\n");
                foreach (var drinkingWater in tableData)
                {
                    Console.WriteLine($"{drinkingWater.id} - {drinkingWater.Date.ToString("dd-mm-yy")} - {drinkingWater.Quantity}");
                }
                Console.WriteLine("-----------------------------\n");

            }

        }

        public static void DBDeleteRecord()
        {
            Console.Clear();
            //To see a record they want to delete
            //This is not practical for larger datasets
            //DBViewAllRecords();

            var recordId = API.Create.GetNumberInput("\nPlease type the ID of the record you would like to delete.");

            using (var connection = new SqliteConnection(connectionStringHabits))
            {
                connection.Open();
                var tableCommand = connection.CreateCommand();
                tableCommand.CommandText = $"DELETE from daily_water WHERE Id = '{recordId}'";
                int rowCount = tableCommand.ExecuteNonQuery();

                if (rowCount == 0)
                {
                    Console.WriteLine($"\nRecord with ID {recordId} does not exist.");
                    DBDeleteRecord();
                }

            }

            Console.WriteLine($"\nRecord {recordId} was deleted.");

        }
    }
}



using System.Threading.Channels;

double num1 = 0;
double num2 = 0;

Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

Console.WriteLine("Type in a number, and then press Enter...");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Type in another number, and then press Enter...");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("\tq - Quit");
Console.Write("What operation would you like to perform?:  ");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2) );
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} x {num2} = " + (num1 * num2));
        break;
    case "d":
        while (num2 == 0)
        {
            Console.WriteLine("Enter a non-zero divisor: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
    case "q":
        Environment.ExitCode = 0;
        break;
}


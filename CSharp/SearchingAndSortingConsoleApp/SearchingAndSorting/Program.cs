using SearchingAndSorting;

string userInput = String.Empty;
int userNumber = 0;
bool userInputIsValid = false;
List<int> numbers = new();
numbers.Add(1);
numbers.Add(23);

Console.WriteLine("--- Searching and Sorting ---");
/*
Console.Write($"Current numbers in the List: ");
for (int i = 0; i < numbers.Count; i++)
{
    
    if(i != numbers.Count - 1)
    {
        Console.Write($"{numbers[i]}, ");
    }
    else
    {
        Console.Write($"{numbers[i]}");
    }
}
Console.WriteLine();

while (!userInputIsValid)
{
    Console.Write("Enter a number to add to our List: ");
    userInput = Console.ReadLine();
    userInputIsValid = int.TryParse(userInput, out userNumber);
    if(!userInputIsValid)
    {
        Console.WriteLine("Invalid input. Please enter a valid number...\n");
    }
    else
    {
        numbers.Add(userNumber);
    }

}
*/

BinarySearchTree tree = new();
tree.Insert(50);
tree.Insert(30);
tree.Insert(20);
tree.Insert(40);
tree.Insert(70);
tree.Insert(60);
tree.Insert(80);

Console.Write($"In-Order Traversal of the Binary Search Tree: ");
tree.InOrderTraversal();




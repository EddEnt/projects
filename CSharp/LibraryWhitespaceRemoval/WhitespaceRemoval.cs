using System.Linq;

namespace LibraryWhitespaceRemoval
{
    public class WhitespaceRemoval
    {
        public static void RemoveWhitespaceFromString()
        {
            Console.Clear();

            string userStringInput;
            string userStringModified;

            Console.WriteLine("Please enter the text you would like to modify. Text must be 5000 characters or less: ");
            userStringInput = Console.ReadLine();

            if (userStringInput.Length > 5000)
            {
                Console.WriteLine("Sorry, the text you entered is too long. Please limit it to 5000 characters or less.");
                return;
            }

            userStringModified = String.Concat(userStringInput.Where(c => !Char.IsWhiteSpace(c)));            

            Console.WriteLine($"Original: {userStringInput}\n\n");
            Console.WriteLine($"Modified: {userStringModified}");
        }
    }
}

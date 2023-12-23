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

            Console.WriteLine("Please enter the text you would like to modify: ");
            userStringInput = Console.ReadLine();

            userStringModified = String.Concat(userStringInput.Where(c => !Char.IsWhiteSpace(c)));            

            Console.WriteLine($"Original: {userStringInput}\n\n");
            Console.WriteLine($"Modified: {userStringModified}");
        }
    }
}

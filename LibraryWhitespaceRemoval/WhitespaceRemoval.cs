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
            //userStringModified = String.Concat(userStringInput.Where(c => !Char.IsWhiteSpace(c)).ToArray());

            Console.WriteLine($"Original: {userStringInput}");
            Console.WriteLine($"Modified: {userStringModified}");
        }
    }
}

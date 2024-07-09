namespace CSharp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file path: ");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                try
                {
                    string fileContent = File.ReadAllText(filePath);
                    Console.WriteLine("File content: ");
                    Console.WriteLine(fileContent);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
        }
    }
}

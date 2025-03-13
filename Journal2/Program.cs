using Journal2.Properties;

class Program
{

    static void Main(string[] args)
    {
        Journal journal2 = new Journal();
        char choice = '0';

        while (choice != '4')
        {
            journal2.HomeScreen();
            Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - New Entry");
            Console.WriteLine("2 - Search for a Entry");
            Console.WriteLine("3 - Delete Entry");
            Console.WriteLine("4 - Exit");
            choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case '1':
                    journal2.AddEntry();
                    break;
                case '2':
                    journal2.SearchEntry();
                    break;
                case '3':
                    journal2.DeleteEntries();
                    break;
                case '4':
                    Console.WriteLine("Press any key to end the Day");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.WriteLine();
        }
    }
}
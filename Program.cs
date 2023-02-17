namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            List<string> names = new List<string>{ "Trinity", "Neo", "Morpheus", "Smith", "Tank" };
            Console.WriteLine(names[1] + " is 'The One'.");
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.WriteLine(names[0]); // This prints out the first element
            Console.WriteLine("There are " + names.Count + " names in my array.");
            names[3] = "Agent Smith";
            Console.WriteLine(names[3] + " is the bad guy.");

            // Change the last name without hard coding an index number
            names[names.Count - 1] = "Cypher";
            Console.WriteLine(names[names.Count - 1] + " is another bad guy.");

            // Random Challenge
            Console.WriteLine();
            Console.WriteLine("Here is a random name:");
            Console.WriteLine(names[generator.Next(names.Count)]);
            Console.WriteLine();

            // Prints all elements no matter what the size of the array is
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(i + ". " + names[i]);
            }

            // Prints all elements without using a loop
            Console.WriteLine(string.Join(", ", names));
        }
    }
}
namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                var r = new Random();
                var favNumber = r.Next(1, 1000);

                Console.WriteLine("My favorite number is between 1 and 1000!!!!!!!!");

                while (true)
                {
                    var userInput = int.Parse(Console.ReadLine());

                    if (userInput < favNumber)
                    {
                        Console.WriteLine("Almost there but too low!!!!!!");
                    }
                    else if (userInput > favNumber)
                    {
                        Console.WriteLine("Almost there but too high.");
                    }
                    else
                    {
                        Console.WriteLine($"My favorite number is {favNumber}, thanks for playing.");
                        break;
                    }
                }
            }

        }
    }
}

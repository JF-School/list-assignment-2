using System.Runtime.ExceptionServices;

namespace list_assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int numCount, minValue, maxValue, numericValue, numPick;
            int zeroPick;
            int counter = 0;
            List<int> numbers = new List<int>();

            // pick numbers to put in list
            Console.Write("How many numbers do you want in your list? ");
            while ((!Int32.TryParse(Console.ReadLine(), out numCount)) || (numCount <= 0))
            {
                Console.WriteLine("Invalid input.");
                Console.Write("How many numbers do you want in your list? ");
            }

            // pick the minimum value
            Console.Write("Minimum value: ");
            while ((!Int32.TryParse(Console.ReadLine(), out minValue)) || (minValue < 0))
            {
                Console.WriteLine("Invalid input.");
                Console.Write("Minimum value: ");
            }

            // pick the maximum value
            Console.Write("Maximum value: ");
            while ((!Int32.TryParse(Console.ReadLine(), out maxValue)) || (maxValue <= minValue))
            {
                Console.WriteLine("Invalid input.");
                Console.Write("Maximum value: ");
            }

            // generate the random numbers
            for (int i = 0; i < numCount; i++)
            {
                numericValue = generator.Next(minValue, maxValue + 1);
                Console.Write((i + 1) + ": ");
                Console.Write(numericValue);
                Console.WriteLine();
                numbers.Add(numericValue);
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to Continue");
            Console.ReadLine();
            Console.Clear();

            // print list on one line
            Console.WriteLine("Let's print out the list of numbers on one line:");
            Console.WriteLine();
            for (int i = 0; i < numbers.Count; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
            Console.WriteLine();

            // pick a number to see how many of the same numbers there are
            Console.WriteLine("Pick a number greater than or equal to " + minValue + " and less than or equal to " + maxValue);
            Console.Write("Please pick a number: ");
            while ((!Int32.TryParse(Console.ReadLine(), out numPick)) || (numPick < minValue) || (numPick > maxValue))
            {
                Console.WriteLine("Invalid input");
                Console.Write("Please pick a number: ");
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == numPick)
                    counter++;
            }
            Console.WriteLine();
            Console.WriteLine("There are " + counter + " of the same numbers that you chose.");
            Console.WriteLine();

            // pick a number to then replace with zero
            Console.WriteLine("Pick another number, it can be the same one you chose or a different one.");
            Console.WriteLine("The number must be greater than or equal to " + minValue + " and less than or equal to " + maxValue);
            Console.Write("Pick a number: ");
            while ((!Int32.TryParse(Console.ReadLine(), out zeroPick)) || (zeroPick < minValue) || (zeroPick > maxValue))
            {
                Console.WriteLine("Invalid input");
                Console.Write("Pick a number: ");
            }
            Console.WriteLine();
            counter = 0;
            Console.WriteLine("Too bad.. so sad.");
            Console.WriteLine("All instances of " + zeroPick + " will be replaced with zero!");
            Console.WriteLine();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == zeroPick)
                {
                    numbers[i] = 0;
                    counter++;
                }
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("There are " + counter + " zeroes in that list.");
            Console.WriteLine("Why did you have to pick " + zeroPick + ".");
            Console.WriteLine();

            // list malfunctions and makes every number a zero
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = 0;
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("It seems that the list has malfunctioned.");
            Console.WriteLine("No worries as I will put new random numbers in the list.");
            Console.WriteLine("Press ENTER to Continue");
            Console.ReadLine();

            // new random numbers
            for (int i = 0; i < numCount; i++)
            {
                numbers[i] = generator.Next(minValue, maxValue + 1);
                Console.WriteLine((i+1) + ": " + numbers[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Now that we have new numbers, let's print the list again on one line!");

            // new list line
            for (int i = 0; i < numbers.Count; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();

            // ok bye
            Console.WriteLine();
            Console.WriteLine("Everything is good now and all the tests I wanted to run have been ran!");
            Console.WriteLine("Adios, amigo!");
            Console.ReadLine();
        }
    }
}

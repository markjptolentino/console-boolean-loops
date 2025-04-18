using System;

class Program
{
    static void Main()
    {
        // Boolean variable used for the while loop
        bool keepRunning = true;

        // Counter to demonstrate the while loop
        int counter = 0;

        // WHILE LOOP: Runs as long as 'keepRunning' is true
        while (keepRunning)
        {
            Console.WriteLine("While loop iteration: " + counter);

            // Once counter reaches 3, stop the loop by setting the boolean to false
            if (counter >= 3)
            {
                keepRunning = false;
            }

            // Increase counter by 1 in each loop
            counter++;
        }

        // Separator
        Console.WriteLine("\n---\n");

        // DO-WHILE LOOP: Guarantees at least one execution of the block
        int number;

        // Boolean comparison: Continue as long as user input is not 5
        do
        {
            Console.Write("Enter a number (enter 5 to exit): ");
            string input = Console.ReadLine();

            // Try to parse the input to an integer
            bool success = int.TryParse(input, out number);

            if (!success)
            {
                // Inform user of invalid input
                Console.WriteLine("Please enter a valid number.");
                number = 0; // Reset number so the loop continues
            }

        } while (number != 5); // Loop will continue until the user inputs 5

        Console.WriteLine("Exited do-while loop.");
    }
}

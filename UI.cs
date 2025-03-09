
namespace Architecture
// FILE: UI.cs
// PROJECT: Inventory Management System
// PROGRAMMER: Rachit Patel
// FIRST VERSION: 9/03/2025
// DESCRIPTION: 
//   This class handles user interaction by displaying messages 
//   and capturing input from the console.
{
    // CLASS: UI
    // Description: 
    //   Provides methods for displaying messages and getting user input 
    //   from the console.
    internal class UI
    {
        // METHOD: Display
        // DESCRIPTION: 
        //   Displays a message to the console.
        // PARAMETERS: 
        //   string message - The message to be displayed.
        // RETURNS: Void
        internal void Display(string message)
        {
            Console.WriteLine(message); // Print the message to the console
        }

        // METHOD: GetInput
        // DESCRIPTION: 
        //   Prompts the user for input and returns the entered value.
        // PARAMETERS: 
        //   string prompt - The message prompting the user for input.
        // RETURNS: 
        //   string - The user-provided input.
        internal string GetInput(string prompt)
        {
            Console.Write(prompt); // Display the prompt message
            return Console.ReadLine(); // Read and return user input
        }
    }
}

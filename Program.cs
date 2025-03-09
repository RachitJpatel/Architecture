
namespace Architecture
// FILE: Program.cs
// PROJECT: Inventory Management System
// PROGRAMMER: Rachit Patel
// FIRST VERSION: 3/09/2025
// DESCRIPTION: 
//   This is the main entry point of the Inventory Management System application.
//   It creates an instance of the InventoryApp class and runs the application.
{
    // CLASS: Program
    // DESCRIPTION: 
    //   This class contains the Main method, which serves as the entry point of the program.
    internal class Program
    {
        // METHOD: Main
        // DESCRIPTION: 
        //   The entry point of the program. It creates an instance of the InventoryApp
        //   and calls the Run method to start the application.
        static void Main()
        {
            InventoryApp app = new InventoryApp(); // Create a new instance of InventoryApp
            app.Run(); // Start the InventoryApp and execute the main logic
        }
    }
}

namespace Architecture
// FILE: InventoryApp.cs
// PROJECT: Inventory Management System
// PROGRAMMER: Rachit Patel
// FIRST VERSION: 9/03/2025
// DESCRIPTION: 
//   This class provides the main application logic for managing a game inventory. 
//   It allows users to load, save, add, remove, and update game stock.
{
    // CLASS: InventoryApp
    // Description: 
    //   Manages the inventory system by handling user interactions, 
    //   processing inventory changes, and interacting with repositories and utilities.
    internal class InventoryApp
    {
        // Repository instance to manage game inventory data
        private GameRepository repo = new GameRepository();

        // UI instance to handle user input and output
        private UI ui = new UI();

        // Utility instance for file operations
        private Utility util = new Utility();

        // METHOD: Run
        // DESCRIPTION: 
        //   Displays the menu and handles user input for inventory operations.
        internal void Run()
        {
            bool running = true; // Controls the menu loop

            while (running)
            {
                // Display menu options to the user
                ui.Display("\n1. Load Inventory");
                ui.Display("2. Save Inventory");
                ui.Display("3. Add Game");
                ui.Display("4. Remove Game");
                ui.Display("5. Increase Stock");
                ui.Display("6. Decrease Stock");
                ui.Display("7. Display Inventory");
                ui.Display("8. Exit");

                // Get user choice
                string choice = ui.GetInput("Choose an option: ");

                // Process user choice
                switch (choice)
                {
                    case "1":
                        // Load inventory from file
                        util.LoadGames(ui.GetInput("Enter file name: "), repo);
                        break;
                    case "2":
                        // Save inventory to file
                        util.SaveGames(ui.GetInput("Enter file name: "), repo);
                        break;
                    case "3":
                        // Add a new game to inventory
                        AddGame();
                        break;
                    case "4":
                        // Remove an existing game
                        RemoveGame();
                        break;
                    case "5":
                    case "6":
                        // Update stock (increase or decrease)
                        UpdateStock(int.Parse(choice));
                        break;
                    case "7":
                        // Display current inventory
                        DisplayInventory();
                        break;
                    case "8":
                        // Exit the program
                        running = false;
                        break;
                    default:
                        // Handle invalid input
                        ui.Display("Invalid choice.");
                        break;
                }
            }
        }

        // METHOD: AddGame
        // DESCRIPTION: 
        //   Prompts the user for game details and adds a new game to the repository.
        private void AddGame()
        {
            // Prompt user for game details
            string name = ui.GetInput("Enter game name: ");
            string manufacturer = ui.GetInput("Enter manufacturer: ");

            // Parse price input and ensure it's a valid decimal value
            decimal price = decimal.Parse(ui.GetInput("Enter price: "));

            // Parse stock input and ensure it's a valid integer
            int stock = int.Parse(ui.GetInput("Enter stock: "));

            // Add the game to the repository
            repo.AddGame(new Game(name, manufacturer, price, stock));
            ui.Display("Game added successfully.");
        }

        // METHOD: RemoveGame
        // DESCRIPTION: 
        //   Prompts the user for a game ID and removes the corresponding game from the repository.

        private void RemoveGame()
        {
            // Get Game ID from user
            int id = int.Parse(ui.GetInput("Enter Game ID to remove: "));

            // Remove game from repository
            repo.RemoveGame(id);
            ui.Display("Game removed successfully.");
        }

        // METHOD: UpdateStock
        // DESCRIPTION: 
        //   Updates the stock of a specified game based on user input.
        // PARAMETERS: 
        //   int option - Determines whether stock is increased or decreased (5 = increase, 6 = decrease).

        private void UpdateStock(int option)
        {
            // Get Game ID from user
            int id = int.Parse(ui.GetInput("Enter Game ID: "));

            // Find the game in the repository
            Game game = repo.FindGame(id);

            // Proceed only if the game exists
            if (game != null)
            {
                int change;

                // Determine whether to increase or decrease stock
                if (option == 5)
                {
                    change = 1; // Increase stock
                }
                else
                {
                    change = -1; // Decrease stock
                }

                // Update stock value
                game.Stock += change;
                ui.Display("Stock updated successfully.");
            }
            else
            {
                ui.Display("Game not found. Stock update failed.");
            }
        }

        // METHOD: DisplayInventory
        // DESCRIPTION: 
        //   Displays all games currently in the inventory with their details.
        private void DisplayInventory()
        {
            // Iterate over the games in the repository and display their details
            foreach (Game game in repo.GetGames())
            {
                ui.Display($"{game.GameID} - {game.Name} ({game.Manufacturer}) - ${game.Price} - Stock: {game.Stock}");
            }
        }
    }
}

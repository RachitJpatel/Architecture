
namespace Architecture
// FILE: Utility.cs
// PROJECT: Inventory Management System
// PROGRAMMER: Rachit Patel
// FIRST VERSION: 9/03/2025
// DESCRIPTION: 
//   This class provides utility functions for saving and loading game data 
//   to and from files using the DAL (Data Access Layer).
{
    // CLASS: Utility
    // Description: 
    //   Provides helper methods to save and load game inventory data 
    //   by interacting with the DAL (Data Access Layer).
    internal class Utility
    {
        // Data Access Layer instance to handle file operations
        private DAL dal = new DAL();

        // METHOD: SaveGames
        // DESCRIPTION: 
        //   Saves the current game inventory to a file.
        // PARAMETERS: 
        //   string fileName - The name of the file to save data to.
        //   GameRepository repo - The repository containing game inventory.
        internal void SaveGames(string fileName, GameRepository repo)
        {
            string content = ""; // String to store formatted game data

            // Iterate over all games in the repository and format them for saving
            foreach (Game game in repo.GetGames())
            {
                content += game.FileFormat() + "\n"; // Append game data with newline
            }

            // Check if file exists and confirm overwrite
            if (File.Exists(fileName))
            {
                Console.Write("File already exists. Overwrite? (Y/N): ");
                if (Console.ReadLine().ToUpper() != "Y")
                {
                    Console.WriteLine("Operation cancelled. Data was not saved.");
                    return; // Exit if user does not confirm overwrite
                }
            }

            // Proceed with file saving using DAL
            DAL dal = new DAL(); // Create a new instance of DAL
            dal.FileWrite(fileName, content); // Write data to file

            Console.WriteLine($"File '{fileName}' saved successfully."); // Confirm success
        }

        // METHOD: LoadGames
        // DESCRIPTION: 
        //   Loads game inventory data from a file and populates the repository.
        // PARAMETERS: 
        //   string fileName - The name of the file to load data from.
        //   GameRepository repo - The repository to populate with loaded data.
        internal void LoadGames(string fileName, GameRepository repo)
        {
            // Read file content using DAL
            string data = dal.FileRead(fileName);

            // If file is empty or does not exist, exit method
            if (string.IsNullOrEmpty(data)) return;

            // Clear existing game inventory before loading new data
            repo.GetGames().Clear();

            // Split file data into lines
            string[] lines = data.Split('\n');

            // Process each line and extract game information
            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line)) // Ensure line is not empty
                {
                    string[] parts = line.Split('|'); // Split line by delimiter '|'

                    // Create and add game object to repository
                    repo.AddGame(new Game(
                        int.Parse(parts[0]),
                        parts[1],
                        parts[2],
                        decimal.Parse(parts[3]),
                        int.Parse(parts[4])
                    ));
                }
            }
        }
    }
}

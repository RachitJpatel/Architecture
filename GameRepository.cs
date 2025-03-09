namespace Architecture
// FILE: GameRepository.cs
// PROJECT: Inventory Management System
// PROGRAMMER: Rachit Patel
// FIRST VERSION: 3/09/2025
// DESCRIPTION: 
//   This class manages a collection of game objects, providing methods 
//   to add, remove, find, and retrieve games.

{
    // CLASS: GameRepository
    // description: 
    //   Stores and manages game objects in a list, allowing operations such as 
    //   adding, removing, retrieving, and searching for games.
    internal class GameRepository
    {
        // List to store game objects
        private List<Game> games = new List<Game>();

        // METHOD: GetGames
        // DESCRIPTION: 
        //   Returns the list of all stored games.
        // PARAMETERS: None
        // RETURNS: 
        //   List<Game> - The list of games in the repository.
        internal List<Game> GetGames()
        {
            return games; // Return the list of games
        }

        // METHOD: AddGame
        // DESCRIPTION: 
        //   Adds a new game to the repository.
        // PARAMETERS: 
        //   Game game - The game object to be added.
    
        internal void AddGame(Game game)
        {
            games.Add(game); // Add game to the list
        }

        // METHOD: RemoveGame
        // DESCRIPTION: 
        //   Removes a game from the repository based on its ID.
        // PARAMETERS: 
        //   int id - The ID of the game to be removed.
        
        internal void RemoveGame(int id)
        {
            // Loop through the list to find the game with the given ID
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].GameID == id) // Check if game ID matches
                {
                    games.RemoveAt(i); // Remove the game from the list
                    Console.WriteLine("Game removed successfully.");
                    return; // Exit the method after removal
                }
            }
            Console.WriteLine("Game not found."); // Display error if game not found
        }

        // METHOD: FindGame
        // DESCRIPTION: 
        //   Searches for a game by ID and returns the game object if found.
        // PARAMETERS: 
        //   int id - The ID of the game to find.
        // RETURNS: 
        //   Game - The game object if found, otherwise null.
        internal Game FindGame(int id)
        {
            // Iterate through the list to find the game
            foreach (Game game in games)
            {
                if (game.GameID == id) // Check if game ID matches
                {
                    return game; // Return the game if found
                }
            }
            return null; // Return null if game not found
        }
    }
}

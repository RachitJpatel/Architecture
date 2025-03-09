
namespace Architecture
// FILE: Game.cs
// PROJECT: Inventory Management System
// PROGRAMMER: Rachit Patel
// FIRST VERSION: 3/09/2025
// DESCRIPTION: 
//   This class represents a game entity with properties such as 
//   ID, name, manufacturer, price, and stock. It includes methods 
//   for storing game data and formatting it for file storage.

{
    // CLASS: Game
    // Description: 
    //   Represents a game object with attributes like ID, name, manufacturer, 
    //   price, and stock. Provides functionality for managing game data.
    internal class Game
    {
        // Static variable to generate unique IDs for new games
        private static int nextID = 1;

        // Private instance variables for game properties
        private int gameID;
        private string name;
        private string manufacturer;
        private decimal price;
        private int stock;

        // PROPERTY: GameID
        // DESCRIPTION: 
        //   Gets the unique ID of the game.
        // RETURNS: int - The game ID.
        internal int GameID
        {
            get
            {
                return gameID;
            }
        }

        // PROPERTY: Name
        // DESCRIPTION: 
        //   Gets or sets the name of the game.
        // RETURNS: string - The name of the game.
        internal string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // PROPERTY: Manufacturer
        // DESCRIPTION: 
        //   Gets or sets the manufacturer of the game.
        // RETURNS: string - The manufacturer name.
        internal string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }

        // PROPERTY: Price
        // DESCRIPTION: 
        //   Gets or sets the price of the game.
        // RETURNS: decimal - The price of the game.
        internal decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        // PROPERTY: Stock
        // DESCRIPTION: 
        //   Gets or sets the stock quantity of the game.
        // RETURNS: int - The number of available units.
        internal int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                stock = value;
            }
        }

        // METHOD: Game (Constructor)
        // DESCRIPTION: 
        //   Initializes a new game object with a unique ID, name, manufacturer, 
        //   price, and stock quantity.
        // PARAMETERS: 
        //   string name - The name of the game.
        //   string Manufacturer - The manufacturer of the game.
        //   decimal Price - The price of the game.
        //   int Stock - The number of units in stock.

        internal Game(string name, string Manufacturer, decimal Price, int Stock)
        {
            gameID = nextID++; // Assign unique ID
            name = Name; // Assign name
            manufacturer = Manufacturer; // Assign manufacturer
            price = Price; // Assign price
            stock = Stock; // Assign stock quantity
        }

        // METHOD: Game (Constructor with ID)
        // DESCRIPTION: 
        //   Initializes a new game object with a specified ID (used for loading data).
        // PARAMETERS: 
        //   int id - The unique ID of the game.
        //   string Name - The name of the game.
        //   string Manufacturer - The manufacturer of the game.
        //   decimal Price - The price of the game.
        //   int Stock - The number of units in stock.

        internal Game(int id, string Name, string Manufacturer, decimal Price, int Stock)
        {
            gameID = id; // Assign specified ID
            name = Name; // Assign name
            manufacturer = Manufacturer; // Assign manufacturer
            price = Price; // Assign price
            stock = Stock; // Assign stock quantity
        }

        // METHOD: FileFormat
        // DESCRIPTION: 
        //   Formats the game data into a string for file storage.
        // RETURNS: 
        //   string - A formatted string containing game details separated by '|'.
        internal string FileFormat()
        {
            return $"{gameID}|{name}|{manufacturer}|{price}|{stock}";
        }
    }
}

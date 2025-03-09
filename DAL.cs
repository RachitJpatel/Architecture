namespace Architecture
// FILE: DAL.cs
// PROJECT: Inventory Management System
// PROGRAMMER: Rachit Patel
// FIRST VERSION: 9/03/2025
// DESCRIPTION: 
//   This class provides data access layer (DAL) functionality, 
//   including file read and write operations using FileStream.
{
    // CLASS: DAL
    // Description: 
    //   Handles file operations for reading and writing game data 
    //   using FileStream, StreamWriter, and StreamReader.
    internal class DAL
    {
        // FileStream object for handling file operations
        private FileStream file = null;

        // StreamWriter for writing data to a file
        private StreamWriter sw = null;

        // StreamReader for reading data from a file
        private StreamReader sr = null;

        // METHOD: FileWrite
        // DESCRIPTION: 
        //   Writes the given content to a file, overwriting it if it exists.
        // PARAMETERS: 
        //   string fileName - The name of the file to write to.
        //   string content - The content to be written to the file.

        internal void FileWrite(string fileName, string content)
        {
            try
            {
                // Open file for writing (overwrite mode)
                file = new FileStream(fileName, FileMode.Create);

                // Create a StreamWriter to write content to the file
                sw = new StreamWriter(file);
                sw.Write(content); // Write content to the file
            }
            catch (Exception e)
            {
                // Handle any file-related errors
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                // Ensure StreamWriter is closed properly
                if (sw != null) sw.Close();

                // Ensure FileStream is closed properly
                if (file != null) file.Close();
            }
        }

        // METHOD: FileRead
        // DESCRIPTION: 
        //   Reads and returns the content of a file.
        // PARAMETERS: 
        //   string fileName - The name of the file to read from.
        // RETURNS: 
        //   string - The content of the file as a string.
        internal string FileRead(string fileName)
        {
            string content = ""; // Variable to store file content

            try
            {
                // Open file for reading
                file = new FileStream(fileName, FileMode.Open);

                // Create a StreamReader to read content from the file
                sr = new StreamReader(file);
                content = sr.ReadToEnd(); // Read entire file content
            }
            catch (Exception e)
            {
                // Handle any file-related errors
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                // Ensure StreamReader is closed properly
                if (sr != null) sr.Close();

                // Ensure FileStream is closed properly
                if (file != null) file.Close();
            }

            return content; // Return the file content
        }
    }
}

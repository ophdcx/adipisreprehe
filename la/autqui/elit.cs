try
{
    // Attempt to read the folders here
    // ...
}
catch (Exception e)
{
    // If an error occurs, write the error message to the console
    Console.Error.WriteLine("An error occurred while reading folders.");
    Console.Error.WriteLine($"Error details: {e.Message}");

    // Optionally, log the stack trace for debugging purposes
    Console.Error.WriteLine(e.StackTrace);
}

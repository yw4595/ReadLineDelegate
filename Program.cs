using System;

delegate string ReadLineDelegate();

/// <summary>
/// Author: OpenAI
/// Purpose: Impersonates the Console.ReadLine() function using a delegate
/// Restrictions: None
/// </summary>
class Program
{
    /// <summary>
    /// Purpose: Implements the delegate function to return the result of Console.ReadLine()
    /// Restrictions: None
    /// </summary>
    static string MyReadLine()
    {
        return Console.ReadLine();
    }

    /// <summary>
    /// Purpose: Asks for user input and displays the result
    /// Restrictions: None
    /// </summary>
    static void Main(string[] args)
    {
        ReadLineDelegate readLine = new ReadLineDelegate(MyReadLine);

        Console.WriteLine("Please enter some text: ");
        string userInput = readLine();
        Console.WriteLine("You entered: " + userInput);
    }
}

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "HelloGitHubText.txt";
        string content = "This is a test file created by a C# program.";

        File.WriteAllText(fileName, content);

        Console.WriteLine($"File '{fileName}' created successfully!");
    }
}

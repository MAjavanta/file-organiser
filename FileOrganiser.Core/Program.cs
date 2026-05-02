using FileOrganiser.Core.UserInput;

var userInput = new ConsoleUserInput();
var inputPath = userInput.GetFilePath();
if (Directory.Exists(inputPath))
{
    Console.WriteLine($"Printing files from {inputPath}");
    var directoryInfo = new DirectoryInfo(inputPath);
    var files = directoryInfo.EnumerateFileSystemInfos();
    foreach (var file in files)
    {
        Console.WriteLine(file);
    }
}
else
{
    Console.WriteLine("The directory provided does not exist.");
}

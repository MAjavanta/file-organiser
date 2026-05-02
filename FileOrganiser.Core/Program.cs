using FileOrganiser.Core.UserInput;

var userInput = new ConsoleUserInput();
var inputPath = userInput.GetFilePath();
if (Directory.Exists(inputPath))
{
    Console.WriteLine($"Printing files from {inputPath}");
    // var files = Directory.EnumerateFiles(inputPath);
    var directoryInfo = new DirectoryInfo(inputPath);
    var files = directoryInfo.EnumerateFiles();
    foreach (var file in files)
    {
        Console.WriteLine(file.FullName);
        Directory.CreateDirectory($"{inputPath}\\{file.Extension[1..]}");
        File.Move(file.FullName, $"{inputPath}\\{file.Extension[1..]}\\{file.Name}");
        // Console.WriteLine($"{inputPath}\\{file.Extension[1..]}\\{file.Name}");
    }
}
else
{
    Console.WriteLine("The directory provided does not exist.");
}

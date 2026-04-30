Console.WriteLine("Welcome to File Organiser!");
string? inputPath;
Console.WriteLine("Please provide a directory path:");
while (true)
{
    inputPath = Console.ReadLine();
    if (inputPath is null || inputPath.Length == 0)
    {
        Console.WriteLine("Must provide a path");
        continue;
    }
    break;
}
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


using FileOrganiser.Core.UserInput;

var extensionMapping = new Dictionary<string, string>()
{
    {".jpg","Images"},
    {".png","Images"},
    {".txt","Writing"},
    {".docx","Writing"},
    {".doc","Writing"},
    {".exe","Applications"},
    {".ppt","Slideshow"},
    {".mp3","Songs"},
    {".mp4","Videos"},
    {".pdf","PDFs"},
    {".xlsx","Spreadsheets"}
};
var userInput = new ConsoleUserInput();
var inputPath = userInput.GetFilePath();
if (Directory.Exists(inputPath))
{
    var directoryInfo = new DirectoryInfo(inputPath);
    var files = directoryInfo.EnumerateFiles();
    foreach (var file in files)
    {
        var subdirectory = extensionMapping.TryGetValue(file.Extension, out var mappedSubdirectory)
            ? mappedSubdirectory
            : file.Extension[1..];
        var targetDir = Path.Combine(inputPath, subdirectory);
        Directory.CreateDirectory(targetDir);
        var targetFilePath = Path.Combine(targetDir, file.Name);
        File.Move(file.FullName, targetFilePath);
    }
}
else
{
    Console.WriteLine("The directory provided does not exist.");
}
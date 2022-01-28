using Newtonsoft.Json;

var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesTotalDir = Path.Combine(storesDirectory, "salesTotalsDir");
Directory.CreateDirectory(salesTotalDir);

// var salesFiles = FindFiles("stores");
var salesFiles = FindFiles(storesDirectory);

var salesTotal = CalculateSalesTotal(salesFiles);

var totalsFile = Path.Combine(salesTotalDir, "totals.txt");
File.AppendAllText(totalsFile, $"{salesTotal}{Environment.NewLine}");

// foreach (var file in salesFiles)
// {
//     Console.WriteLine(file);
// }

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        // if (file.EndsWith("sales.json"))
        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}

static double CalculateSalesTotal(IEnumerable<string> salesFiles)
{
    double salesTotal = 0;

    // READ FILES LOOP
    // Loop over each file path in salesFiles
    foreach (var file in salesFiles)
    {
        // Read the contents of the file
        string salesJson = File.ReadAllText(file);

        // Parse the contents as JSON
        SalesData? data = JsonConvert.DeserializeObject<SalesData?>(salesJson);

        // Add the amount found in the Total field to the salesTotal variable
        salesTotal += data?.Total ?? 0;
    }

    return salesTotal;
}

record SalesData(double Total);


// class Program
// {
//     static void Main()
//     {
//         IEnumerable<string> jsonFiles = Directory.EnumerateFiles("stores", "*.json", SearchOption.AllDirectories);
//         foreach (var file in jsonFiles)
//         {
//             Console.WriteLine(file);
//         }
//     }
// }

// =============================================================================

// Console.WriteLine(Directory.GetCurrentDirectory());
// string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
// Console.WriteLine(docPath);
// Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
// Console.WriteLine(Path.Combine("stores", "201"));
// Console.WriteLine(Path.GetExtension("sales.json"));
// Console.WriteLine(Path.GetFileNameWithoutExtension("sales.json"));
// var SLASH = Path.DirectorySeparatorChar;
// string fileName = $"stores{SLASH}201{SLASH}sales{SLASH}sales.json";
// FileInfo info = new FileInfo(fileName);
// var NEWLINE = Environment.NewLine;
// Console.WriteLine($"Full Name: {info.FullName}{NEWLINE}Directory: {info.Directory}{NEWLINE}Extension: {info.Extension}{NEWLINE}Create Date: {info.CreationTime}");

// var newDir = Path.Combine(storesDirectory, "201", "newDir");
// Directory.CreateDirectory(newDir);
// bool doesDirectoryExist = Directory.Exists(newDir);
// Console.WriteLine($"Does newDir exist? {doesDirectoryExist}");
// File.WriteAllText(Path.Combine(newDir, "greeting.txt"), "Hello World!");

// =============================================================================
/*
// class SalesTotal
// {
//     public double Total { get; set; }
// }

// var salesJson = File.ReadAllText($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");
// var salesData = Newtonsoft.Json.JsonConvert.DeserializeObject<SalesTotal>(salesJson);

// Console.WriteLine(salesData.Total);
*/

// =============================================================================
/*
// IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("stores");
// foreach (var dir in listOfDirectories)
// {
//     Console.WriteLine(dir);
// }
// Console.WriteLine("===========================");

// IEnumerable<string> files = Directory.EnumerateFiles("stores");
// foreach (var file in files)
// {
//     Console.WriteLine(file);
// }
// Console.WriteLine("===========================");

// IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles("stores", "*.txt", SearchOption.AllDirectories);
// foreach (var file in allFilesInAllFolders)
// {
//     Console.WriteLine(file);
// }
// Console.WriteLine("===========================");

// IEnumerable<string> jsonFiles = Directory.EnumerateFiles("stores", "*.json", SearchOption.AllDirectories);
// foreach (var jsonFile in jsonFiles)
// {
//     Console.WriteLine(jsonFile);
// }
// Console.WriteLine("===========================");
*/

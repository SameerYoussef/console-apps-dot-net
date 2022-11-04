/*

  Delete all files in a directory located within a user's home directory

*/
string rootFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Temp";
Console.WriteLine($"Deleting files from: {rootFolder}");
try
{
    Console.WriteLine("Result: " + File.Exists($"{rootFolder}\\xasdfgh.txt"));

    // Delete all files in a directory
    foreach (string file in Directory.GetFiles(rootFolder))
    {
        //File.Delete(file);
        Console.WriteLine($"{file} is deleted.");
    }
}
catch (IOException ioExp)
{
    Console.WriteLine($"ERROR: {ioExp.Message}");
}

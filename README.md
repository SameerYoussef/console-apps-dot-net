# console-apps-dot-net
Playground for experimenting with C#

## Print emojis to Windows 10 Powershell console
```
// Below required - otherwise emojis display as '?'
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Hello, World! ✌");
```

> Note: You may have to ensure you are using a font that supports emojis

## Creating a new project from the command line
```
$projectName = "DeleteFiles"
mkdir $projectName
cd $projectName
dotnet new console --framework net6.0
cd ..
```
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string sourcePath = @"c:\temp\file1.txt";
string targetPath = @"c:\temp\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);
}
catch (IOException e) 
{
    Console.WriteLine("An error occured");
    Console.WriteLine(e.Message);
}

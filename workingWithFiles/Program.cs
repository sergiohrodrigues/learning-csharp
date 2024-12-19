// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Globalization;
using System.IO.Pipes;
using workingWithFiles.Entities;

//string sourcePath = @"D:\file1.txt";
//string targetPath = @"D:\file2.txt";


//File, FileInfo e IOException
/*try
{
FileInfo fileInfo = new FileInfo(sourcePath);
fileInfo.CopyTo(targetPath);
string[] lines = File.ReadAllLines(sourcePath);
foreach (string line in lines)
{
    Console.WriteLine(line);
}
}
catch (IOException e) 
{
Console.WriteLine("An error occured");
Console.WriteLine(e.Message);
}*/



//FileStream e StreamReader
/*//FileStream fs = null;
StreamReader sr = null;

try
{
//fs = new FileStream(sourcePath, FileMode.Open);
//sr = new StreamReader(fs);
sr = File.OpenText(sourcePath);
while (!sr.EndOfStream)
{
    string line = sr.ReadLine();
    Console.WriteLine(line);
}
}
catch(IOException e)
{
Console.WriteLine("AN error accurred");
Console.WriteLine(e.Message);
}
finally
{
//if(fs != null) fs.Close();
if(sr != null) sr.Close();
}*/



//Using block
/*try
{
//using(FileStream fs = new FileStream(sourcePath, FileMode.Open))
//{
//    using(StreamReader sr = new StreamReader(fs))
using(StreamReader sr = File.OpenText(sourcePath))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
//}
}
catch (IOException e)
{
Console.WriteLine("AN error accurred");
Console.WriteLine(e.Message);
}*/



//StreamWriter
/*try
{
string[] lines = File.ReadAllLines(sourcePath);
using(StreamWriter sw = File.AppendText(targetPath))
{
    foreach(string line in lines)
    {
        sw.WriteLine(line.ToUpper());
    }
}
}
catch (IOException e)
{
Console.WriteLine("AN error accurred");
Console.WriteLine(e.Message);
}*/



//Directory, DirectoryInfo
/*var path = @"D:\myFolder";

try
{
var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
Console.WriteLine("FOLDERS:");
foreach (var f in folders)
{
    Console.WriteLine(f);
}

var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
Console.WriteLine("FILES:");
foreach (var f in files)
{
    Console.WriteLine(f);
}

Directory.CreateDirectory(path + @"\newFolder");
}
catch (IOException e) 
{
Console.WriteLine("An error occurred");
Console.WriteLine(e.Message);
}*/



//Path
/*string path = @"d:\myfolder\file1.txt";

Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
Console.WriteLine("PathSeparator: " + Path.PathSeparator);
Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
Console.WriteLine("GetFileName: " + Path.GetFileName(path));
Console.WriteLine("GetExtension: " + Path.GetExtension(path));
Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
Console.WriteLine("GetTempPath: " + Path.GetTempPath());*/



//Exercicios

Console.Write("Enter file full path: ");
string sourceFilePath = Console.ReadLine();

try
{
    string[] lines = File.ReadAllLines(sourceFilePath);

    string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
    string targetFolderPath = sourceFolderPath + @"\out";
    string targetFilePath = targetFolderPath + @"\summary.csv";

    Directory.CreateDirectory(targetFolderPath);

    using (StreamWriter sw = File.AppendText(targetFilePath))
    {
        foreach (string line in lines)
        {

            string[] fields = line.Split(',');
            string name = fields[0];
            double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
            int quantity = int.Parse(fields[2]);

            Product prod = new Product(name, price, quantity);

            sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
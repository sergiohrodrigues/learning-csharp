// See https://aka.ms/new-console-template for more information

using System.Collections;

string sourcePath = @"D:\file1.txt";
string targetPath = @"D:\file2.txt";


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

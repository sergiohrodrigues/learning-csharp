﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// TRY / CATCH
/*try
{
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());

    int result = n1 / n2;
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Division by zero not allowed");
} 
catch(FormatException e)
{
    Console.WriteLine("Format error! " + e.Message);
}*/



// FINALLY
/*FileStream fs = null;
try
{
    fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
    StreamReader sr = new StreamReader(fs);
    string line = sr.ReadLine();
    Console.WriteLine(line);
}
catch(FileNotFoundException e)
{
    Console.WriteLine(e.Message);
}
finally
{
    if (fs != null)
    {
        fs.Close();
    }
}*/



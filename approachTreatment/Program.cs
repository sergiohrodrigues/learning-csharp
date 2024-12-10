// See https://aka.ms/new-console-template for more information
using approachTreatment.Entities;
using approachTreatment.Entities.Exceptions;

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



// CRIANDO EXCEÇÕES PERSONALIZADAS #1
try
{
    Console.Write("Room number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation:");
    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);
}
catch (FormatException e)
{
    Console.WriteLine("Error in format: " + e.Message);
}
catch (DomainException e)
{
    Console.WriteLine("Error in reservation: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}
        
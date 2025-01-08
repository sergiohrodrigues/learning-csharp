namespace interfaces3.Devices
{
    internal class Printer : Device, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }
    }
}

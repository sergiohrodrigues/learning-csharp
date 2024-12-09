using System.Globalization;
using inheritanceAndPolymorphism.Entities_2;
using inheritanceAndPolymorphism.EntitiesExercice1;
using inheritanceAndPolymorphism.EntitiesExercice2;

//BusinessAccount account = new BusinessAccount(1080, "Bob Brown", 100.0, 500.0);

//Console.WriteLine(account.Balance);

//account.Balance = 200.0;

//Account acc = new Account(1001, "Alex", 0.0);
//BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

// UPCASTING
//Account acc1 = bacc;
//Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
//Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

// DOWNCASTING
//testar somente quando for necessario, (inseguro)


//BusinessAccount acc4 = (BusinessAccount)acc2;
//acc4.Loan(100.0);
//acc2.Loan(100.0);

//BusinessAccount acc5 = (BusinessAccount)acc3;
//if(acc3 is BusinessAccount)
//{
//    //BusinessAccount acc5 = (BusinessAccount)acc3;
//    BusinessAccount acc5 = acc3 as BusinessAccount;
//    acc5.Loan(200.0);
//    Console.WriteLine("Loan!");
//}

//if(acc3 is SavingsAccount)
//{
//    //BusinessAccount acc5 = (BusinessAccount)acc3;
//    //teste
//    SavingsAccount acc5 = acc3 as SavingsAccount;
//    acc5.UpdateBalance();
//    Console.WriteLine("Update!");
//}


//Sobreposições, palavra virtual, override e base
//Account acc1 = new Account(1001, "Alex", 500.0);
//Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

//acc1.WithDraw(10.0);
//acc2.WithDraw(10.0);

//Console.WriteLine(acc1.Balance);
//Console.WriteLine(acc2.Balance);



// EXERCICIO FICCAÇÃO #1

/*List<Employee> list = new List<Employee>();

Console.Write("Enter the number of employess: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee #{i} data:");
    Console.Write("Outsourced (y/n)? ");
    char emp = char.Parse(Console.ReadLine());

    if(emp != 'y' && emp != 'n')
    {
        Console.WriteLine("Por favor digite 'y' ou 'n'.");
        Console.Write($"Employee #{i} data: ");
        emp = char.Parse(Console.ReadLine());
    }

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePorHour = double.Parse(Console.ReadLine());
    if(emp == 'y')
    {
        Console.Write("Additional charge: ");
        double addCharge = double.Parse(Console.ReadLine());
        list.Add(new OutsourcedEmployee(name, hours, valuePorHour, addCharge));
    } else
    {
        list.Add(new Employee(name, hours, valuePorHour));
    }

}
    Console.WriteLine("PAYMENTS:");
    foreach(Employee e in list)
    {
        Console.WriteLine($"{e.Name} - $ {e.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
    }*/


// EXERCICIO FICCAÇÃO #2

List<Product> p = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    string prod = Console.ReadLine();
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if(prod == "c")
    {
        p.Add(new Product(name, price));
    } else if(prod == "i")
    {
        Console.Write("Customs fee: ");
        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        p.Add(new ImportedProduct(name, price, fee));
    } else if(prod == "u")
    {
        Console.Write("Manufacture Date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        p.Add(new UsedProduct(name, price, date));
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS: ");
foreach(Product i in p)
{
    Console.WriteLine(i.PriceTag());
}

Console.WriteLine("Oi");
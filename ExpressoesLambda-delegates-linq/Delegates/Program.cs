using Delegates.Services;

namespace Delegates;

delegate double BinaryNumericOperation(double n1, double n2);

class Program
{
    static void Main(string[] args)
    {
        // Delegates
        //     • https://docs.microsoft.com/en-us/dotnet/standard/delegates-lambdas
        //     • É uma referência (com type safety) para um ou mais métodos
        //     • É um tipo referência
        //     • Usos comuns:
        //     • Comunicação entre objetos de forma flexível e extensível (eventos / callbacks)
        //     • Parametrização de operações por métodos (programação funcional)
        
        // Delegates pré-definidos
        //     • Action
        //     • Func-Select
        //     • Predicate

        double a = 10;
        double b = 12;
        
        // BinaryNumericOperation op = CalculationService.Sum;
        //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
        BinaryNumericOperation op = CalculationService.Max;
        
        //double result = op.Invoke(a, b);
        double result = op(a, b);
        Console.WriteLine(result);
    }
}
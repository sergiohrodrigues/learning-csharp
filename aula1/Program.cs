using System.Globalization;

namespace Course {
    class Program {

        static void Main(string[] args) {

            /*Pessoa primeira, segunda;

            primeira = new Pessoa();
            segunda = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            primeira.nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeira.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            segunda.nome = Console.ReadLine();
            Console.Write("Idade: ");
            segunda.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (primeira.idade > segunda.idade) {
                Console.WriteLine("Pessoa mais velha: " + primeira.nome);
            } else {
                Console.WriteLine("Pessoa mais velha: " + segunda.nome);
            }*/

            /*Funcionario primeiro, segundo;

            primeiro = new Funcionario();
            segundo = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            primeiro.nome = Console.ReadLine();
            Console.Write("Salário: ");
            primeiro.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            segundo.nome = Console.ReadLine();
            Console.Write("Salário: ");
            segundo.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (primeiro.salario + segundo.salario) / 2.0;

            Console.WriteLine("Salário Médio: " + mediaSalario);*/

            /*Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY) {
                Console.WriteLine("Maior área: X");
            } else {
                Console.WriteLine("Maior área: Y");
            }*/

            /*Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionar ao estoque: ");
            int quantidadeASerInserida = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantidadeASerInserida);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidadeASerInserida = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantidadeASerInserida);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);*/

            /*Retangulo ret = new Retangulo();
            Console.WriteLine("Entre a largura e a altura do retângulo: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Largura = valor;
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = valor;
            Console.WriteLine(ret);*/

            /*Funcionario func = new Funcionario();
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(func);

            Console.WriteLine();
            Console.Write("Digite a porcetagem para aumenta o salário: ");
            func.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(func);*/

            /*Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(aluno);*/

            /*Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Cirfunfêrência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));*/

            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ConversorDeMoeda.DolarAtual = cotacaoDolar;
            
            Console.Write("Quantos dólares você vai comprar? ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.ConverterDolarEmReal(valor).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

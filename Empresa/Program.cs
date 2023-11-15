using Empresa.Classes;
using System.Collections.Generic ;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionarios func = new Funcionarios();

        Console.Write("Entre comm o numero de funcionarios: ");
        int numfuncionario = int.Parse(Console.ReadLine());

        for (int i = 0; i < numfuncionario; i++)
        {

            Console.WriteLine("FUNCIONARIO " + i);
            Console.Write("é tercerizado? (S/N) ");
            char opcao = char.Parse(Console.ReadLine());

            if (opcao == 's')
            {
                Console.Write("NOME:");
                string nome = Console.ReadLine();

                Console.Write("HORAS:");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("VALOR HORA:");
                double valorhora = double.Parse(Console.ReadLine());

                Console.Write("DESPESA ADICIONAL:");
                double despadicional = double.Parse(Console.ReadLine());


                func = new FuncionariosTerc(nome, horas, valorhora, despadicional);

                double pagamento = horas + valorhora + despadicional;

                func.Pagamento();
            }
            else
            {
                Console.Write("NOME:");
                string nome = Console.ReadLine();

                Console.Write("HORAS:");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("VALOR HORA:");
                double valorhora = double.Parse(Console.ReadLine());

                func = new Funcionarios(nome, horas, valorhora);
                func.Pagamento();

            }
        }

        Console.WriteLine("PAGAMENTOS");

        Console.WriteLine(func.Pagamento);
        Console.WriteLine("PAGAMENTOS");
        Console.WriteLine("PAGAMENTOS");



    }
}
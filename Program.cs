using System;
using System.Globalization;

namespace Calculo_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero do funcionario: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de horas trabalhadas?");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor que recebe por hora?");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valorHora;
            Console.WriteLine("Salario = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

/* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
decimais */

using System.Globalization;

int numero, horasTrablhadas;
double salarioPorHora, salario;

Console.WriteLine("Informe o número do funcionário :");
numero = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o número de horas trabalhadas :");
horasTrablhadas = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor recebido por hora :");
salarioPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

salario = horasTrablhadas * salarioPorHora;

Console.WriteLine("Número do Funcionário : " + numero);
Console.WriteLine("Salário = R$" + salario.ToString("F2", CultureInfo.InvariantCulture));
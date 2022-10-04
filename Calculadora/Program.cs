using System;
using ExemplosFundamentos.Models;

Calculadora calc = new Calculadora();

Console.WriteLine("SOMA");
Console.Write("Digite o primeiro número: ");
int primeiroNumero = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int segundoNumero = int.Parse(Console.ReadLine());

calc.Somar(primeiroNumero, segundoNumero);

Console.WriteLine();

Console.WriteLine("Subtração");
Console.Write("Digite o primeiro número: ");
primeiroNumero = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
segundoNumero = int.Parse(Console.ReadLine());

calc.Subtrair(primeiroNumero, segundoNumero);

Console.WriteLine();

Console.WriteLine("Multiplicação");
Console.Write("Digite o primeiro número: ");
primeiroNumero = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
segundoNumero = int.Parse(Console.ReadLine());

calc.Multiplicar(primeiroNumero, segundoNumero);

Console.WriteLine();

Console.WriteLine("Divisão");
Console.Write("Digite o primeiro número: ");
primeiroNumero = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
segundoNumero = int.Parse(Console.ReadLine());

calc.Dividir(primeiroNumero, segundoNumero);

Console.WriteLine();

Console.WriteLine("Resto da divisão");
Console.Write("Digite o primeiro número: ");
primeiroNumero = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
segundoNumero = int.Parse(Console.ReadLine());

calc.Resto(primeiroNumero, segundoNumero);

Console.WriteLine();

Console.WriteLine("Potenciação");
Console.Write("Digite o número: ");
primeiroNumero = int.Parse(Console.ReadLine());

Console.Write("Digite o elevado do primeiro número: ");
segundoNumero = int.Parse(Console.ReadLine());

calc.Potencia(primeiroNumero, segundoNumero);

Console.WriteLine("CALCULANDO VALORES DO TRIANGULO");

Console.WriteLine("Seno");
Console.Write("Digite o valor do angulo: ");
primeiroNumero = int.Parse(Console.ReadLine());
calc.Seno(primeiroNumero);

Console.WriteLine();
Console.WriteLine("Coseno");
Console.Write("Digite o valor do angulo: ");
primeiroNumero = int.Parse(Console.ReadLine());
calc.Coseno(primeiroNumero);

Console.WriteLine();
Console.WriteLine("Tangente");
Console.Write("Digite o valor do angulo: ");
primeiroNumero = int.Parse(Console.ReadLine());
calc.Tangente(primeiroNumero);

Console.WriteLine();

Console.WriteLine("INCREMENTANDO E DECREMENTANDO NÚMEROS");
Console.Write("Digite o número que será incrementado: ");
primeiroNumero = int.Parse(Console.ReadLine());
primeiroNumero++;
Console.WriteLine($"O número digitado foi incrementado para: {primeiroNumero}");

Console.WriteLine();

Console.Write("Digite o número que será decrementado: ");
primeiroNumero = int.Parse(Console.ReadLine());
primeiroNumero--;
Console.WriteLine($"O número digitado foi decrementado para: {primeiroNumero}");


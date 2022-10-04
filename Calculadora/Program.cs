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



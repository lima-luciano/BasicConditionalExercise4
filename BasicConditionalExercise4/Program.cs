// 20) Desenvolva um programa que leia um número inteiro e mostre se ele é PAR ou ÍMPAR.

Console.WriteLine("Saiba se um numero é PAR ou IMPAR. \nDigite um numero:");

int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"O numero {number} é PAR");
}
else
{
    Console.WriteLine($"O numero {number} é IMPAR");
}
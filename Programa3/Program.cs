// Exercicio 3;
Console.Write("Digite um numero inteiro:");

var primeiroNumero =int.Parse(Console.ReadLine());

Console.Write("Digite outro numero inteiro:");

var segundoNumero = int.Parse(Console.ReadLine());

Console.WriteLine($"O valor da soma desses dois numeros é {primeiroNumero + segundoNumero}");

Console.WriteLine($"O valor da subtração desses dois numeros é {primeiroNumero - segundoNumero}");

Console.WriteLine($"O valor da multiplicação desses dois numeros é {primeiroNumero * segundoNumero}");

if (segundoNumero != 0)
{
    Console.WriteLine($"O valor da divisão desses dois numeros é {primeiroNumero / segundoNumero}");
}
else
{
    Console.WriteLine("Divisão por zero não é permitida.");
}

Console.WriteLine($"O valor da media  desses dois numeros é {(primeiroNumero + segundoNumero) / 2}");

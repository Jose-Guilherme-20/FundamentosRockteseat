//Programa 5
Console.Write("Digite a placa do veiculo:");

var placa = Console.ReadLine();

bool plavaValida = placa.Length == 7 && 
    char.IsLetter(placa[0]) && 
    char.IsLetter(placa[1]) && 
    char.IsLetter(placa[2]) && 
    char.IsDigit(placa[3]) && 
    char.IsDigit(placa[4]) && 
    char.IsDigit(placa[5]) && 
    char.IsDigit(placa[6]);

Console.WriteLine($"A placa digitada foi {placa} a placa é {(plavaValida ? "verdadeira": "falsa")}");
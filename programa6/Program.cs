//Programa 6

Console.WriteLine($"Data formato completo: {DateTime.Now}");

Console.WriteLine($"Data formato curto: {DateTime.Now.ToShortDateString()}");

Console.WriteLine($"Data apenas horas: {DateTime.Now.Hour} horas");

Console.WriteLine($"Data mês por extenso: {DateTime.Now.ToString("dd/MMMM/yyyy")}");
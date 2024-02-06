//criar dicionário de carros e quantidade de vendas
Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    {"Bugatti Veyron", new List<int>{ 10, 15, 12, 8, 5}},
    {"Koenigsegg Agera RS", new List<int>{2, 3, 5, 6, 7}},
    {"Lamborghini Aventador", new List<int>{20, 18, 22, 24, 16}},
    {"Pagani Huayra", new List<int>{4, 5, 6, 5, 4}},
    {"Ferrari LaFerrari", new List<int>{7, 6, 5, 8, 10}}
};

string car;

Console.Write("Informe o nome do carro que deseja consultar: ");
car = Console.ReadLine()!;

while (!carroExiste(car))
{
    Console.Write("\nCarro não encontrado! Tente novamente ou digite -1 para sair: ");
    car = Console.ReadLine()!;

    if(car.Equals("-1"))
    {
        Console.WriteLine("Saindo...");
        break;    
    }
}

if(car != "-1")
{
    Console.WriteLine($"\nMédia de carros {car} vendidos por ano: {vendasCarros[car].Average()}");

}
Boolean carroExiste(string car)
{
    if (vendasCarros.ContainsKey(car))
    {
        return true;
    }

    return false;
}
using GeanCarlosRamosOliveira;
using System.Reflection;
using System.Text.RegularExpressions;
using System;

public class Carro : Veiculo
{
    public int NumPortas { get;private set; }
    public bool ArCondicionado { get;private set; }

    public Carro(string placa, string marca, string modelo, double valorLocacao, Categoria categoria, int numPortas, bool arCondicionado)
        : base(placa, marca, modelo, valorLocacao, categoria)
    {
        NumPortas = numPortas;
        ArCondicionado = arCondicionado;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Carro: {Marca} {Modelo}, {NumPortas} Portas, Ar-Condicionado: {ArCondicionado}, Placa: {Placa}, Categoria: {Categoria.Nome}, Diária: R${ValorLocacao:F2}, Disponível: {Disponivel}");
    }
}

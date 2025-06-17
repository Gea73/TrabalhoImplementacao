using GeanCarlosRamosOliveira;
using System.Reflection;
using System.Text.RegularExpressions;
using System;

public class Carro : Veiculo
{
    private int _numPortas;
    public int NumPortas
    {
        get { return _numPortas; }
        set { _numPortas = value; }
    }

    private bool _arCondicionado;
    public bool ArCondicionado
    {
        get { return _arCondicionado; }
        set { _arCondicionado = value; }
    }

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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeanCarlosRamosOliveira
{
    public class GravaArquivoCSV
    {
    }
    public void GravaArquivoCategorias(string arquivo, CadCategorias cadCategoria)
    {
        Categoria categoria;
        string linha;
        try
        {
            using (StreamWriter sw = new StreamWriter(arquivo))
                for (int i = 0; i < cadCategoria; i++) // Laço para percorrer todos os dados cadastrados (todos os vendedores cadastrados)
                {
                    vendedor = cadVendedor.GetVendedor(i); //Obtém cada um dos vendedores cadastrados
                    linha = vendedor.Codigo + ";" + vendedor.Nome + ";" + vendedor.Cidade + ";" + vendedor.Vendas;
                    sw.WriteLine(linha); //grava a string linha no arquivo
                }
        }
        catch (Exception ex)
        {

        }
    }

    public void GravaArquivoVeiculos(string arquivo, CadCategorias cadCategoria)
    {
        Categoria categoria;
        string linha;
        try
        {
            using (StreamWriter sw = new StreamWriter(arquivo))
                for (int i = 0; i < cadCategoria; i++) // Laço para percorrer todos os dados cadastrados (todos os vendedores cadastrados)
                {
                    vendedor = cadVendedor.GetVendedor(i); //Obtém cada um dos vendedores cadastrados
                    linha = vendedor.Codigo + ";" + vendedor.Nome + ";" + vendedor.Cidade + ";" + vendedor.Vendas;
                    sw.WriteLine(linha); //grava a string linha no arquivo
                }
        }
        catch (Exception ex)
        {

        }
    }
    public void GravaArquivoLocacoes(string arquivo, CadCategorias cadCategoria)
    {
        Categoria categoria;
        string linha;
        try
        {
            using (StreamWriter sw = new StreamWriter(arquivo))
                for (int i = 0; i < cadCategoria; i++) // Laço para percorrer todos os dados cadastrados (todos os vendedores cadastrados)
                {
                    vendedor = cadVendedor.GetVendedor(i); //Obtém cada um dos vendedores cadastrados
                    linha = vendedor.Codigo + ";" + vendedor.Nome + ";" + vendedor.Cidade + ";" + vendedor.Vendas;
                    sw.WriteLine(linha); //grava a string linha no arquivo
                }
        }
        catch (Exception ex)
        {

        }





    
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeanCarlosRamosOliveira
{
    internal class LeArquivoCSV
    {

        private CadVendedor cadastro;
        public LeArquivoCSV(CadVendedor cadVendedor)
        {
            cadastro = cadVendedor;
        }
        public bool ExisteArquivo(string arquivo) //retorna true ou false se o arq. existe ou não
        {
            return File.Exists(arquivo); //Testa a existência do arquivo
        }
        public void LeArquivoCategorias(string arquivo)
        {
            if (!ExisteArquivo(arquivo))
                return;

            try
            {
                using (StreamReader sr = new StreamReader(arquivo))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        var campos = linha.Split(';');
                        var vendedor = new Vendedor
                        {
                            Codigo = int.Parse(campos[0]),
                            Nome = campos[1],
                            Cidade = campos[2],
                            Vendas = double.Parse(campos[3])
                        };
                        cadastro.Insere(vendedor);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro!\n" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Término da Leitura de Dados do Arquivo " + arquivo);
            }
        }

        public void LeArquivoVeiculos(string arquivo)
        {
            if (!ExisteArquivo(arquivo))
                return;

            try
            {
                using (StreamReader sr = new StreamReader(arquivo))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        var campos = linha.Split(';');
                        var vendedor = new Vendedor
                        {
                            Codigo = int.Parse(campos[0]),
                            Nome = campos[1],
                            Cidade = campos[2],
                            Vendas = double.Parse(campos[3])
                        };
                        cadastro.Insere(vendedor);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro!\n" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Término da Leitura de Dados do Arquivo " + arquivo);
            }
        }

        public void LeArquivoLocacoes(string arquivo)
        {
            if (!ExisteArquivo(arquivo))
                return;

            try
            {
                using (StreamReader sr = new StreamReader(arquivo))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        var campos = linha.Split(';');
                        var vendedor = new Vendedor
                        {
                            Codigo = int.Parse(campos[0]),
                            Nome = campos[1],
                            Cidade = campos[2],
                            Vendas = double.Parse(campos[3])
                        };
                        cadastro.Insere(vendedor);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro!\n" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Término da Leitura de Dados do Arquivo " + arquivo);
            }
        }

    }
}
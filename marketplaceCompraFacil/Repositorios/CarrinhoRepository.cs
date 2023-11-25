using marketplaceCompraFacil.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static marketplaceCompraFacil.Program;

namespace marketplaceCompraFacil.Repositorios
{
    public class CarrinhoRepository
    {
        public string connectionString; // string de conexão com o banco de dados

        public CarrinhoRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Método para adicionar um item ao carrinho
        public void AdicionarItemAoCarrinho(Carrinho item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string sql = string.Concat(
                        "INSERT INTO CARRINHO VALUES({0}, {1}, {2}, {3}, {4})",
                        item.Id, item.DataPedido, item.ValorTotal, item.StatusPedido, item.Cliente.Id);

                    connection.Open();


                    Console.WriteLine("OK");
                }
                catch (Exception)
                {
                    Console.WriteLine("pau");
                    throw;
                }
            }
        }

        // Método para obter todos os itens no carrinho
        private List<Carrinho> ObterItensDoCarrinho()
        {
            List<Carrinho> itens = new List<Carrinho>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Lógica para recuperar os itens do banco de dados
            }
            return itens;
        }

        // Outros métodos relevantes para a manipulação do carrinho no banco de dados
    }
}

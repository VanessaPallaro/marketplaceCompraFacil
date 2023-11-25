using marketplaceCompraFacil.Models;
using marketplaceCompraFacil.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketplaceCompraFacil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarrinhoRepository rep = new CarrinhoRepository("Data Source=DESKTOP-9N9517Q\\SQL;Initial Catalog=COMPRAFACIL;Integrated Security=True;");

            Carrinho car = new Carrinho()
            {
                Id = 1,
                DataPedido = new DateTime(),
                StatusPedido = 1,
                ValorTotal = 12, 
                Cliente = new Cliente()
                {

                }
            };

            rep.AdicionarItemAoCarrinho(car);
        }
    }
}

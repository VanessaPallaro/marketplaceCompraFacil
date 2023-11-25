using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketplaceCompraFacil.Models
{
    public class Carrinho
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public float ValorTotal { get; set; }
        public int StatusPedido { get; set; }
        public Cliente Cliente { get; set; }
    }
}

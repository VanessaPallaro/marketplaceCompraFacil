using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketplaceCompraFacil.Models
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Preco { get; set; }
        public string Imagem { get; set; }
        public bool Status { get; set; }
    }
}

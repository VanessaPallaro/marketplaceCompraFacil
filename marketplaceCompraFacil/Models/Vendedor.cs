using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketplaceCompraFacil.Models
{
    internal class Vendedor
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int CNPJ { get; set; }
        public string Comissao { get; set; }
    }
}

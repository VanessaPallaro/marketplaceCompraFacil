﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketplaceCompraFacil.Models
{
    internal class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
    }
}

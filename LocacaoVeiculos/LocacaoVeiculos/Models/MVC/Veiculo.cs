﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocacaoVeiculos.Models
{
    public class Veiculo
    {
        public int VeiculoID { get; set; }

        public string Nome { get; set; }

        public string Fabricante { get; set; }
        
        public string Cor { get; set; }

        public int Ano { get; set; }



    }
}
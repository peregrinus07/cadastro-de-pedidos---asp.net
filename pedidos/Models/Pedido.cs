using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pedidos.Models
{
    public class Pedido
    { 
        public int id { get; set; }

        public DateTime Data { get; set; }

        public string Cliente { get; set; }
        
        public Decimal valor { get; set; }

    }
}
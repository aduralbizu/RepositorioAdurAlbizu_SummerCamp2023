using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class FactorConversion { 

        //en todas las tablas hace falta id!! 
        public int Id { get; set; }

        public int MonedaOrigenId { get; set; }
        public int MonedaDestinoId { get; set; }

        public double Factor { get; set; }
    }
}
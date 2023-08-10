using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIJsonBiblioteca
{
    public class ApiMonedas
    {
        public List<MonedaJson> ObtenerMonedas()
        {
            return new List<MonedaJson>
            {
                new MonedaJson { CodigoMoneda  ="EUR",
                },
                new MonedaJson { CodigoMoneda = "USD"},
                new MonedaJson { CodigoMoneda = "GBP"}
            };
        }
    }
}

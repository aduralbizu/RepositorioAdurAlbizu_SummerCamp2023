using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    //[Table("Moneda")]
    public class MonedaDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Descripcion { get; set; }
    }
}

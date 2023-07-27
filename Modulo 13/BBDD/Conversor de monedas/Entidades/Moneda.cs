
//using System.ComponentModel.DataAnnotations; //Indica que cuando entity frmaework lo utilice para acceder o editar base de datos, esta es la clave
//No lo utilizamos

namespace Entidades
{
    public class Moneda
    {
        
        public int Id { get; set; } 

        public string Nombre { get; set; }

        public double ValorRespectoDolar { get; set; } //valor respecto dolar


    }
}
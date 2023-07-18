namespace Entidades
{
    //public - Visible en todo el proyecto
    //private - No visible d ningún modo
    //protected - 
    //internal - Clase empleado no visible fuera de EjercicioResueltoprofe
    //protected internal - Proteger algo mucho
    public class Empleado //Debe ser public!!
    {
        public enum Nivel
        {
            normal,
            bueno,
            excelente
        }
        private Nivel _nivel;

        public void fijarNivel(Nivel nivel)
        {
            this._nivel = nivel;
        }
        public Empleado() //Vacío existe aunque no lo hagas
        {

        }

        public Empleado(string nombre, double salario, DateTime fechaAlta, bool alta)
        {
            Nombre = nombre;
            Salario = salario;
            FechaAlta = fechaAlta;
            Alta = alta;
        }
        public string Nombre { get; set; }
        public double Salario { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Alta { get; set; }

        //public void CalcularAumentoSalario()
        //{
         //   throw new NotImplementedException();
       // }
        //Propiedades


    }
}

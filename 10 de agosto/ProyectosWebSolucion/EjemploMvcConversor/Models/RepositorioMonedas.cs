namespace EjemploMvcConversor.Models
{
    public class RepositorioMonedas : IRepositorioMonedas

    {
        private ContextoConversor _context;
        public RepositorioMonedas(ContextoConversor contexto)
        {
            _context = contexto;
        } //De esta forma ya llega el entity framework instanciado


        public void AgregarMoneda(Moneda moneda)
        {
            _context.Monedas.Add(moneda);
            //Hay que persistir:
            _context.SaveChanges();
        }

        public Moneda ObtenerMoneda(int id)
        {
            var moneda = _context.Monedas.FirstOrDefault(x => x.Id == id); //first or default da la tabvla
            return moneda;
        }
        //Hacer esto en todos los controladores
        public IEnumerable<Moneda> ObtenerMonedas()
        {
            return _context.Monedas; //Ya est, asi se obtienen todas las monedas en la BBDD

        }
    }
}

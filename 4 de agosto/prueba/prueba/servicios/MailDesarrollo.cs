namespace prueba.servicios
{
    public class MailDesarrollo:IEmail
    {

        public string EscribirEmail()
        {
            return  "Mensaje: Este es el email de desarrollo";
        }
    }
}

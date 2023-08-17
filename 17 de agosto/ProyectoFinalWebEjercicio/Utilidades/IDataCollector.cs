using Models;

namespace Utilidades
{
    public interface IDataCollector
    {
        //Task CallApiFactores();
        //Task<string> CallApiMonedas();

        //List<FactorBaseDolarJson> LeerFactoresConversionJson();

        List<Moneda> LeerMonedas();
    }
}
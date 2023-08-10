using APIJsonBiblioteca;
using AutoMapper;
using EjemploMvcConversor.Models;

namespace EjemploMvcConversor.Profiles
{
    public class MonedaProfile:Profile
    {
        public MonedaProfile()
        {
            CreateMap<MonedaJson, Moneda>(); 
            //viene de monedajson y quiero convertirlo en moneda
        }
    }
}

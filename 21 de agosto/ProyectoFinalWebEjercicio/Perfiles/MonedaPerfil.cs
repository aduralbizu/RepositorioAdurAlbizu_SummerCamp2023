using AutoMapper;
using DTOs;
using Entities;

namespace Perfiles
{
    public class MonedaPerfil:Profile
    {
        public MonedaPerfil() {

            CreateMap<Moneda, MonedaDTO>()
            .ForMember(dest => dest.Descripcion, opt =>
                opt.MapFrom(src => $"{src.Code} {src.Name} {src.Symbol}"));

        }

    }
}
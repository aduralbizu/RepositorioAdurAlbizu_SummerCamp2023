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
            CreateMap<MonedaForCreationDto, Moneda>().ForMember(dest => dest.Code, opt =>
        {
            opt.MapFrom(src => src.Code.Length > 3 ? src.Code.Substring(0, 3) : src.Code);
        });



        }

    }
}
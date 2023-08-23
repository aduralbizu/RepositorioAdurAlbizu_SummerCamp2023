using AutoMapper;

namespace ConversorWeb.Profiles
{
    public class MonedaProfile : Profile
    {
        public MonedaProfile()
        {
            CreateMap<MonedaJson, MonedaJson>();
        }
    }
}

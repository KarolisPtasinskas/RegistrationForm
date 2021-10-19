using AutoMapper;
using RegistrationForm.DAL.DTO;
using RegistrationForm.DAL.Entities;

namespace RegistrationForm.DAL.AutoMapper
{
    public class RegFormProfile : Profile
    {
        public RegFormProfile()
        {
            CreateMap<RegForm, RegFormDTO>();
            CreateMap<Option, OptionDTO>();
            CreateMap<OptionDTO, Option>();
            CreateMap<Value, ValueDTO>();
            CreateMap<ValueDTO, Value>();

            CreateMap<OptionUpdateDTO, Option>();
        }
    }
}

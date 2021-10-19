using AutoMapper;
using RegistrationForm.DAL.DTO;
using RegistrationForm.DAL.Entities;
using RegistrationForm.Repositories;
using System.Collections.Generic;

namespace RegistrationForm.Services
{
    public class FormService
    {
        private readonly FormRepository _formRepository;
        private readonly IMapper _mapper;

        public FormService(FormRepository formRepository, IMapper mapper)
        {
            _formRepository = formRepository;
            _mapper = mapper;
        }

        public List<RegFormDTO> GetAll()
        {
            var regFormDb = _formRepository.GetAll();
            var mappedRegForm = _mapper.Map<List<RegFormDTO>>(regFormDb);
            return mappedRegForm;
        }

        public List<OptionDTO> GetById(int id)
        {
            var optionDb = _formRepository.GetById(id);
            var mappedOption = _mapper.Map<List<OptionDTO>>(optionDb);
            return mappedOption;
        }

        public void UpdateOptions(OptionUpdateDTO option)
        {
            var optionDb = _mapper.Map<Option>(option);
            _formRepository.UpdateOptions(optionDb);
        }

    }
}

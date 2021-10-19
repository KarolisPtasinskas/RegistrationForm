using Microsoft.AspNetCore.Mvc;
using RegistrationForm.DAL.DTO;
using RegistrationForm.DAL.Entities;
using RegistrationForm.Services;
using System.Collections.Generic;

namespace RegistrationForm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormsController : ControllerBase
    {
        private readonly FormService _formService;

        public FormsController(FormService formService)
        {
            _formService = formService;
        }

        [HttpGet]
        public ActionResult<List<RegFormDTO>> GetAll()
        {
            return Ok(_formService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<List<OptionDTO>> GetById(int id)
        {
            return Ok(_formService.GetById(id));
        }

        [HttpPut]
        public ActionResult Update(OptionUpdateDTO option)
        {
            _formService.UpdateOptions(option);
            return Ok();
        }
    }
}

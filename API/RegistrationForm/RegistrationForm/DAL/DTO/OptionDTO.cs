using RegistrationForm.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationForm.DAL.DTO
{
    public class OptionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegFormId { get; set; }
        public int? SelectedValueId { get; set; }
        public ICollection<ValueDTO> Values { get; set; }
    }
}

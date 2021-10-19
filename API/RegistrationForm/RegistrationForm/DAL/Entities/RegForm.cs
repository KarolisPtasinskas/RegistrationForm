using System.Collections.Generic;

namespace RegistrationForm.DAL.Entities
{
    public class RegForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Option> Options { get; set; }
    }
}

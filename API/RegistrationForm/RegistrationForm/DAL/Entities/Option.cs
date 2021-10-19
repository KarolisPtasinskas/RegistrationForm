using System.Collections.Generic;

namespace RegistrationForm.DAL.Entities
{
    public class Option
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegFormId { get; set; }
        public int? SelectedValueId { get; set; }
        public ICollection<Value> Values { get; set; }
    }
}

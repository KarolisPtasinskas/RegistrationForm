using Microsoft.EntityFrameworkCore;
using RegistrationForm.DAL.Entities;
using RegistrationForm.Data;
using System.Collections.Generic;
using System.Linq;

namespace RegistrationForm.Repositories
{
    public class FormRepository
    {
        private readonly RegistrationFormContext _context;

        public FormRepository(RegistrationFormContext context)
        {
            _context = context;
        }

        public List<RegForm> GetAll()
        {
            return _context.RegForms.ToList();
        }

        public List<Option> GetById(int id)
        {
            return _context.Options.Where(o => o.RegFormId == id).Include(v => v.Values).ToList();
        }

        public void UpdateOptions(Option option)
        {
            _context.Options.Update(option);
            _context.SaveChanges();
        }


    }
}

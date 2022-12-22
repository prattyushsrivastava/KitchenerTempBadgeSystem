using Data.Access.Layer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Access.Layer.Repository
{
    public class GenricRepository : IGenricRepository
    {
        private readonly KitchenerTempBadgeContext _dbContext;

        public GenricRepository(KitchenerTempBadgeContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        

        public IEnumerable<Employee> GetEmployees(string fname, string lname)
        {

            return _dbContext.Employees.Where(p => (p.FirstName.ToLower() == fname.ToLower() && p.LastName.ToLower() == lname.ToLower())).ToList();
        }
    }
}

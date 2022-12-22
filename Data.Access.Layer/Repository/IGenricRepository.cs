using Data.Access.Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Access.Layer.Repository
{
    public interface IGenricRepository
    {
        public IEnumerable<Employee> GetEmployees(string fname, string lname);
    }
}

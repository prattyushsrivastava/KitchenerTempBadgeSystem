using Data.Access.Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Services
{
    public interface IGuardService
    {
        public IEnumerable<Gaurd> GetBadges(string fname, string lname, int ecode);

    }
}

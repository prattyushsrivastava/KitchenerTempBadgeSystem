using Data.Access.Layer.Models;
using Data.Access.Layer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Services
{
    public class GuardService : IGuardService
    {
        private readonly IGenricRepository _repo;

        public GuardService(IGenricRepository repo)
        {
            this._repo = repo;
        }
        public IEnumerable<Gaurd> GetBadges(string fname, string lname, int ecode)
        {
            return _repo.GetBadges(fname,lname,ecode);
        }
    }
}

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
        private static Random rnd = new Random();
        Gaurd ob1 = new Gaurd();

        public GenricRepository(KitchenerTempBadgeContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public IEnumerable<Gaurd> GetBadges(string fname, string lname, int ecode)
        {
            const string alphanumericCharacters =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
            "abcdefghijklmnopqrstuvwxyz" +
            "0123456789@#*_%!";

            int needLength = 8;

            string randomStr = new string(Enumerable.Range(1, needLength)
                .Select(_ => alphanumericCharacters[rnd.Next(alphanumericCharacters.Length)]).ToArray());


            ob1.FirstName = fname;
            ob1.LastName = lname;
            ob1.EmpCode = ecode;
            ob1.SignIn = DateTime.Now;
            ob1.TempBadge = randomStr;
            _dbContext.Gaurds.Add(ob1);
            _dbContext.SaveChanges();
            return _dbContext.Gaurds.ToList();
        }

        public IEnumerable<Employee> GetEmployees(string fname, string lname)
        {

            return _dbContext.Employees.Where(p => (p.FirstName.ToLower() == fname.ToLower() && p.LastName.ToLower() == lname.ToLower())).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Access.Layer.Models
{
    public class Report
    {
        public string Name { get; set; } = null!;
        public string TempBadge { get; set; } = null!;
        public DateTime SignIn { get; set; }
        public int AssignTime { get; set; }
        public DateTime SignOut { get; set; }
    }
}

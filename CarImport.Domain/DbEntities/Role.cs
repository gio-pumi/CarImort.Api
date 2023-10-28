using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Domain.DbEntities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public  List<User> Users { get; set; }
    }
}

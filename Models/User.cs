using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCoreDemo.Models
{
    public class EFUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public string PassWord { get; set; }
    }
}

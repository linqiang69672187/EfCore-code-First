using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCoreDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private DataContext dataContext;
        public UserController(DataContext context)
        {
            dataContext = context;
        }

        [HttpGet]
        public ActionResult<List<EFUser>> GetAuthors()
        {
            return dataContext.efnewusers.ToList();
        }
    }
}

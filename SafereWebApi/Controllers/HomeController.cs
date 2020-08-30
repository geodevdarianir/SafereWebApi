using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SafereWebApi.Interfaces;
using SafereWebApi.Models;

namespace SafereWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IAdmin _admin;

        public HomeController(IAdmin admin)
        {
            _admin = admin;
        }

        public IActionResult Index()
        {
            return Ok(_admin.GetAllAdmins());
        }
    }
}

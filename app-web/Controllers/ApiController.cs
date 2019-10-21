using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app_web.Models;
using app_web.Data;
using app_core;

namespace app_web.Controllers
{
    [Route("api/contacto")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Contacto>> PostContactoApi(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<ActionResult> GetContacto()
        {
           
            return Ok();
        }
    }
}
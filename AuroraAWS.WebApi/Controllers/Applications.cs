using System.Collections.Generic;
using System.Threading.Tasks;
using AuroraAWS.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuroraAWS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Applications : ControllerBase
    {
        private readonly MetaDataDBContext _context;

        public Applications(MetaDataDBContext context)
        {
            _context = context;
        }

        // GET: api/Applications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Application>>> GetApplications()
        {
            return await _context.Applications.ToListAsync();
        }

        // GET: api/Applications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Application>> GetApplication(int id)
        {
            var application = await _context.Applications.FindAsync(id);

            if (application == null) return NotFound();

            return application;
        }
    }
}

using AuroraAWS.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuroraAWS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociationsController : ControllerBase
    {
        private readonly MetaDataDBAuroraContext _context;

        public AssociationsController(MetaDataDBAuroraContext context)
        {
            _context = context;
        }

        // GET: api/Associations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Association>>> GetAssociations()
        {
            return await _context.Associations.ToListAsync();
        }

        // GET: api/Associations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Association>> GetAssociation(int id)
        {
            var association = await _context.Associations.FindAsync(id);

            if (association == null)
            {
                return NotFound();
            }

            return association;
        }
    }
}
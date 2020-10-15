using System.Collections.Generic;
using System.Threading.Tasks;
using AuroraAWS.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuroraAWS.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class AssociationsPersonsController : Controller
    {
        private readonly MetaDataDBContext _context;

        public AssociationsPersonsController(MetaDataDBContext context)
        {
            _context = context;
        }

        // GET: api/AssociationsPersons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssociationPerson>>> GetAssociationsPersons()
        {
            return await _context.AssociationsPersons.ToListAsync();
        }

        // GET: api/AssociationsPersons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AssociationPerson>> GetAssociationPerson(int id)
        {
            var associationPerson = await _context.AssociationsPersons.FindAsync(id);

            if (associationPerson == null) return NotFound();

            return associationPerson;
        }
    }
}

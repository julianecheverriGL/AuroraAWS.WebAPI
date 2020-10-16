using System.Collections.Generic;
using System.Threading.Tasks;
using AuroraAWS.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuroraAWS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersMapping : ControllerBase
    {
        private readonly MetaDataDBContext _context;

        public UsersMapping(MetaDataDBContext context)
        {
            _context = context;
        }

        // GET: api/UsersMapping
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExternalUserApplicationMap>>> GetExternalUsersApplicationMap()
        {
            return await _context.ExternalUsersApplicationMap.ToListAsync();
        }

        // GET: api/UsersMapping/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExternalUserApplicationMap>> GetExternalUserApplicationMap(int id)
        {
            var externalUserApplicationMap = await _context.ExternalUsersApplicationMap.FindAsync(id);

            if (externalUserApplicationMap == null) return NotFound();

            return externalUserApplicationMap;
        }
    }
}

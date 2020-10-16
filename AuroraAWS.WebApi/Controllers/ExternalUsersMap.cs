using System.Collections.Generic;
using System.Threading.Tasks;
using AuroraAWS.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuroraAWS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalUsersMap : ControllerBase
    {
        private readonly MetaDataDBContext _context;

        public ExternalUsersMap(MetaDataDBContext context)
        {
            _context = context;
        }

        // GET: api/ExternalUsersMap
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExternalUserMap>>> GetExternalUsersMap()
        {
            return await _context.ExternalUsersMap.ToListAsync();
        }

        // GET: api/ExternalUsersMap/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExternalUserMap>> GetExternalUserMap(int id)
        {
            var externalUserMap = await _context.ExternalUsersMap.FindAsync(id);

            if (externalUserMap == null) return NotFound();

            return externalUserMap;
        }
    }
}

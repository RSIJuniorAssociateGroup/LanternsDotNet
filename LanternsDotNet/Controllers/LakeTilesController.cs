using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LanternsDotNet.Models;

namespace LanternsDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LakeTilesController : ControllerBase
    {
        private readonly LanternContext _context;

        public LakeTilesController(LanternContext context)
        {
            _context = context;
        }

        // GET: api/LakeTiles
        [HttpGet]
        [Route("GetLakeTiles")]
        public async Task<ActionResult<IEnumerable<LakeTile>>> GetLakeTiles()
        {
            return await _context.LakeTiles.ToListAsync();
        }

        // GET: api/LakeTiles/5
        [HttpGet("{id}")]
        [Route("GetLakeTile")]
        public async Task<ActionResult<LakeTile>> GetLakeTile(Guid id)
        {
            var lakeTile = await _context.LakeTiles.FindAsync(id);

            if (lakeTile == null)
            {
                return NotFound();
            }

            return lakeTile;
        }

        /* PUT: api/LakeTiles/5
        [HttpPut("{id}")]
        [Route("PutLakeTile")]
        public async Task<IActionResult> PutLakeTile(Guid id, LakeTile lakeTile)
        {
            if (id != lakeTile.LakeTileId)
            {
                return BadRequest();
            }

            _context.Entry(lakeTile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LakeTileExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LakeTiles
        [HttpPost]
        [Route("PostLakeTile")]
        public async Task<ActionResult<LakeTile>> PostLakeTile(LakeTile lakeTile)
        {
            _context.LakeTiles.Add(lakeTile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLakeTile", new { id = lakeTile.LakeTileId }, lakeTile);
        }

        // DELETE: api/LakeTiles/5
        [HttpDelete("{id}")]
        [Route("DeleteLakeTile")]
        public async Task<ActionResult<LakeTile>> DeleteLakeTile(Guid id)
        {
            var lakeTile = await _context.LakeTiles.FindAsync(id);
            if (lakeTile == null)
            {
                return NotFound();
            }

            _context.LakeTiles.Remove(lakeTile);
            await _context.SaveChangesAsync();

            return lakeTile;
        }

        private bool LakeTileExists(Guid id)
        {
            return _context.LakeTiles.Any(e => e.LakeTileId == id);
        }
        */
    }
}

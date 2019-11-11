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
    public class LakeTileColorsController : ControllerBase
    {
        private readonly LanternContext _context;

        public LakeTileColorsController(LanternContext context)
        {
            _context = context;
        }

        // GET: api/LakeTileColors
        [HttpGet]
        [Route("GetLakeTileColor")]
        public async Task<ActionResult<IEnumerable<LakeTileColor>>> GetLakeTileColor()
        {
            return await _context.LakeTileColor.ToListAsync();
        }

        // GET: api/LakeTileColors/5
        [HttpGet("{id}")]
        [Route("GetLakeTileColors")]
        public async Task<ActionResult<LakeTileColor>> GetLakeTileColor(Guid id)
        {
            var lakeTileColor = await _context.LakeTileColor.FindAsync(id);

            if (lakeTileColor == null)
            {
                return NotFound();
            }

            return lakeTileColor;
        }

        /* PUT: api/LakeTileColors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLakeTileColor(Guid id, LakeTileColor lakeTileColor)
        {
            if (id != lakeTileColor.LakeTileColorId)
            {
                return BadRequest();
            }

            _context.Entry(lakeTileColor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LakeTileColorExists(id))
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

        // POST: api/LakeTileColors
        [HttpPost]
        public async Task<ActionResult<LakeTileColor>> PostLakeTileColor(LakeTileColor lakeTileColor)
        {
            _context.LakeTileColor.Add(lakeTileColor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLakeTileColor", new { id = lakeTileColor.LakeTileColorId }, lakeTileColor);
        }

        // DELETE: api/LakeTileColors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LakeTileColor>> DeleteLakeTileColor(Guid id)
        {
            var lakeTileColor = await _context.LakeTileColor.FindAsync(id);
            if (lakeTileColor == null)
            {
                return NotFound();
            }

            _context.LakeTileColor.Remove(lakeTileColor);
            await _context.SaveChangesAsync();

            return lakeTileColor;
        }

        private bool LakeTileColorExists(Guid id)
        {
            return _context.LakeTileColor.Any(e => e.LakeTileColorId == id);
        }
        */
    }
}

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
    public class LakeTileLakeTileColorsController : ControllerBase
    {
        private readonly LanternContext _context;

        public LakeTileLakeTileColorsController(LanternContext context)
        {
            _context = context;
        }

        // GET: api/LakeTileLakeTileColors
        [HttpGet]
        [Route("GetLakeTileLakeTileColors")]
        public async Task<ActionResult<IEnumerable<LakeTileLakeTileColor>>> GetLakeTileLakeTileColors()
        {
            return await _context.LakeTileLakeTileColors.ToListAsync();
        }

        // GET: api/LakeTileLakeTileColors/5
        [HttpGet("{id}")]
        [Route("GetLakeTileLakeTileColor")]
        public async Task<ActionResult<LakeTileLakeTileColor>> GetLakeTileLakeTileColor(Guid id)
        {
            var lakeTileLakeTileColor = await _context.LakeTileLakeTileColors.FindAsync(id);

            if (lakeTileLakeTileColor == null)
            {
                return NotFound();
            }

            return lakeTileLakeTileColor;
        }

        /* PUT: api/LakeTileLakeTileColors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLakeTileLakeTileColor(Guid id, LakeTileLakeTileColor lakeTileLakeTileColor)
        {
            if (id != lakeTileLakeTileColor.LakeTileColorId)
            {
                return BadRequest();
            }

            _context.Entry(lakeTileLakeTileColor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LakeTileLakeTileColorExists(id))
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

        // POST: api/LakeTileLakeTileColors
        [HttpPost]
        public async Task<ActionResult<LakeTileLakeTileColor>> PostLakeTileLakeTileColor(LakeTileLakeTileColor lakeTileLakeTileColor)
        {
            _context.LakeTileLakeTileColors.Add(lakeTileLakeTileColor);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LakeTileLakeTileColorExists(lakeTileLakeTileColor.LakeTileColorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLakeTileLakeTileColor", new { id = lakeTileLakeTileColor.LakeTileColorId }, lakeTileLakeTileColor);
        }

        // DELETE: api/LakeTileLakeTileColors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LakeTileLakeTileColor>> DeleteLakeTileLakeTileColor(Guid id)
        {
            var lakeTileLakeTileColor = await _context.LakeTileLakeTileColors.FindAsync(id);
            if (lakeTileLakeTileColor == null)
            {
                return NotFound();
            }

            _context.LakeTileLakeTileColors.Remove(lakeTileLakeTileColor);
            await _context.SaveChangesAsync();

            return lakeTileLakeTileColor;
        }

        private bool LakeTileLakeTileColorExists(Guid id)
        {
            return _context.LakeTileLakeTileColors.Any(e => e.LakeTileColorId == id);
        }
        */
    }
}

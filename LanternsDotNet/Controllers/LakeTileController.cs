using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanternsDotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LanternsDotNet.Controllers
{
    public class LakeTileController : Controller
    {
        private readonly LanternContext _context;

        public LakeTileController(LanternContext context)
        {
            _context = context;
        }

        // GET: api/
        [HttpGet]
        public IEnumerable<LakeTile> GetLakeTiles()
        {
            return _context.LakeTiles;
        }

        // GET: api/LakeTiles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLakeTile([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lakeTile = await _context.LakeTiles.FindAsync(id);

            if (lakeTile == null)
            {
                return NotFound();
            }

            return Ok(lakeTile);
        }

        // PUT: api/LakeTiles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLakeTile([FromRoute] Guid id, [FromBody] LakeTile lakeTile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

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
        public async Task<IActionResult> PostLakeTile([FromBody] LakeTile lakeTile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.LakeTiles.Add(lakeTile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLakeTile", new { id = lakeTile.LakeTileId }, lakeTile);
        }

        // DELETE: api/LakeTiles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLakeTile([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lakeTile = await _context.LakeTiles.FindAsync(id);
            if (lakeTile == null)
            {
                return NotFound();
            }

            _context.LakeTiles.Remove(lakeTile);
            await _context.SaveChangesAsync();

            return Ok(lakeTile);
        }

        private bool LakeTileExists(Guid id)
        {
            return _context.LakeTiles.Any(e => e.LakeTileId == id);
        }
    }
}
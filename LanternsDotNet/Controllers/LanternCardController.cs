using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanternsDotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LanternsDotNet.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class LanternCardController : ControllerBase
    {
        private readonly LanternContext _context;

        public LanternCardController(LanternContext context)
        {
            _context = context;
        }

        // GET: api/LanternCards
        [HttpGet]
        public IEnumerable<LanternCard> GetLanternCards()
        {
            return _context.LanternCards;
        }

        // GET: api/LanternCards/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLanternCard([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lanternCard = await _context.LanternCards.FindAsync(id);

            if (lanternCard == null)
            {
                return NotFound();
            }

            return Ok(lanternCard);
        }

        // PUT: api/LanternCards/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLanternCard([FromRoute] Guid id, [FromBody] LanternCard lanternCard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lanternCard.LanternCardId)
            {
                return BadRequest();
            }

            _context.Entry(lanternCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LanternCardExists(id))
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

        // POST: api/LanternCard
        [HttpPost]
        public async Task<IActionResult> PostLanternCard([FromBody] LanternCard lanternCard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.LanternCards.Add(lanternCard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLanternCard", new { id = lanternCard.LanternCardId }, lanternCard);
        }

        // DELETE: api/LanternCards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLanternCard([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lanternCard = await _context.LanternCards.FindAsync(id);
            if (lanternCard == null)
            {
                return NotFound();
            }

            _context.LanternCards.Remove(lanternCard);
            await _context.SaveChangesAsync();

            return Ok(lanternCard);
        }

        private bool LanternCardExists(Guid id)
        {
            return _context.LanternCards.Any(e => e.LanternCardId == id);
        }
    }
}
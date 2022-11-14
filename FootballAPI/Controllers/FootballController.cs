using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FootballAPI.Models;
using FootballAPI;

namespace API_Workshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballController : ControllerBase
    {
        private readonly FootballContext _context;

        public FootballController(FootballContext context)
        {
            _context = context;
        }

        // GET: api/Player - "Read" all Player records 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            if (_context.Players == null)
            {
                return NotFound();
            }
            return await _context.Players.ToListAsync();
        }

        // GET: api/Player/5 - "Read" one player
        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            if (_context.Players == null)
            {
                return NotFound();
            }
            var Player = await _context.Players.FindAsync(id);

            if (Player == null)
            {
                return NotFound();
            }

            return Player;
        }

        // PUT: api/VideoGames/5 - "Update" a single record in the database
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayer(int id, Player player)
        {
            if (id != player.Id)
            {
                return BadRequest();
            }

            _context.Entry(player).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerExists(id))
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

        // POST: api/Player - "Create/Insert" a record into the database
        [HttpPost]
        public async Task<ActionResult<Player>> PostPlayer(Player player)
        {
            if (_context.Players == null)
            {
                return Problem("Entity set PlayerContext.Players'  is null.");
            }
            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlayer", new { id = player.Id }, player);
        }

        // DELETE: api/Player/5 - "Delete" a record from the database
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            if (_context.Players == null)
            {
                return NotFound();
            }
            var videoGame = await _context.Players.FindAsync(id);
            if (videoGame == null)
            {
                return NotFound();
            }

            _context.Players.Remove(videoGame);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlayerExists(int id)
        {
            return (_context.Players?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

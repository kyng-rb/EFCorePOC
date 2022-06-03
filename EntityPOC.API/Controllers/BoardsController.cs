using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EntityPOC.Data.DatabaseContext;
using EntityPOC.Domain.Entities;
using AutoMapper;
using EntityPOC.API.DTOs;

namespace EntityPOC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardsController : ControllerBase
    {
        private readonly KanbanDatabaseContext _context;
        private readonly IMapper _mapper;

        public BoardsController(KanbanDatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Boards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BoardOutputDTO>>> GetBoards()
        {
            var boards = await _context.Boards.ToListAsync();
            var boardOuts = boards.Select(x => _mapper.Map<BoardOutputDTO>(x)).ToList();
            return Ok(boardOuts);
        }

        // GET: api/Boards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BoardOutputDTO>> GetBoard(int id)
        {
            var board = await _context.Boards.FindAsync(id);

            if (board == null)
            {
                return NotFound();
            }

            var output = _mapper.Map<BoardOutputDTO>(board);

            return output;
        }

        // PUT: api/Boards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBoard(int id, BoardInputDTO board)
        {
            var boardEntity = _mapper.Map<Board>(board);
            _context.Entry(boardEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BoardExists(id))
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

        // POST: api/Boards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BoardOutputDTO>> PostBoard(BoardInputDTO board)
        {
            var boardEntity = _mapper.Map<Board>(board);

            _context.Boards.Add(boardEntity);
            await _context.SaveChangesAsync();

            var output = _mapper.Map<BoardOutputDTO>(boardEntity);
            return CreatedAtAction("GetBoard", new { id = output.Id }, output);
        }

        // DELETE: api/Boards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBoard(int id)
        {
            var board = await _context.Boards.FindAsync(id);
            if (board == null)
            {
                return NotFound();
            }

            _context.Boards.Remove(board);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BoardExists(int id)
        {
            return _context.Boards.Any(e => e.Id == id);
        }
    }
}

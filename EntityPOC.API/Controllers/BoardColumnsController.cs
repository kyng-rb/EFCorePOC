using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EntityPOC.Data.DatabaseContext;
using EntityPOC.Domain.Entities;

namespace EntityPOC.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BoardColumnsController : ControllerBase
	{
		private readonly KanbanDatabaseContext _context;

		public BoardColumnsController(KanbanDatabaseContext context)
		{
			_context = context;
		}

		// GET: api/BoardColumns
		[HttpGet]
		public async Task<ActionResult<IEnumerable<BoardColumn>>> GetBoardColumns()
		{
			return await _context.BoardColumns.ToListAsync();
		}

		// GET: api/BoardColumns/5
		[HttpGet("{id}")]
		public async Task<ActionResult<BoardColumn>> GetBoardColumn(int id)
		{
			var boardColumn = await _context.BoardColumns.FindAsync(id);

			if (boardColumn == null)
			{
				return NotFound();
			}

			return boardColumn;
		}

		// PUT: api/BoardColumns/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutBoardColumn(int id, BoardColumn boardColumn)
		{
			if (id != boardColumn.Id)
			{
				return BadRequest();
			}

			_context.Entry(boardColumn).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!BoardColumnExists(id))
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

		// POST: api/BoardColumns
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<BoardColumn>> PostBoardColumn(BoardColumn boardColumn)
		{
			_context.BoardColumns.Add(boardColumn);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetBoardColumn", new { id = boardColumn.Id }, boardColumn);
		}

		// DELETE: api/BoardColumns/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteBoardColumn(int id)
		{
			var boardColumn = await _context.BoardColumns.FindAsync(id);
			if (boardColumn == null)
			{
				return NotFound();
			}

			_context.BoardColumns.Remove(boardColumn);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool BoardColumnExists(int id)
		{
			return _context.BoardColumns.Any(e => e.Id == id);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityPOC.Data.DatabaseContext;
using EntityPOC.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityPOC.API.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class LabelsController : ControllerBase
	{
		private readonly KanbanDatabaseContext _context;

		public LabelsController(KanbanDatabaseContext context)
		{
			_context = context;
		}

		// GET: api/Labels
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Label>>> GetLabels()
		{
			return await _context.Labels.ToListAsync();
		}

		// GET: api/Labels/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Label>> GetLabel(int id)
		{
			var Label = await _context.Labels.FindAsync(id);

			if (Label == null)
			{
				return NotFound();
			}

			return Label;
		}

		// PUT: api/Labels/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutLabel(int id, Label Label)
		{
			if (id != Label.Id)
			{
				return BadRequest();
			}

			_context.Entry(Label).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!LabelExists(id))
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

		// POST: api/Labels
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Label>> PostLabel(Label Label)
		{
			_context.Labels.Add(Label);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetLabel", new { id = Label.Id }, Label);
		}

		// DELETE: api/Labels/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteLabel(int id)
		{
			var Label = await _context.Labels.FindAsync(id);
			if (Label == null)
			{
				return NotFound();
			}

			_context.Labels.Remove(Label);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool LabelExists(int id)
		{
			return _context.Labels.Any(e => e.Id == id);
		}
	}
}
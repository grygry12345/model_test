using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using model_test.Data;
using model_test.Models;

namespace model_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkCenterController : ControllerBase
    {
        private readonly TestContext _context;

        public WorkCenterController(TestContext context)
        {
            _context = context;
        }

        // GET: api/WorkCenter
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkCenter>>> GetWorkCenters()
        {
            return await _context.WorkCenters.ToListAsync();
        }

        // GET: api/WorkCenter/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkCenter>> GetWorkCenter(int id)
        {
            var workCenter = await _context.WorkCenters.FindAsync(id);

            if (workCenter == null)
            {
                return NotFound();
            }

            return workCenter;
        }

        // PUT: api/WorkCenter/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkCenter(int id, WorkCenter workCenter)
        {
            if (id != workCenter.Id)
            {
                return BadRequest();
            }

            _context.Entry(workCenter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkCenterExists(id))
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

        // POST: api/WorkCenter
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WorkCenter>> PostWorkCenter(WorkCenter workCenter)
        {
            _context.WorkCenters.Add(workCenter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkCenter", new { id = workCenter.Id }, workCenter);
        }

        // DELETE: api/WorkCenter/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkCenter(int id)
        {
            var workCenter = await _context.WorkCenters.FindAsync(id);
            if (workCenter == null)
            {
                return NotFound();
            }

            _context.WorkCenters.Remove(workCenter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkCenterExists(int id)
        {
            return _context.WorkCenters.Any(e => e.Id == id);
        }
    }
}

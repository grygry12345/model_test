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
    public class WorkCenterOperationController : ControllerBase
    {
        private readonly TestContext _context;

        public WorkCenterOperationController(TestContext context)
        {
            _context = context;
        }

        // GET: api/WorkCenterOperation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkCenterOperation>>> GetWorkCenterOperations()
        {
            return await _context.WorkCenterOperations.ToListAsync();
        }

        // GET: api/WorkCenterOperation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkCenterOperation>> GetWorkCenterOperation(int id)
        {
            var workCenterOperation = await _context.WorkCenterOperations.FindAsync(id);

            if (workCenterOperation == null)
            {
                return NotFound();
            }

            return workCenterOperation;
        }

        // PUT: api/WorkCenterOperation/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkCenterOperation(int id, WorkCenterOperation workCenterOperation)
        {
            if (id != workCenterOperation.Id)
            {
                return BadRequest();
            }

            _context.Entry(workCenterOperation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkCenterOperationExists(id))
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

        // POST: api/WorkCenterOperation
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WorkCenterOperation>> PostWorkCenterOperation(WorkCenterOperation workCenterOperation)
        {
            _context.WorkCenterOperations.Add(workCenterOperation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkCenterOperation", new { id = workCenterOperation.Id }, workCenterOperation);
        }

        // DELETE: api/WorkCenterOperation/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkCenterOperation(int id)
        {
            var workCenterOperation = await _context.WorkCenterOperations.FindAsync(id);
            if (workCenterOperation == null)
            {
                return NotFound();
            }

            _context.WorkCenterOperations.Remove(workCenterOperation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkCenterOperationExists(int id)
        {
            return _context.WorkCenterOperations.Any(e => e.Id == id);
        }
    }
}

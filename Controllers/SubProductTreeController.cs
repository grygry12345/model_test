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
    public class SubProductTreeController : ControllerBase
    {
        private readonly TestContext _context;

        public SubProductTreeController(TestContext context)
        {
            _context = context;
        }

        // GET: api/SubProductTree
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubProductTree>>> GetSubProductTrees()
        {
            return await _context.SubProductTrees.ToListAsync();
        }

        // GET: api/SubProductTree/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubProductTree>> GetSubProductTree(int id)
        {
            var subProductTree = await _context.SubProductTrees.FindAsync(id);

            if (subProductTree == null)
            {
                return NotFound();
            }

            return subProductTree;
        }

        // PUT: api/SubProductTree/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubProductTree(int id, SubProductTree subProductTree)
        {
            if (id != subProductTree.Id)
            {
                return BadRequest();
            }

            _context.Entry(subProductTree).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubProductTreeExists(id))
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

        // POST: api/SubProductTree
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SubProductTree>> PostSubProductTree(SubProductTree subProductTree)
        {
            _context.SubProductTrees.Add(subProductTree);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubProductTree", new { id = subProductTree.Id }, subProductTree);
        }

        // DELETE: api/SubProductTree/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubProductTree(int id)
        {
            var subProductTree = await _context.SubProductTrees.FindAsync(id);
            if (subProductTree == null)
            {
                return NotFound();
            }

            _context.SubProductTrees.Remove(subProductTree);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SubProductTreeExists(int id)
        {
            return _context.SubProductTrees.Any(e => e.Id == id);
        }
    }
}

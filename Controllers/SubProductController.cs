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
    public class SubProductController : ControllerBase
    {
        private readonly TestContext _context;

        public SubProductController(TestContext context)
        {
            _context = context;
        }

        // GET: api/SubProduct
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubProduct>>> GetSubProducts()
        {
            return await _context.SubProducts.ToListAsync();
        }

        // GET: api/SubProduct/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubProduct>> GetSubProduct(int id)
        {
            var subProduct = await _context.SubProducts.FindAsync(id);

            if (subProduct == null)
            {
                return NotFound();
            }

            return subProduct;
        }

        // PUT: api/SubProduct/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubProduct(int id, SubProduct subProduct)
        {
            if (id != subProduct.Id)
            {
                return BadRequest();
            }

            _context.Entry(subProduct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubProductExists(id))
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

        // POST: api/SubProduct
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SubProduct>> PostSubProduct(SubProduct subProduct)
        {
            _context.SubProducts.Add(subProduct);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubProduct", new { id = subProduct.Id }, subProduct);
        }

        // DELETE: api/SubProduct/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubProduct(int id)
        {
            var subProduct = await _context.SubProducts.FindAsync(id);
            if (subProduct == null)
            {
                return NotFound();
            }

            _context.SubProducts.Remove(subProduct);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SubProductExists(int id)
        {
            return _context.SubProducts.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppi.Models;

namespace WebAppi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DcandidateController : ControllerBase
    {
        private readonly EmployeeDB _context;

        public DcandidateController(EmployeeDB context)
        {
            _context = context;
        }

        // GET: api/Dcandidate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dcandidate>>> Getdcandidates()
        {
            return await _context.dcandidates.ToListAsync();
        }

        // GET: api/Dcandidate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dcandidate>> GetDcandidate(int id)
        {
            var dcandidate = await _context.dcandidates.FindAsync(id);

            if (dcandidate == null)
            {
                return NotFound();
            }

            return dcandidate;
        }

        // PUT: api/Dcandidate/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDcandidate(int id, Dcandidate dcandidate)
        {
            //if (id != dcandidate.Id)
            //{
            //    return BadRequest();
            //}
            dcandidate.Id = id;
            _context.Entry(dcandidate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DcandidateExists(id))
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

        // POST: api/Dcandidate
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Dcandidate>> PostDcandidate(Dcandidate dcandidate)
        {
            _context.dcandidates.Add(dcandidate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDcandidate", new { id = dcandidate.Id }, dcandidate);
        }

        // DELETE: api/Dcandidate/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Dcandidate>> DeleteDcandidate(int id)
        {
            var dcandidate = await _context.dcandidates.FindAsync(id);
            if (dcandidate == null)
            {
                return NotFound();
            }

            _context.dcandidates.Remove(dcandidate);
            await _context.SaveChangesAsync();

            return dcandidate;
        }

        private bool DcandidateExists(int id)
        {
            return _context.dcandidates.Any(e => e.Id == id);
        }
    }
}

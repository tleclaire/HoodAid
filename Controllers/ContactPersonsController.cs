using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HoodAid.Models;

namespace HoodAid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactPersonsController : ControllerBase
    {
        private readonly HoodAidContext _context;

        public ContactPersonsController(HoodAidContext context)
        {
            _context = context;
        }

        // GET: api/ContactPersons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactPerson>>> GetContactPersons()
        {
            return await _context.ContactPersons.ToListAsync();
        }

        // GET: api/ContactPersons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactPerson>> GetContactPerson(int id)
        {
            var contactPerson = await _context.ContactPersons.FindAsync(id);

            if (contactPerson == null)
            {
                return NotFound();
            }

            return contactPerson;
        }

        // PUT: api/ContactPersons/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactPerson(int id, ContactPerson contactPerson)
        {
            if (id != contactPerson.Id)
            {
                return BadRequest();
            }

            _context.Entry(contactPerson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactPersonExists(id))
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

        // POST: api/ContactPersons
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ContactPerson>> PostContactPerson(ContactPerson contactPerson)
        {
            _context.ContactPersons.Add(contactPerson);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof (GetContactPerson), new { id = contactPerson.Id }, contactPerson);
        }

        // DELETE: api/ContactPersons/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ContactPerson>> DeleteContactPerson(int id)
        {
            var contactPerson = await _context.ContactPersons.FindAsync(id);
            if (contactPerson == null)
            {
                return NotFound();
            }

            _context.ContactPersons.Remove(contactPerson);
            await _context.SaveChangesAsync();

            return contactPerson;
        }

        private bool ContactPersonExists(int id)
        {
            return _context.ContactPersons.Any(e => e.Id == id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MeetingOrganizer.API.Models;
using Microsoft.EntityFrameworkCore;
using MeetingOrganizer.API.Data;

namespace MeetingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeetingsController : Controller
    {
        private readonly MeetingsContext _context;

        public MeetingsController(MeetingsContext context)
        {
            _context = context;
        }
        // GET: api/meetings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Meeting>>> GetAllMeetings()
        {
            await _context.Meetings.ToListAsync();

            return Ok();
        }

        // GET: api/meetings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Meeting>> GetMeetingById(int id)
        {
            var meeting = await _context.Meetings.FindAsync(id);
            if (meeting == null)
            {
                return NotFound();
            }
            return meeting;
        }

        // POST: api/meetings
        [HttpPost]
        public async Task<ActionResult<Meeting>> CreateMeeting(Meeting meeting)
        {
            _context.Meetings.Add(meeting);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/meetings/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMeeting(int id, Meeting updatedMeeting)
        {
            if (id != updatedMeeting.Id)
            {
                return BadRequest();
            }

            _context.Entry(updatedMeeting).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return Ok();
        }

        // DELETE: api/meetings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeeting(int id)
        {
            var meeting = await _context.Meetings.FindAsync(id);
            if (meeting == null)
            {
                return NotFound();
            }

            _context.Meetings.Remove(meeting);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}

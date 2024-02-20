using MeetingOrganizer.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetingOrganizer.API.Data
{
    public class MeetingsContext : DbContext
    {
        public MeetingsContext(DbContextOptions<MeetingsContext> options) : base(options)
        {
        }
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Meeting>().HasData(
        //         new Meeting
        //         {
        //             Id = 1,
        //             Subject = "Interview1",
        //             Date = DateTime.Now,
        //             StartTime = DateTime.Now.AddHours(5),
        //             EndTime = DateTime.Now.AddHours(7),

        //         }
        //     );
        // }
        public DbSet<Meeting> Meetings { get; set; }


    }
}

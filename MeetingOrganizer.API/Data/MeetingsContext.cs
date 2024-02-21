using Microsoft.EntityFrameworkCore;

namespace MeetingOrganizer.API.Data
{
    public class MeetingsContext : DbContext
    {
        public MeetingsContext(DbContextOptions<MeetingsContext> options) : base(options)
        {

        }

        public DbSet<Meeting> Meetings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meeting>().HasData(
                new Meeting
                {
                    Id = 1,
                    Subject = "Interview",
                    Date = DateTime.UtcNow,
                    StartTime = DateTime.UtcNow,
                    EndTime = DateTime.UtcNow,
                    Participants = "A,B,C"
                },
                new Meeting
                {
                    Id = 2,
                    Subject = "Interview1",
                    Date = DateTime.UtcNow,
                    StartTime = DateTime.UtcNow,
                    EndTime = DateTime.UtcNow,
                    Participants = "A,D,C"
                },
                new Meeting
                {
                    Id = 3,
                    Subject = "Interview2",
                    Date = DateTime.UtcNow,
                    StartTime = DateTime.UtcNow,
                    EndTime = DateTime.UtcNow,
                    Participants = "A,D,E"
                }
            );
        }

    }
}

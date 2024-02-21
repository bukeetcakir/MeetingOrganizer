
using System.ComponentModel.DataAnnotations;

namespace MeetingOrganizer.API.Data;

public class Meeting
{
    [Key]
    public int Id { get; set; }
    public string? Subject { get; set; }
    public DateTime Date { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Participants { get; set; }

}
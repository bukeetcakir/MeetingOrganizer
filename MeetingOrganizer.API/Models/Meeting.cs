namespace MeetingOrganizer.API.Models;

public class Meeting{
        public Meeting()
        {
            Participants = new List<string>();
        }
        public int Id { get; set; }
        public string? Subject { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<string> Participants { get; set; }

}
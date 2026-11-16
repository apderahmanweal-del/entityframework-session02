namespace EventHub.Entities
{
    public class Badge
    {
        public int BadgeId { get; set; }

        public string BadgeNumber { get; set; }

        public DateTime IssuedDate { get; set; }

        public BadgeTier Tier { get; set; }

        public int AttendeeId { get; set; }

        // Navigation Property
        public Attendee Attendee { get; set; }
    }
}
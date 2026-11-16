namespace EventHub.Entities
{
    public class OrganizerProfile
    {
        public int OrganizerProfileId { get; set; }

        public int OrganizerId { get; set; }

        public string? Bio { get; set; }

        public string? Website { get; set; }

        public string? Logo { get; set; }

        // Navigation Property
        public Organizer Organizer { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventHub.Entities
{
    [Table("EventOrganizers")]
    public class Organizer
    {
        public int OrganizerId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string? CompanyName { get; set; }

        public bool IsVerified { get; set; }

        // One-to-One
        public OrganizerProfile OrganizerProfile { get; set; }

        // One-to-Many
        public ICollection<Event> Events { get; set; }
            = new List<Event>();
    }
}
using System.ComponentModel.DataAnnotations;
namespace SalesManagement.Models
{
    public class SalesLeadEntity
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        [Phone]
        public string Mobile { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Source { get; set; }
    }
}

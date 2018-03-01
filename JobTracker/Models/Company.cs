using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class Company
    {

        [Key]
        public int CompanyId { get; set; }

        [Required]
        public string Title { get; set; }

    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace alfasoft.Models
{
    [Table("contacts")]
    public class ContactModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(9, ErrorMessage = "Contact must have 9 digits")]
        [MinLength(9, ErrorMessage = "Contact must have 9 digits")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Contact must be numeric")]
        public string Contact { get; set; }
    }
}

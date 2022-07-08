using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Rekrutacja.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [EmailUnique]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public int? CategoryId { get; set; }
        [Display(Name = "Category")]
        public Category Categories { get; set; }
        public string OtherCategory { get; set; }

        [Phone]
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "DateOfBirth")]
        public string DateOfBirth { get; set; }

    }
}

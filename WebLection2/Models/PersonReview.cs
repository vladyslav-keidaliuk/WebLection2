using System.ComponentModel.DataAnnotations;

namespace WebLection2.Models
{
    public class PersonReview
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter your review")]
        public string? Review { get; set; }


        [Required(ErrorMessage = "Please enter your mark")]
        public string? Mark { get; set; }

        public string ? CreatedAt { get; set; }

    }
}

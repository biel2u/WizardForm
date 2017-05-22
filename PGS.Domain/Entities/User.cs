using System.ComponentModel.DataAnnotations;

namespace PGS.Domain.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please specify your Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please specify your Last name.")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please specify your Address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please specify your Phone number.")]
        [Display(Name = "Phone number")]
        public int? PhoneNumber { get; set; }
    }
}

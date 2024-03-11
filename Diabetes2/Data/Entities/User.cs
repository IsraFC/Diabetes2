using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Diabetes2.Data.Entities
{
    public class User
    {
        [Required]
        [Display(Name = "Nombre(s)")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Apellidos")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? LastName { get; set; }

        [Required]
        [Display(Name = "Correo")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Email { get; set; }

        [Required]
        public ICollection<Exercise>? Exercises { get; set; }
        [Required]
        public Patient? Patient { get; set; }
        [Required]
        public ICollection<ReminderAlert>? ReminderAlerts { get; set; }
        [Required]
        public ICollection<Education>? Educations { get; set; }
        [Required]
        public ICollection<Progress>? Progresses { get; set; }
    }
}



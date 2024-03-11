using System.ComponentModel.DataAnnotations;

namespace Diabetes2.Data.Entities
{
    public class HealthcareP
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre del médico")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Description { get; set; }

        public string? Name { get; set; }

        [Required]
        [Display(Name = "Profesión")]
        public string? profession { get; set; }

        [Required]
        public Patient? Patient { get; set; }
    }
}

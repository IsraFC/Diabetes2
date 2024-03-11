using System.ComponentModel.DataAnnotations;

namespace Diabetes2.Data.Entities
{
    public class MealPlanning
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Receta")]
        [MaxLength(300, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Recipes { get; set; }

        [Required]
        [Display(Name = "Plan de alimentación")]
        [MaxLength(300, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? PMealPlans { get; set; }
    }
}

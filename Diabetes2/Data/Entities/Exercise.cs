using System.ComponentModel.DataAnnotations;

namespace Diabetes2.Data.Entities
{
    public class Exercise
    {
        public int Id { get; set; }


        [Required]
        [Display(Name = "Rutina de ejercicios")]
        [MaxLength(400, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? ExerciseRoutines { get; set; }

        [Required]
        [Display(Name = "Duración (minutos)")]
        public int DurationInMinutes { get; set; }

        [Required]
        [Display(Name = "Fecha")]
        public DateTime Date { get; set; }

    }
}

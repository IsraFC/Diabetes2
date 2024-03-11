using System.ComponentModel.DataAnnotations;

namespace Diabetes2.Data.Entities
{
    public class GlucoseMonitoring
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Datos de la glucosa")]
        public float? GlucoseIn { get; set; }

        [Required]
        [Display(Name = "Registro de aliementos")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? FoodReport { get; set; }

        public string ExerciseAlert
        {
            get
            {
                if (GlucoseIn.HasValue && GlucoseIn > 180) 
                {
                    return "¡Alerta! Se recomienda realizar ejercicio para controlar el nivel de glucosa.";
                }
                else
                {
                    return string.Empty; 
                }

            }
        }
    }
}
    

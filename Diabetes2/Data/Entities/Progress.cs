using System.ComponentModel.DataAnnotations;

namespace Diabetes2.Data.Entities
{
    public class Progress
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Gráficos de progreso")]
        public List<string>? Graphics { get; set; }

        [Required]
        [Display(Name = "Estadísticas de salud")]
        public string? HealthStadistics { get; set; }

        [Required]
        public Patient? Patient { get; set; }
        [Required]
        public User? User { get; set; }
    }
}

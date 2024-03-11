using System.ComponentModel.DataAnnotations;

namespace Diabetes2.Data.Entities
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Edad")]
        public int? Age { get; set; }

        [Required]
        [Display(Name = "Género")]
        public char? Gender { get; set; }

        [Required]
        [Display(Name = "Peso")]
        public float? Weight { get; set; }

        [Required]
        [Display(Name = "Estatura")]
        public double? Height { get; set; }

        [Required]
        public User? User { get; set; }
        [Required]
        public GlucoseMonitoring? GlucoseMonitorings { get; set; }
        [Required]
        public ICollection<HealthcareP>? HealthcarePs { get; set; }
        [Required]
        public MealPlanning? MealPlanning { get; set; }
        [Required]
        public ICollection<Progress>? Progresses { get; set; }
    }
}

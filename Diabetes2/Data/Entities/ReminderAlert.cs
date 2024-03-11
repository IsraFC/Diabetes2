using System.ComponentModel.DataAnnotations;

namespace Diabetes2.Data.Entities
{
    public class ReminderAlert
    {
        public int Id { get; set; }

        [Required]  
        [Display(Name = "Recordatorio de Medicamentos")]
        [DataType(DataType.Time)]
        public DateTime HoraRecordatorio { get; set; }

        [Required]
        [Display(Name = "Seguimiento de la Dieta")]
        public string? SeguimientoDieta { get; set; }

        [Required]
        public User? User { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Diabetes2.Data.Entities
{
    public class Education
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Módulos educativos")]
        public List<string>? EducationalModules { get; set; }

        [Required]
        [Display(Name = "Enlaces multimedia")]
        public List<string>? MultimediaLinks { get; set; }
    }
}

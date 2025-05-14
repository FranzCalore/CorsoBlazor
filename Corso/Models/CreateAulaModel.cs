using System.ComponentModel.DataAnnotations;

namespace Corso.Models
{
    public class CreateAulaModel
    {
        [Required]
        [MinLength(1), MaxLength(30)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [Range(10, 500)]
        public int Posti { get; set; }
    }
}

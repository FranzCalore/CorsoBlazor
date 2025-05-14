using System.ComponentModel.DataAnnotations;

namespace Corso.Services.DTOs
{
    public class CreateAulaDTO
    {
        public string Nome { get; set; } = string.Empty;

        public int Posti { get; set; }
    }
}

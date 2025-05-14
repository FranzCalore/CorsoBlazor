
using Corso.Services.DTOs;

namespace Corso.Services
{
    public interface IAulaService
    {
        Task<List<AulaDTO>> GetAuleAsync();
        Task<AulaDTO> GetAulaByIdAsync(int id);
        Task<AulaDTO> AddAulaAsync(CreateAulaDTO dto);
        Task<AulaDTO> UpdateAulaAsync(UpdateAulaDTO dto);
        Task<bool> DeleteAulaAsync(int id);
    }
}

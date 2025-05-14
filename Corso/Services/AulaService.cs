using Corso.Data.DAL;
using Corso.Data.Repositories;
using Corso.Services.DTOs;
using Mapster;

namespace Corso.Services
{
    public class AulaService : IAulaService
    {
        private readonly IAulaRepository _repository;

        public AulaService(IAulaRepository repository)
        {
            _repository = repository;
        }

        public async Task<AulaDTO> AddAulaAsync(CreateAulaDTO dto)
        {
            try
            {
                Aula aula = dto.Adapt<Aula>();
                aula = await _repository.AddAulaAsync(aula);
                AulaDTO aulaDTO = aula.Adapt<AulaDTO>();
                return aulaDTO;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> DeleteAulaAsync(int id)
        {
            try
            {         
                return await _repository.DeleteAulaAsync(id);
            }
            catch
            {
                throw;
            }
        }

        public async Task<AulaDTO> GetAulaByIdAsync(int id)
        {
            try
            {
                Aula aula = await _repository.GetAulaByIdAsync(id);
                AulaDTO aulaDTO = aula.Adapt<AulaDTO>();
                return aulaDTO;
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<AulaDTO>> GetAuleAsync()
        {
            List<Aula> aule = await _repository.GetAuleAsync();
            List<AulaDTO> auleDTO = aule.Adapt<List<AulaDTO>>();
            return auleDTO;
        }

        public async Task<AulaDTO> UpdateAulaAsync(UpdateAulaDTO dto)
        {
            try
            {
                Aula aula = dto.Adapt<Aula>();
                aula = await _repository.UpdateAulaAsync(aula);
                AulaDTO aulaDTO = aula.Adapt<AulaDTO>();
                return aulaDTO;
            }
            catch
            {
                throw;
            }

        }
    }
}

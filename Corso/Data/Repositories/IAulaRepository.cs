using Corso.Data.DAL;

namespace Corso.Data.Repositories
{
    public interface IAulaRepository
    {
        public Task<List<Aula>> GetAuleAsync();
        public Task<Aula> GetAulaByIdAsync(int id);
        public Task<Aula> AddAulaAsync(Aula aula);
        public Task<Aula> UpdateAulaAsync(Aula aula);
        public Task<bool> DeleteAulaAsync(int id);

    }
}

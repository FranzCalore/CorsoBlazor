using Corso.Data.DAL;
using Microsoft.EntityFrameworkCore;

namespace Corso.Data.Repositories
{
    public class AulaRepository : IAulaRepository
    {
        private readonly AppDbContext _context;

        public AulaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Aula> AddAulaAsync(Aula aula)
        {
            Aula entity = (await _context.Aule.AddAsync(aula)).Entity;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Aula> UpdateAulaAsync(Aula aula)
        {
            Aula entity = _context.Aule.Update(aula).Entity;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAulaAsync(int id)
        {
            Aula? aula = await _context.Aule.FirstOrDefaultAsync(a => a.Id == id);
            if (aula == null)
            {
                return false;
            }

            _context.Aule.Remove(aula);
            await _context.SaveChangesAsync();
            return true;
        }

        public Task<Aula> GetAulaByIdAsync(int id)
        {
            return _context.Aule
                .FirstAsync(a => a.Id == id);
        }

        public Task<List<Aula>> GetAuleAsync()
        {
            return _context.Aule.ToListAsync();
        }
    }
}

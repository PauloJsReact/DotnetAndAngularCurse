using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proeventos.Domain;
using Proeventos.Percistence.Contextos;
using Proeventos.Percistence.Contratos;
using ProEventos.Domain;

namespace Proeventos.Percistence
{
    public class GeralPersist : IGeralPersist
    {
        private readonly ProEventosContext _context;
        public GeralPersist(ProEventosContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }

        public async Task<bool> SaveChangeAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

    }
}
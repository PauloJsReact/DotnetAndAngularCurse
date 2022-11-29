using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proeventos.Percistence.Contextos;
using Proeventos.Percistence.Contratos;
using ProEventos.Domain;

namespace Proeventos.Percistence
{
    public class EventosPersist : IEventoPersist
    {
        private readonly ProEventosContext _context;
        public EventosPersist(ProEventosContext context)
        {
            _context = context;
        }

        public async Task<Evento[]> GetAllEventosAsync(bool includePalestrante = false)
        {
            IQueryable<Evento> query = _context.Eventos
            .Include(e => e.Lotes)
            .Include(e => e.RedesSocials);

            if (includePalestrante)
            {
                query = query
                .Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Palestrante);
            }

            query.AsNoTracking().OrderBy(e => e.Id);
            return await query.ToArrayAsync();
        }

        public async Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante = false)
        {
            IQueryable<Evento> query = _context.Eventos
                                    .Include(e => e.Lotes)
                                    .Include(e => e.RedesSocials);

            if (includePalestrante)
            {
                query = query
                .Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Palestrante);
            }

            query.AsNoTracking().OrderBy(e => e.Id)
                .Where(e => e.Tema.ToLower().Contains(tema.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrante = false)
        {

            IQueryable<Evento> query = _context.Eventos
                                    .Include(e => e.Lotes)
                                    .Include(e => e.RedesSocials);

            if (includePalestrante)
            {
                query = query
                .Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Palestrante);
            }

            query.AsNoTracking().OrderBy(e => e.Id)
                .Where(e => e.Id == eventoId);

            return await query.FirstAsync();
        }

    }
}
using System.Threading.Tasks;
using Proeventos.Domain;
using ProEventos.Domain;

namespace Proeventos.Percistence.Contratos
{
    public interface IEventoPersist
    {
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante = false);
        Task<Evento[]> GetAllEventosAsync(bool includePalestrante = false);
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrante = false);

    }
}
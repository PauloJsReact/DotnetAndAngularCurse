using System.Threading.Tasks;
using Proeventos.Domain;
using ProEventos.Domain;

namespace Proeventos.Percistence.Contratos
{
    public interface IPalestrantePersist
    {
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAscync(bool includeEventos);
        Task<Palestrante> GetPalestranteByIdAscync(int palestranteId, bool includeEventos);
    }
}
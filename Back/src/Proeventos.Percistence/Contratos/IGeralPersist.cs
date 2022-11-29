using System.Threading.Tasks;
using Proeventos.Domain;
using ProEventos.Domain;

namespace Proeventos.Percistence.Contratos
{
    public interface IGeralPersist
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void DeleteRange<T>(T entity) where T : class;
        Task<bool> SaveChangeAsync();
    }
}
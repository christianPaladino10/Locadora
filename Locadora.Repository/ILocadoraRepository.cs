using Locadora.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Repository
{
    public interface ILocadoraRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        Task<Streaming[]> GetAllStreamingAsync(bool includeGenero, bool includeAtor);
        Task<Cliente> GetClienteAsyncById(int id);
    }
}

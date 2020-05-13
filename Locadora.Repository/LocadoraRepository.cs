using Locadora.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Repository
{
    public class LocadoraRepository : ILocadoraRepository
    {
        private readonly LocadoraContext _context;
        public LocadoraRepository(LocadoraContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Streaming[]> GetAllStreamingAsync(bool includeGenero, bool includeAtor)
        {
            IQueryable<Streaming> query = _context.Streaming
                .Include(x => x.TipoStreaming);

            if (includeGenero)
            {
                query = query
                    .Include(p => p.GeneroStreaming)
                    .ThenInclude(pa => pa.Genero);
            }
            if (includeAtor)
            {
                query = query
                    .Include(p => p.StreamingAtor)
                    .ThenInclude(pa => pa.Ator);
            }

            query = query.OrderByDescending(c => c.DataLancamento);

            return await query.ToArrayAsync();
        }

        public async Task<Cliente> GetClienteAsyncById(int id)
        {
            IQueryable<Cliente> query = _context.Cliente
                .Include(x => x.Plano);

            query = query.Where(c => c.ClienteId == id);

            return await query.FirstOrDefaultAsync();
        }
    }
}

using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using prova_dev_API.Models;

namespace prova_dev_API.Data
{
    public class Repository : IRpository
    {
        private readonly DataContent _context;

        public Repository(DataContent context)
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
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public Task<cadastro[]> GetAllcadastroAsync(bool includeProfessor)
        {
            throw new System.NotImplementedException();
        }

        public Task<cadastro[]> GetcadastroAsyncById(int Id, bool includenome)
        {
            throw new System.NotImplementedException();
        }
    }
}
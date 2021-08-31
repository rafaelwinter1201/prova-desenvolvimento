using System.Threading.Tasks;
using prova_dev_API.Models;

namespace prova_dev_API.Data
{
    public interface IRpository
    {
          //GERAL
                void Add<T>(T entity) where T : class;
                void Update<T>(T entity) where T : class;
                void Delete<T>(T entity) where T : class;
                Task<bool> SaveChangesAsync();

                //CADASTRO 
                Task<cadastro[]> GetAllcadastroAsync(bool includecpf);        
        
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Jabi.BookStore.Entity.Authors
{
    public interface IAuthorRepository : IRepository<Author, int>
    {
        Task<Author> FindByNameAsync(string name);

        Task<List<Author>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null
        );
    }
}
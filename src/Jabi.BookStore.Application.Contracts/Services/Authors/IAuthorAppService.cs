using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Jabi.BookStore.Services.Authors
{
    public interface IAuthorAppService : IApplicationService
    {
        Task<AuthorDto> GetAsync(int id);

        Task<PagedResultDto<AuthorDto>> GetListAsync(GetAuthorListDto input);

        Task<AuthorDto> CreateAsync(CreateAuthorDto input);

        Task UpdateAsync(int id, UpdateAuthorDto input);

        Task DeleteAsync(int id);
    }
}
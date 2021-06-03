using Volo.Abp.Application.Dtos;

namespace Jabi.BookStore.Services.Authors
{
    public class GetAuthorListDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
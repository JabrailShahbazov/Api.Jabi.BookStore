using Volo.Abp.Application.Dtos;

namespace Jabi.BookStore.Services.Books
{
    public class AuthorLookupDto : EntityDto<int>
    {
        public string Name { get; set; }
    }
}
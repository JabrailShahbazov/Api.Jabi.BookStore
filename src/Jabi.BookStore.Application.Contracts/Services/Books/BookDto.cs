using System;
using Jabi.BookStore.Books;
using Volo.Abp.Application.Dtos;

namespace Jabi.BookStore.Services.Books
{
    public class BookDto : AuditedEntityDto<int>
    {
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public string Description { get; set; }

        public int AuthorId { get; set; }

        public string AuthorName { get; set; }
    }
}
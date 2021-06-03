using System;
using Jabi.BookStore.Books;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Jabi.BookStore.Entity.Books
{
    public class Book : AuditedAggregateRoot<int>, ISoftDelete
    {
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
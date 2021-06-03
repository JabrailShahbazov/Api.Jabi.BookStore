using System;
using Volo.Abp.Domain.Entities;

namespace Jabi.BookStore.Services.Books
{
    public class UpdateBookDto :Entity<int>
    {
       
        public DateTime PublishDate { get; set; }
        public string Description { get; set; }
    }
}
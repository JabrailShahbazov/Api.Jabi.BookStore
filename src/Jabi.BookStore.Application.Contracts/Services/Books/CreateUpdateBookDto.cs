using System;
using System.ComponentModel.DataAnnotations;
using Jabi.BookStore.Books;

namespace Jabi.BookStore.Services.Books
{
    public class CreateUpdateBookDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public BookType Type { get; set; } = BookType.Undefined;

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [StringLength(200)]
        public string Description { get; set; }
        public int AuthorId { get; set; }
    }
}
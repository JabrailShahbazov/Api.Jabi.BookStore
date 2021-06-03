using AutoMapper;
using Jabi.BookStore.Entity.Authors;
using Jabi.BookStore.Entity.Books;
using Jabi.BookStore.Services.Authors;
using Jabi.BookStore.Services.Books;

namespace Jabi.BookStore
{
    public class BookStoreApplicationAutoMapperProfile : Profile
    {
        public BookStoreApplicationAutoMapperProfile()
        {
            
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();

            CreateMap<Author, AuthorDto>();

            CreateMap<Author, AuthorLookupDto>();
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
        }
    }
}

using System;
using System.Threading.Tasks;
using Jabi.BookStore.Books;
using Jabi.BookStore.Entity.Authors;
using Jabi.BookStore.Entity.Books;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Jabi.BookStore
{
    public class BookStoreTestDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Book, int> _bookRepository;
        private readonly IRepository<Author, int> _authorRepository;

        public BookStoreTestDataSeedContributor(IRepository<Book, int> bookRepository, IRepository<Author, int> authorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }

        public Task SeedAsync(DataSeedContext context)
        {
            _authorRepository.InsertAsync(
                new Author(name: "Test Author1",
                    birthDate: new DateTime(2021, 2, 3),
                    shortBio: "Test Bio1")
                );
            _authorRepository.InsertAsync(
                new Author(name: "Test Author2",
                    birthDate: new DateTime(2022, 2, 3),
                    shortBio: "Test Bio2")
                );
            _authorRepository.InsertAsync(
                new Author(name: "Test Author3",
                    birthDate: new DateTime(2023, 2, 3),
                    shortBio: "Test Bio3")
                );


            /*Books*/
            _bookRepository.InsertAsync(
                new Book
                {
                    Name = "Test Book1",
                    Type = BookType.Adventure,
                    PublishDate = new DateTime(2021,1,1),
                    Description = "Test Description1",
                    IsDeleted = false,
                    AuthorId = 1
                }
            );  
            _bookRepository.InsertAsync(
                new Book
                {
                    Name = "Test Book2",
                    Type = BookType.Adventure,
                    PublishDate = new DateTime(2022,2,2),
                    Description = "Test Description2",
                    IsDeleted = false,
                    AuthorId = 2
                }
            ); 
            _bookRepository.InsertAsync(
                new Book
                {
                    Name = "Test Book3",
                    Type = BookType.Adventure,
                    PublishDate = new DateTime(2023,3,3),
                    Description = "Test Description3",
                    IsDeleted = false,
                    AuthorId = 3
                }
            );

            return Task.CompletedTask;
        }
    }
}
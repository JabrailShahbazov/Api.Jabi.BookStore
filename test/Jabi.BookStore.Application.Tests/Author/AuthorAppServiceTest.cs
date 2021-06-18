using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jabi.BookStore.Services.Authors;
using Microsoft.EntityFrameworkCore.Infrastructure;
using NSubstitute;
using NSubstitute.Extensions;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Xunit;

namespace Jabi.BookStore.Author
{
    public sealed class AuthorAppServiceTest : BookStoreApplicationTestBase
    {
        private readonly IAuthorAppService _authorAppService;
        public AuthorAppServiceTest()
        {
            _authorAppService = GetRequiredService<IAuthorAppService>();
        }

        [Fact]
        public async Task CreateAsync_InsertAuthor_ReturnCreateAuthorDto()
        {
            var service = _authorAppService.CreateAsync(new CreateAuthorDto()
            {
                BirthDate = new DateTime(2323,3,23),
                Name = "Jabi",
                ShortBio = "Salam"
            });
             await service.ShouldNotBeNull();
        }

        [Fact]
        public async Task GetListAsync_IsNullOrWhiteSpace_ReturnAuthorName()
        {
            //Act
            var result = await _authorAppService.GetListAsync(
                new GetAuthorListDto()
            );

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(b => b.Name == "Test Author1");
        }

        [Theory]
        [InlineData(2)]
        public async Task UpdateAsync_UpdateAuthor_ReturnUpdateAuthorDto(int authorId)
        {
            var service = _authorAppService.UpdateAsync(authorId, new UpdateAuthorDto()
            {
                BirthDate = new DateTime(2323, 3, 23),
                ShortBio = "Salam"
            });
            await service.ShouldNotBeNull();
            //service.ShouldBeOfType<UpdateAuthorDto>();
        }

        [Theory]
        [InlineData(2)]
        public async Task DeleteAsync_DeleteAuthor_ReturnDeletedAuthor(int authorId)
        {
            var service = _authorAppService.DeleteAsync(authorId);
          await  service.ShouldNotBeNull();
        }

        [Theory]
        [InlineData(2)]
        public async Task GetAsync_GetAuthorWithId_ReturnGetAuthor(int authorId)
        {
            var service = _authorAppService.GetAsync(authorId);
            await service.ShouldNotBeNull();
        }

    }
}

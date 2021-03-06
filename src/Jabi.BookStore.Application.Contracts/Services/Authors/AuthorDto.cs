using System;
using Volo.Abp.Application.Dtos;

namespace Jabi.BookStore.Services.Authors
{
    public class AuthorDto : EntityDto<int>
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string ShortBio { get; set; }
    }
}
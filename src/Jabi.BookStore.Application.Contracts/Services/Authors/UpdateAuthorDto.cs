using System;
using System.ComponentModel.DataAnnotations;

namespace Jabi.BookStore.Services.Authors
{
    public class UpdateAuthorDto
    {
  

        [Required]
        public DateTime BirthDate { get; set; }

        public string ShortBio { get; set; }
    }
}
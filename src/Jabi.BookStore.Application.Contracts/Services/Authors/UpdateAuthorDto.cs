using System;
using System.ComponentModel.DataAnnotations;

namespace Jabi.BookStore.Services.Authors
{
    public class UpdateAuthorDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string ShortBio { get; set; }
    }
}
using System;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Jabi.BookStore.Entity.Authors
{
    public class Author : FullAuditedAggregateRoot<int>
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; set; }
        public string ShortBio { get; set; }

        private Author()
        {
            /* This constructor is for deserialization / ORM purpose */
        }

        internal Author(
          
            [NotNull] string name,
            DateTime birthDate,
            [CanBeNull] string shortBio = null)
            : base()
        {
            SetName(name);
            BirthDate = birthDate;
            ShortBio = shortBio;
        }

        internal Author ChangeName([NotNull] string name)
        {
            SetName(name);
            return this;
        }

        private void SetName([NotNull] string name)
        {
            Name = Check.NotNullOrWhiteSpace(
                name,
                nameof(name),
                maxLength: 50
            );
        }
    }
}
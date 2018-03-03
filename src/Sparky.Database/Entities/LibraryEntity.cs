using System;
using Sparky.Database.Data;

namespace Sparky.Database.Entities
{
    public class LibraryEntity
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public LibraryType Type { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }
    }
}

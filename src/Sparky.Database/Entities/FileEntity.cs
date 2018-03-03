using System;
using Sparky.Database.Data;

namespace Sparky.Database.Entities
{
    public class FileEntity
    {
        public long Id { get; set; }

        public FileType Type { get; set; }

        public string Path { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }
    }
}

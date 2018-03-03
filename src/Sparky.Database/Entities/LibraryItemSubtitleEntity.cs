using System;

namespace Sparky.Database.Entities
{
    public class LibraryItemSubtitleEntity
    {
        public long Id { get; set; }

        public long LibraryItemId { get; set; }
        public LibraryItemEntity LibraryItem { get; set; }

        public string LanguageCode { get; set; }

        public FileEntity File { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }
    }
}

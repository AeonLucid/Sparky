using System;
using System.Collections.Generic;

namespace Sparky.Database.Entities
{
    /// <summary>
    ///     This represents either a Movie or a TvShow Episode
    ///     depending on <see cref="LibraryEntity.Type"/>.
    /// </summary>
    public class LibraryItemEntity
    {
        public long Id { get; set; }

        public long LibraryId { get; set; }
        public LibraryEntity Library { get; set; }

        public string Title { get; set; }

        public string Synopsis { get; set; }

        public long MediaFileId { get; set; }
        public FileEntity MediaFile { get; set; }

        public List<LibraryItemSubtitleEntity> Subtitles { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }
    }
}

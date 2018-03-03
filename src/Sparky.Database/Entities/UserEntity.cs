using System;

namespace Sparky.Database.Entities
{
    public class UserEntity
    {
        public long Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }
    }
}

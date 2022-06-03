using EntityPOC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EntityPOC.Data.DataSeeds
{
    public class BoardSeeds : IEntityTypeConfiguration<Board>
    {
        public void Configure(EntityTypeBuilder<Board> builder)
        {
            var uri = new Uri("https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/projects?tabs=dotnet-core-cli");
            var defaultBoard = new Board("Default - Board", uri) { 
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Description = "Default board created by data seeds",
                Id = 1500
            };

            builder.HasData(defaultBoard);
        }
    }
}

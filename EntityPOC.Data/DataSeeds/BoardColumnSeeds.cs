using EntityPOC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EntityPOC.Data.DataSeeds
{
    public class BoardColumnSeeds : IEntityTypeConfiguration<BoardColumn>
    {
        public void Configure(EntityTypeBuilder<BoardColumn> builder)
        {
            
             var backlogColumn = new BoardColumn("Red", "Backlog", "To-Dos") { 
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Description = "Default backlog column",
                Id = 1500,
                BoardId = 1500
            };

            var inProgressColumn = new BoardColumn("Blue", "Current", "Working on")
            {
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Description = "Default Current column",
                Id = 1501,
                BoardId = 1500
            };

            var doneColumn = new BoardColumn("Green", "Done", "Completed")
            {
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Description = "Default Done column",
                Id = 1502,
                BoardId = 1500
            };

            builder.HasData(backlogColumn, inProgressColumn, doneColumn);
        }
    }
}

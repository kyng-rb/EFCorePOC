using EntityPOC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EntityPOC.Data.DataSeeds
{
    public class CardSeeds : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            var now = DateTime.UtcNow;
            var uri = new Uri("https://futbollibre.net/inicio/?tv");

            var cards = new List<Card>()
            {
                new Card("Backog card 1", uri, uri, "Reynaldo")
                {
                    Id = 1000,
                    BoardColumnId = 1500,
                    Description = "Test Description",
                    CreatedAt = now,
                    UpdatedAt = now,
                },
                new Card("Backog card 2", uri, uri, "Reynaldo")
                {
                    Id = 1001,
                    BoardColumnId = 1500,
                    Description = "Test Description 2",
                    CreatedAt = now,
                    UpdatedAt = now,
                },
                new Card("Backog card 3", uri, uri, "Reynaldo")
                {
                    Id = 1002,
                    BoardColumnId = 1500,
                    Description = "Test Description 3",
                    CreatedAt = now,
                    UpdatedAt = now,
                },
                new Card("Current card 1", uri, uri, "Reynaldo")
                {
                    Id = 1003,
                    BoardColumnId = 1501,
                    Description = "Test Description for Current",
                    CreatedAt = now,
                    UpdatedAt = now,
                },
                new Card("Current card 2", uri, uri, "Reynaldo")
                {
                    Id = 1004,
                    BoardColumnId = 1501,
                    Description = "Test Description for Current 2",
                    CreatedAt = now,
                    UpdatedAt = now,
                },
                new Card("Current card 3", uri, uri, "Reynaldo")
                {
                    Id = 1005,
                    BoardColumnId = 1501,
                    Description = "Test Description for Current 3",
                    CreatedAt = now,
                    UpdatedAt = now,
                },
                new Card("Done card 1", uri, uri, "Reynaldo")
                {
                    Id = 1006,
                    BoardColumnId = 1502,
                    Description = "Test Description for Done",
                    CreatedAt = now,
                    UpdatedAt = now,
                },
                new Card("Done card 2", uri, uri, "Reynaldo")
                {
                    Id = 1007,
                    BoardColumnId = 1502,
                    Description = "Test Description for Done 2",
                    CreatedAt = now,
                    UpdatedAt = now,
                },
                new Card("Done card 3", uri, uri, "Reynaldo")
                {
                    Id = 1008,
                    BoardColumnId = 1502,
                    Description = "Test Description for Done 3",
                    CreatedAt = now,
                    UpdatedAt = now,
                }
            };

            builder.HasData(cards);
        }
    }
}

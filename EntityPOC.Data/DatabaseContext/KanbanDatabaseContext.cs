using EntityPOC.Data.DataSeeds;
using EntityPOC.Data.EntityConfigurations;
using EntityPOC.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityPOC.Data.DatabaseContext
{
    public class KanbanDatabaseContext : DbContext
    {

        public KanbanDatabaseContext(DbContextOptions<KanbanDatabaseContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyDataSeeds();
            modelBuilder.ApplyEntityConfigurations();

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Board> Boards { get; set; } = null!;
        public virtual DbSet<BoardColumn> BoardColumns { get; set; } = null!;
        public virtual DbSet<Card> Cards { get; set; } = null!;
    }
}

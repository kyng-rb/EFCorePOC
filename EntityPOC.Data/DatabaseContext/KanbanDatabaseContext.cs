using System;
using System.Threading;
using System.Threading.Tasks;
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

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			foreach (var auditableEntity in ChangeTracker.Entries<BaseEntity>())
			{
				if (auditableEntity.State == EntityState.Added)
				{
					auditableEntity.Entity.CreatedAt = DateTime.UtcNow;
					auditableEntity.Entity.UpdatedAt = DateTime.UtcNow;
				}

				if (auditableEntity.State == EntityState.Added)
				{
					auditableEntity.Entity.UpdatedAt = DateTime.UtcNow;
				}

				if (auditableEntity.State == EntityState.Deleted)
				{
					auditableEntity.Entity.DeletedAt = DateTime.UtcNow;
					auditableEntity.State = EntityState.Modified;
				}

			}
			return base.SaveChangesAsync(cancellationToken);
		}
		public virtual DbSet<Board> Boards { get; set; } = null!;
		public virtual DbSet<BoardColumn> BoardColumns { get; set; } = null!;
		public virtual DbSet<Card> Cards { get; set; } = null!;
		public virtual DbSet<Label> Labels { get; set; } = null!;
	}
}

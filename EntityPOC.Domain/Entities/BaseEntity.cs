using System;

namespace EntityPOC.Domain.Entities
{
	public abstract class BaseEntity
	{
        protected BaseEntity(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
		public string? Description { get; set; }
		public int Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
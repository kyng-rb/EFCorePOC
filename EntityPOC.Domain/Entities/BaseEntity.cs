using System;
using System.Text.Json.Serialization;

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

		[JsonIgnore]
		public DateTime CreatedAt { get; set; }
		[JsonIgnore]
		public DateTime UpdatedAt { get; set; }
		[JsonIgnore]
		public DateTime? DeletedAt { get; set; }
	}
}
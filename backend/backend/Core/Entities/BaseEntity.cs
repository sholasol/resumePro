using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Core.Entities
{
	public abstract class BaseEntity //abstract => it can only be inherited
	{
		[Key]

		public long ID { get; set; }

		public DateTime CreatedAt { get; set; } = DateTime.Now;

		public DateTime UpdatedAt { get; set; } = DateTime.Now;

		public bool IsActive { get; set; } = true;
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityPOC.Domain.Entities
{
	public class Label : BaseEntity
	{
		public Label(string name, Uri backgroundImage) : base(name)
		{
			BackgroundImage = backgroundImage;
		}

		public Uri BackgroundImage { get; set; }

		public virtual IEnumerable<Card>? Cards { get; set; }
	}
}
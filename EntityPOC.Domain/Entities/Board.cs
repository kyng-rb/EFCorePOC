using System;
using System.Collections.Generic;

namespace EntityPOC.Domain.Entities
{
    public class Board : BaseEntity
	{
        public Uri Image { get; set; }

        public Board(string name, Uri image)
            : base(name)
        {
            Image = image;
        }

        public virtual IEnumerable<BoardColumn>? BoardColumns { get; set; }
    }
}
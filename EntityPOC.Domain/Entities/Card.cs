using System;

namespace EntityPOC.Domain.Entities
{
    public class Card : BaseEntity
    {
        public Card(string name, Uri image, Uri attachment, string owner)
            : base(name)
        {
            Name = name;
            Image = image;
            Attachment = attachment;
            Owner = owner;
        }

        public Uri Image { get; set; }
        public Uri Attachment { get; set; }
        public string Owner { get; set; }
        public int BoardColumnId { get; set; }

        public virtual BoardColumn BoardColumn { get; set; } = null!;
    }
}

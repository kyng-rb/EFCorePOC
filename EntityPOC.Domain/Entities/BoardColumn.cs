using System.Collections.Generic;

namespace EntityPOC.Domain.Entities
{
    public class BoardColumn : BaseEntity
    {
        public BoardColumn(string color, string header, string name): 
            base(name)
        {
            Color = color;
            Header = header;
        }

        public string Color { get; set; }
        public string Header { get; set; }
        public int BoardId { get; set; }

        public virtual IEnumerable<Card>? Cards { get; set; } = null!;
        public virtual Board Board { get; set; } = null!;
    }
}

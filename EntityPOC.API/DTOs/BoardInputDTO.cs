using System;

namespace EntityPOC.API.DTOs
{
    public class BoardInputDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri Image { get; set; }
    }
}

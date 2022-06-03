using System;

namespace EntityPOC.API.DTOs
{
    public class BoardOutputDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri Image { get; set; }
    }
}

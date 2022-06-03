using Microsoft.EntityFrameworkCore;

namespace EntityPOC.Data.EntityConfigurations
{
    public static class EntityConfigurationExtensions
    {
        public static void ApplyEntityConfigurations(this ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BoardConfiguration());
            builder.ApplyConfiguration(new BoardColumnConfiguration());
            builder.ApplyConfiguration(new CardConfiguration());
        }
    }
}

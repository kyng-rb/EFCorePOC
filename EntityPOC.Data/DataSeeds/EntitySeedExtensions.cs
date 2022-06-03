using Microsoft.EntityFrameworkCore;

namespace EntityPOC.Data.DataSeeds
{
    public static class EntitySeedExtensions
    {
        public static void ApplyDataSeeds(this ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BoardSeeds());
            builder.ApplyConfiguration(new BoardColumnSeeds());
            builder.ApplyConfiguration(new CardSeeds());
        }
    }
}

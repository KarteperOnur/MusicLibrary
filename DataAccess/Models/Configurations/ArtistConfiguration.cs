using DataAccess.Models.Entities;
using DataAccess.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.Property(x => x.ArtistName).IsRequired(true);
            builder.Property(x => x.ArtistName).HasMaxLength(255);
            builder.HasKey(x => x.ID);

            builder.HasMany(x => x.Songs)
                   .WithOne(x => x.Artist)
                   .HasForeignKey(x => x.ArtistID);

            builder.HasData(ArtistSeed.Artists);

        }
    }
}

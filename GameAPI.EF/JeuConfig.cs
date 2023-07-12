using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities_POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAPI.EF
{
    public class JeuConfig : IEntityTypeConfiguration<Jeu>
    {
        public void Configure(EntityTypeBuilder<Jeu> builder)
        {
            builder.ToTable(t => t.HasCheckConstraint("CK_NOTE", "Note BETWEEN 0 AND 5"));
            builder.Property("Id").ValueGeneratedOnAdd();
            builder.HasKey(x => x.Id);

            builder.HasOne(j => j.Genre)
                   .WithMany(g => g.Jeux)
                   .HasForeignKey(g => g.GenreId);
            
        }
    }
}

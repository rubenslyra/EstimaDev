using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstimationApp.Models
{
    public class EstimateConfiguration : IEntityTypeConfiguration<Estimate>
    {
        public void Configure(EntityTypeBuilder<Estimate> builder)
        {
            builder.ToTable("Estimates"); // Nome da tabela
            builder.HasKey(e => e.Id); // Chave primária
            builder.Property(e => e.ProjectName).IsRequired().HasMaxLength(255);
            builder.Property(e => e.Description).HasMaxLength(400);
            builder.Property(e => e.BestCase).IsRequired();
            builder.Property(e => e.MostLikelyCase).IsRequired();
            builder.Property(e => e.WorstCase).IsRequired();
        }
    }
}

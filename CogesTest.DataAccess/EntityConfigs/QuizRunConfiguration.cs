using CogesTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CogesTest.DataAccess.EntityConfigs;

internal class QuizRunConfiguration : IEntityTypeConfiguration<QuizRun>
{
    public void Configure(EntityTypeBuilder<QuizRun> builder)
    {
        builder.ToContainer(nameof(QuizRun)).HasNoDiscriminator().HasKey(d => d.Id);

        builder.OwnsMany(qr => qr.Questions, questionBuilder => {
            questionBuilder.HasKey(q => q.Id);
            questionBuilder.OwnsMany(q => q.Options, optionsBuilder => {
                optionsBuilder.HasKey(o => o.Id);
            });
        });
    }
}

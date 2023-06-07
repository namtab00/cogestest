using CogesTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CogesTest.DataAccess.EntityConfigs;

internal class QuizDefinitionConfiguration : IEntityTypeConfiguration<QuizDefinition>
{
    public void Configure(EntityTypeBuilder<QuizDefinition> builder)
    {
        builder.ToContainer(nameof(QuizDefinition)).HasNoDiscriminator().HasKey(d => d.Id);

        builder.OwnsMany(quiz => quiz.Questions, questionBuilder => {
            questionBuilder.HasKey(q => q.Id);
            questionBuilder.OwnsMany(q => q.Options, optionsBuilder => {
                optionsBuilder.HasKey(o => o.Id);
            });
        });
    }
}

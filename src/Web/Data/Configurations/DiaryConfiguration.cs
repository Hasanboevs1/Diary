using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Models;

namespace Web.Data.Configurations;

public class DiaryConfiguration : IEntityTypeConfiguration<DiaryModel>
{
    public void Configure(EntityTypeBuilder<DiaryModel> builder)
    {
        var data = new List<DiaryModel>
        {
            new()
            {
                Id = 1,
                Title = "Goal",
                Content = "Without Goal, I have realized that I have nothing to do.",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = 2,
                Title = "Love",
                Content = "Without love, I have realized that I have nothing to do.",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = 3,
                Title = "Happiness",
                Content = "Without happiness, I have realized that I have nothing to do.",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = 4,
                Title = "Motivation",
                Content = "Without motivation, I have realized that I have nothing to do.",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }
        };
        builder.HasData(data);
    }
}

using Microsoft.EntityFrameworkCore;
using Web.Data.Configurations;
using Web.Models;

namespace Web.Data;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options){}

    public DbSet<DiaryModel> Diaries { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new DiaryConfiguration());
    }
}

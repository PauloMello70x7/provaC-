using Microsoft.EntityFrameworkCore;
using ProvaProver.DomainModel.Entity;
using ProvaProver.Infra.Mappings;

namespace ProvaProver.Infra.Context
{
    public class ProvaProverContext : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }

        public ProvaProverContext(DbContextOptions<ProvaProverContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContatoMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}

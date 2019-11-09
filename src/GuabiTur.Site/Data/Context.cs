using GuabiTur.Site.Models;
using Microsoft.EntityFrameworkCore;

namespace GuabiTur.Site.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
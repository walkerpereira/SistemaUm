using Microsoft.EntityFrameworkCore;
using SistemaUm.Models;

namespace SistemaUm.Data
{
    public class SistemaUmContext : DbContext
    {
        public SistemaUmContext(DbContextOptions<SistemaUmContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Aluno { get; set; }
    }
}

using EstudoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudoMVC.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Setor> Setor { get; set; }
    }
}

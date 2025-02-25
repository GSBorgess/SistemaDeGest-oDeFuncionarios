using Microsoft.EntityFrameworkCore;
using SistemaDeGestaoDeFuncionarios.Models;

namespace SistemaDeGestaoDeFuncionarios.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}

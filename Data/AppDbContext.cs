using Microsoft.EntityFrameworkCore;
using MyTodo.Models;

//de para com o banco de dados
//mapeamento do banco
namespace MyTodo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo>  Todos {get; set;} 

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlite(connectionString:"DataSource=app.db;Cache=Shared");

    }
}
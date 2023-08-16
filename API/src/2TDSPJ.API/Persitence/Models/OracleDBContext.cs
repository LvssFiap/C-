using Microsoft.EntityFrameworkCore;

namespace _2TDSPJ.API.Persitence.Models
{
    public class OracleDBContext: DbContext
    {

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public OracleDBContext(DbContextOptions<OracleDBContext> options) : base(options) 
        {
            
        }


    }
}

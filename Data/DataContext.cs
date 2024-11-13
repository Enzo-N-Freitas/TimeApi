using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TimeApi.Models;
using TimeApi.Models.Enums;

namespace TimeApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Afazeres> TB_AFAZERES { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Afazeres>().ToTable("TB_AFAZERES");

            modelBuilder.Entity<Afazeres>().HasData
            (
                new Afazeres() { Id = 1, NomeAfazer = "Limpar a Casa", Descricao = "Varrer o chão, lavar o banheiro e tirar pó das estantes", TipodeAfazer=TipodeAfazerEnum.Domestico },
                new Afazeres() { Id = 2, NomeAfazer = "Terminar Apresentação", Descricao = "Terminar a apresentação para a equipe da empresa", TipodeAfazer=TipodeAfazerEnum.Trabalho },
                new Afazeres() { Id = 3, NomeAfazer = "Terminar a API", Descricao = "Finalizar a API da aula de DS e entregar no prazo", TipodeAfazer=TipodeAfazerEnum.Estudo }
            );
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(200);
        }
    }
}
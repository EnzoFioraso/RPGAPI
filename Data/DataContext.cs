using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RpgApi.Models;
using RpgApi.Models.Enuns;


namespace RpgApi.Data
{
    //inicio da prova

    //final

    public class DataContext : DbContext
    {
        //cctor --> Cria um construtor (Atalho)
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //sempre se programa dentro da classe (TODA CLASSE) 
        //propi cria essa estrutura de public
        public DbSet<Personagem> TB_PERSONAGENS { get; set; }
        public DbSet<Armas> TB_ARMAS { get; set; }

        protected override void /*ta criando um bancop de dados dentro do sql server*/OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>().ToTable("TB_PERSONAGENS");

            modelBuilder.Entity<Personagem>().HasData(

                new Personagem() { Id = 1, Nome = "Frodo", PontosVida = 100, Forca = 17, Defesa = 23, Inteligencia = 33, Classe = ClasseEnum.Cavaleiro },
            new Personagem() { Id = 2, Nome = "Sam", PontosVida = 100, Forca = 15, Defesa = 25, Inteligencia = 30, Classe = ClasseEnum.Cavaleiro },
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida = 100, Forca = 18, Defesa = 21, Inteligencia = 35, Classe = ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida = 100, Forca = 18, Defesa = 18, Inteligencia = 37, Classe = ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida = 100, Forca = 20, Defesa = 17, Inteligencia = 31, Classe = ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida = 100, Forca = 21, Defesa = 13, Inteligencia = 34, Classe = ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida = 100, Forca = 25, Defesa = 11, Inteligencia = 35, Classe = ClasseEnum.Mago }
            );
            modelBuilder.Entity<Armas>().ToTable("TB_ARMAS");

            modelBuilder.Entity<Armas>().HasData(
               new Armas() { Id = 1, Nome = "Ak47", Dano = 20, },
               new Armas() { Id = 2, Nome = "Pistola", Dano = 15, },
               new Armas() { Id = 3, Nome = "Desert", Dano = 17, },
               new Armas() { Id = 4, Nome = "Doze", Dano = 21, },
               new Armas() { Id = 5, Nome = "Espada", Dano = 11, },
               new Armas() { Id = 6, Nome = "Arco", Dano = 9, },
               new Armas() { Id = 7, Nome = "Escudo", Dano = 1, }
            );

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>()
            .HaveColumnType("varchar").HaveMaxLength(200);//assu,,ir um padrao
        }



    }
}
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Controllers;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Data
{
    public class DataContext: DbContext

    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
        
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDisciplina> AlunoDisciplinas { get; set; }

        protected  void OnModelCreatring(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>()
                .HasKey(AD => new { AD.ALunoId, AD.DisciplinaId });

            builder.Entity<Professor>()
                .HasData(new List<Professor>(){
                    new Professor() {ProfessorId =1, NomeProfessor ="Lauro"},
                    new Professor() {ProfessorId =2, NomeProfessor ="Roberto"},
                    new Professor() {ProfessorId =3, NomeProfessor ="Ronaldo"},
                    new Professor() {ProfessorId =4, NomeProfessor ="Rodrigo"},
                    new Professor() {ProfessorId =5, NomeProfessor ="Alexandre"}
                });

            builder.Entity<Disciplina>()
                .HasData(new List<Disciplina>{
                    new Disciplina() { DisciplinaId= 1, NomeDisciplina= "Matemática", IdQuemLeciona= 1 },
                    new Disciplina() {DisciplinaId= 2, NomeDisciplina= "Física", IdQuemLeciona= 2 },
                    new Disciplina() {DisciplinaId= 3, NomeDisciplina= "Português", IdQuemLeciona= 3 },
                    new Disciplina() {DisciplinaId= 4, NomeDisciplina= "Inglês", IdQuemLeciona= 4 },
                    new Disciplina() {DisciplinaId=5, NomeDisciplina= "Programação", IdQuemLeciona= 5 }
                });

            builder.Entity<Aluno>()
                .HasData(new List<Aluno>(){
                    new Aluno() {AlunooId= 1, Nome = "Marta", Sobrenome= "Kent", telefone= "33225555" },
                    new Aluno() {AlunooId= 2, Nome = "Paula", Sobrenome= "Isabela", telefone= "3354288" },
                    new Aluno() {AlunooId= 3, Nome = "Laura", Sobrenome= "Antonia", telefone= "55668899" },
                    new Aluno() {AlunooId= 4, Nome = "Luiza", Sobrenome= "Maria", telefone= "6565659" },
                    new Aluno() {AlunooId= 5, Nome = "Lucas", Sobrenome= "Machado", telefone= "565685415" },
                    new Aluno() {AlunooId = 6, Nome = "Pedro", Sobrenome=  "Alvares", telefone=  "456454545" },
                    new Aluno() {AlunooId = 7, Nome = "Paulo", Sobrenome=  "José",  telefone=  "9874512" }
                });

            builder.Entity<AlunoDisciplina>()
                .HasData(new List<AlunoDisciplina>() {
                    new AlunoDisciplina() {ALunoId = 1, DisciplinaId = 2 },
                    new AlunoDisciplina() {ALunoId = 1, DisciplinaId = 4 },
                    new AlunoDisciplina() {ALunoId = 1, DisciplinaId = 5 },
                    new AlunoDisciplina() {ALunoId = 2, DisciplinaId = 1 },
                    new AlunoDisciplina() {ALunoId = 2, DisciplinaId = 2 },
                    new AlunoDisciplina() {ALunoId = 2, DisciplinaId = 5 },
                    new AlunoDisciplina() {ALunoId = 3, DisciplinaId = 1 },
                    new AlunoDisciplina() {ALunoId = 3, DisciplinaId = 2 },
                    new AlunoDisciplina() {ALunoId = 3, DisciplinaId = 3 },
                    new AlunoDisciplina() {ALunoId = 4, DisciplinaId = 1 },
                    new AlunoDisciplina() {ALunoId = 4, DisciplinaId = 4 },
                    new AlunoDisciplina() {ALunoId = 4, DisciplinaId = 5 },
                    new AlunoDisciplina() {ALunoId = 5, DisciplinaId = 4 },
                    new AlunoDisciplina() {ALunoId = 5, DisciplinaId = 5 },
                    new AlunoDisciplina() {ALunoId = 6, DisciplinaId = 1 },
                    new AlunoDisciplina() {ALunoId = 6, DisciplinaId = 2 },
                    new AlunoDisciplina() {ALunoId = 6, DisciplinaId = 3 },
                    new AlunoDisciplina() {ALunoId = 6, DisciplinaId = 4 },
                    new AlunoDisciplina() {ALunoId = 7, DisciplinaId = 1 },
                    new AlunoDisciplina() {ALunoId = 7, DisciplinaId = 2 },
                    new AlunoDisciplina() {ALunoId = 7, DisciplinaId = 3 },
                    new AlunoDisciplina() {ALunoId = 7, DisciplinaId = 4 },
                    new AlunoDisciplina() {ALunoId = 7, DisciplinaId = 5 }
                });



        } 

             



    }
}

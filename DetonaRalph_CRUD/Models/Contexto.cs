using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DetonaRalph_CRUD.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Personagem> Personagens{ get; set; }
        public DbSet<Cenario> Cenarios { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
            this.Cenarios.AddRange(new Cenario { NomeCenario = "Entrada do Prédio no Jogo do Ralph", pathImg = "/img/predio_jogo.jpeg" }
                                , new Cenario { NomeCenario = "Telhado do Prédio no Jogo do Ralph", pathImg = "/img/telhado_jogo.jpeg" }
                                , new Cenario { NomeCenario = "Lago no Mundo Doce", pathImg = "/img/mundo_doce.jpeg" }
                                , new Cenario { NomeCenario = "Árvore no Mundo Doce", pathImg = "/img/mundo_doce2.jpeg" }
                                , new Cenario { NomeCenario = "Corrida no Mundo Doce", pathImg = "/img/mundo_doce3.jpeg" });
        }
    }
}

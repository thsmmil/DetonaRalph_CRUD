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
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DetonaRalph_CRUD.Models
{
    public class Personagem
    {
        public int PersonagemID { get; set; }
        public string NomePersonagem { get; set; }
        public int CenarioID{ get; set; }
        public Cenario Cenario{ get; set; }


    }
}

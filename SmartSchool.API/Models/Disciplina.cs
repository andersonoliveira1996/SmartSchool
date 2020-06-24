using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Disciplina
    {
        [Key]
        public int DisciplinaId { get; set; }

        public string NomeDisciplina { get; set; }

        public int IdQuemLeciona { get; set; }

    }
}

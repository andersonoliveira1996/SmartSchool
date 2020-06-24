using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Aluno
    {
      [Key]
        public int AlunooId { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string telefone { get; set; }
    }

}


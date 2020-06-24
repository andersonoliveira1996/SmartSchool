using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Professor
    {
        [Key]
        public int ProfessorId { get; set; }

        public string NomeProfessor { get; set; }


    }
}

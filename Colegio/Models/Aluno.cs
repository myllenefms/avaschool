using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Colegio.Models
{
    public class Aluno
    {
        public String nomeAluno { get; set; }
        public DateTime dataNascimentoAluno { get; set; }
        public int IdAluno { get; set; }
        public Turma turma { get; set; }
    }
}
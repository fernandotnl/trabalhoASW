using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoASW.Models
{
    public interface Perfil
    {
        ICollection<Nota> consultarNotasAluno(Aluno aluno);
        ICollection<Nota> consultarNotasTurma(Turma turma);
        ICollection<Nota> consultarNotasDisciplina(Disciplina disciplina);
        ICollection<Nota> consultarNotasPeriodo(Periodo periodo);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Aluno_POO_WF_03_11_2021
{
    class Lista_Aluno
    {
        List<Aluno> listaAluno = new List<Aluno>();

        public void AdicionarAluno(Aluno aluno)
        {
            this.listaAluno.Add(aluno);
                         
        }

        public void RemoverAluno(Aluno aluno)
        {
            this.listaAluno.Remove(aluno);
        }
    }
}

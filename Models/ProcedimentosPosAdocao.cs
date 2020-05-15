using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Models
{
    public class ProcedimentosPosAdocao
    {
        private string descricaoProc;
        private DateTime data;

        public string DescricaoProc { get => descricaoProc; set => descricaoProc = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}

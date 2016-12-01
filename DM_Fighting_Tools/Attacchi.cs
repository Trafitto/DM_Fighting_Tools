using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Fighting_Tools
{
    class Attacchi
    {
        string nome;
        string dadiDanno;

        public Attacchi(string nome, string dadiDanno)
        {
            this.nome = nome;
            this.dadiDanno = dadiDanno;
        }

        public string DadiDanno
        {
            get { return dadiDanno; }
            set { dadiDanno = value; }
        }
        public string Nome
        {
            get { return dadiDanno; }
            set { dadiDanno = value; }
        }
    }
}

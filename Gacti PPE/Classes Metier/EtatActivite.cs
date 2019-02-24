using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gacti_PPE
{
    public class EtatActivite
    {
        private string codeEtat;
        private string nomEtat;

        public EtatActivite(string codeEtat, string nomEtat)
        {
            this.CodeEtat = codeEtat;
            this.NomEtat = nomEtat;
        }

        public string CodeEtat { get => codeEtat; set => codeEtat = value; }
        public string NomEtat { get => nomEtat; set => nomEtat = value; }

        public override string ToString()
        {
            return this.codeEtat;
        }
    }
}

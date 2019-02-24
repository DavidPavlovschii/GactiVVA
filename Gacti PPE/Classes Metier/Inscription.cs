using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gacti_PPE
{
    public class Inscription
    {
        private int noInscrip;
        private String user;
        private String codeAnim;
        private String dateAct;
        private String dateInscrip;
        private String dateAnnule;

        public Inscription(int noInscrip, String user, String codeAnim, String dateAct, String dateInscrip, String dateAnnule)
        {
            this.NoInscrip = noInscrip;
            this.User = user;
            this.CodeAnim = codeAnim;
            this.DateAct = dateAct;
            this.DateInscrip = dateInscrip;
            this.DateAnnule = dateAnnule;
        }

        public int NoInscrip { get => noInscrip; set => noInscrip = value; }
        public String User { get => user; set => user = value; }
        public String CodeAnim { get => codeAnim; set => codeAnim = value; }
        public String DateAct { get => dateAct; set => dateAct = value; }
        public String DateInscrip { get => dateInscrip; set => dateInscrip = value; }
        public String DateAnnule { get => dateAnnule; set => dateAnnule = value; }

        public override string ToString()
        {
            return noInscrip.ToString();
        }

    }
}

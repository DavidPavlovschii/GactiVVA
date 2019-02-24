using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gacti_PPE
{
    public class TypeAnimation
    {
        private string codeType;
        private string nomType;

        public TypeAnimation(string codeType, string nomType)
        {
            this.CodeType = codeType;
            this.NomType = nomType;
        }

        public string CodeType { get => codeType; set => codeType = value; }
        public string NomType { get => nomType; set => nomType = value; }

        public override bool Equals(object obj)
        {
            var animation = obj as TypeAnimation;
            return animation != null &&
                   CodeType == animation.CodeType &&
                   NomType == animation.NomType;
        }

        public override string ToString()
        {
            return codeType;
        }
    }
}

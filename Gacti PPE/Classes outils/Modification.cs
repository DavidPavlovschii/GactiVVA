using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gacti_PPE
{
    public static class Modification
    {
        private static Animation tmpAnimation;
        private static Activite tmpActivite;

        public static void SetAnimation(Animation uneAnimation)
        {
            tmpAnimation = uneAnimation;
        }

        public static Animation GetAnimation()
        {
            return tmpAnimation;
        }

        public static void SetActivite(Activite uneActivite)
        {
            tmpActivite = uneActivite;
        }

        public static Activite GetActvite()
        {
            return tmpActivite;
        }
    }
}

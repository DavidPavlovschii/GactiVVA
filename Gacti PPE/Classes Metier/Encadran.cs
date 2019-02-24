using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gacti_PPE
{
    public class Encadran
    {
        private string pseudo;
        private string mdp;
        private string nomCompte;
        private string prenomCompte;
        private DateTime dateInscrip;
        private DateTime dateFerme;
        private string typeProfil;
        private DateTime dateNaissCompte;
        private string adresseMailCompte;
        private string noTelCompte;

        public Encadran(string pseudo, string mdp, string nomCompte, 
                         string prenomCompte, DateTime dateInscrip, 
                         DateTime dateFerme, string typeProfil, 
                         DateTime dateNaissCompte, string adresseMailCompte, string noTelCompte)
        {
            this.pseudo = pseudo;
            this.mdp = mdp;
            this.nomCompte = nomCompte;
            this.prenomCompte = prenomCompte;
            this.dateInscrip = dateInscrip;
            this.dateFerme = dateFerme;
            this.typeProfil = typeProfil;
            this.dateNaissCompte = dateNaissCompte;
            this.adresseMailCompte = adresseMailCompte;
            this.noTelCompte = noTelCompte;
        }

        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string NomCompte { get => nomCompte; set => nomCompte = value; }
        public string PrenomCompte { get => prenomCompte; set => prenomCompte = value; }
        public DateTime DateInscrip { get => dateInscrip; set => dateInscrip = value; }
        public DateTime DateFerme { get => dateFerme; set => dateFerme = value; }
        public string TypeProfil { get => typeProfil; set => typeProfil = value; }
        public DateTime DateNaissCompte { get => dateNaissCompte; set => dateNaissCompte = value; }
        public string AdresseMailCompte { get => adresseMailCompte; set => adresseMailCompte = value; }
        public string NoTelCompte { get => noTelCompte; set => noTelCompte = value; }

        public override string ToString()
        {
            return this.nomCompte + " " + this.prenomCompte;
        }
    }
}

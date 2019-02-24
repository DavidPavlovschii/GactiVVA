using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gacti_PPE
{
    public class Vacanciere
    {
        private string pseudo;
        private string nomCompte;
        private string prenomCompte;
        private DateTime dateInscrip;
        private DateTime dateFerme;
        private DateTime dateDebSejour;
        private DateTime dateFinSejour;
        private DateTime dateNaissCompte;
        private string adresseMailCompte;
        private string noTelCompte;
        private string noInscrip; 

        public Vacanciere(string unPseudo, string unNomCompte, string unPrenomCompte,
                           DateTime uneDateInscrip, DateTime uneDateFerme, DateTime uneDateDebSejour,
                           DateTime uneDateFinSejour, DateTime uneDateNaissCompte, string uneAdresseMailCompte, 
                           string unNoTelCompte, string unNoInscrip)
        {
            pseudo = unPseudo;
            nomCompte = unNomCompte;
            prenomCompte = unPrenomCompte;
            dateInscrip = uneDateInscrip;
            dateFerme = uneDateFerme;
            dateDebSejour = uneDateDebSejour;
            dateFinSejour = uneDateFinSejour;
            dateNaissCompte = uneDateNaissCompte;
            adresseMailCompte = uneAdresseMailCompte;
            noTelCompte = unNoTelCompte;
            noInscrip = unNoInscrip;
        }

        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string NomCompte { get => nomCompte; set => nomCompte = value; }
        public string PrenomCompte { get => prenomCompte; set => prenomCompte = value; }
        public DateTime DateInscrip { get => dateInscrip; set => dateInscrip = value; }
        public DateTime DateFerme { get => dateFerme; set => dateFerme = value; }
        public DateTime DateDebSejour { get => dateDebSejour; set => dateDebSejour = value; }
        public DateTime DateFinSejour { get => dateFinSejour; set => dateFinSejour = value; }
        public DateTime DateNaissCompte { get => dateNaissCompte; set => dateNaissCompte = value; }
        public string AdresseMailCompte { get => adresseMailCompte; set => adresseMailCompte = value; }
        public string NoTelCompte { get => noTelCompte; set => noTelCompte = value; }
        public string NoInscrip { get => noInscrip;set => noInscrip = value;}

        public string GetInformations()
        {
            return nomCompte + " " + prenomCompte + " \r" +
                   "Inscrit depuis le : " + dateInscrip.ToString().Substring(0,10) + ". \r" +
                   "Date de naissance : " + dateNaissCompte.ToString().Substring(0, 10) + " \r" +
                   "Date de cloturation du compte : " + dateFerme.ToString().Substring(0, 10) + " \r" +
                   "Date de début de séjour : " + dateDebSejour.ToString().Substring(0, 10) + " \r" +
                   "Date de fin de séjour : " + dateFinSejour.ToString().Substring(0, 10) + " \r" +
                   "Adresse e-mail : " + adresseMailCompte + " \r" +
                   "Numéro d'inscription pour cette activité :" + noInscrip;
        }

        public override string ToString()
        {
            return nomCompte + " " + prenomCompte ;
        }

    }
}

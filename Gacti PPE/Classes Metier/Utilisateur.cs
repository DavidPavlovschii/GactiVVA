using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gacti_PPE
{
    public static class Utilisateur
    {
        private static string pseudo;
        private static string mdp;
        private static string nomCompte;
        private static string prenomCompte;
        private static DateTime dateInscrip;
        private static DateTime dateFerme;
        private static string typeProfil;
        private static DateTime dateDebSejour;
        private static DateTime dateFinSejour;
        private static DateTime dateNaissCompte;
        private static string adresseMailCompte;
        private static string noTelCompte;

        public static void SetUtilisateur(string unPseudo, string unMdp, string unNomCompte, string unPrenomCompte, 
                           DateTime uneDateInscrip, DateTime uneDateFerme, string unTypeProfil, DateTime uneDateDebSejour,
                           DateTime uneDateFinSejour, DateTime uneDateNaissCompte, string uneAdresseMailCompte, string unNoTelCompte)
        {
            pseudo = unPseudo;
            mdp = unMdp;
            nomCompte = unNomCompte;
            prenomCompte = unPrenomCompte;
            dateInscrip = uneDateInscrip;
            dateFerme = uneDateFerme;
            typeProfil = unTypeProfil;
            dateDebSejour = uneDateDebSejour;
            dateFinSejour = uneDateFinSejour;
            dateNaissCompte = uneDateNaissCompte;
            adresseMailCompte = uneAdresseMailCompte;
            noTelCompte = unNoTelCompte;

        }
        //Getters, tous sauf GetMdp
        public static string GetPseudo()
        {
            return pseudo;
        }
        public static string GetNom()
        {
            return nomCompte;
        }
        public static string GetPrenom()
        {
            return prenomCompte;
        }
        public static DateTime GetDateInsc()
        {
            return dateInscrip;
        }
        public static DateTime GetDateFerme()
        {
            return dateFerme;
        }
        public static string GetTypeCompte()
        {
            return typeProfil;
        }
        public static DateTime GetDateDebSejour()
        {
            return dateDebSejour;
        }
        public static DateTime GetDateFinSejour()
        {
            return dateFinSejour;
        }
        public static DateTime GetDateNaiss()
        {
            return dateNaissCompte;
        }
        public static string  GetAdresseMail()
        {
            return adresseMailCompte;
        }
        public static string GetNoTelCompte()
        {
            return noTelCompte;
        }

        public static string GetInfos()
        {
            return ("Pseudo : " + pseudo + ", " + "\n Nom : " + nomCompte + " \n Prénom : " + prenomCompte);
        }

        public static bool EstEncadrant()
        {
            if (typeProfil == "E")
                return true;
            return false;
        }

        public static bool EstVacancier()
        {
            if (typeProfil == "V")
                return true;
            return false;
        }

        public static bool EstDateValide()
        {
            if(Utilisateur.EstVacancier())
            {

            }
            return false;
        }


        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gacti_PPE
{
    public class Activite
    {
        private string codeAnim;
        private string dateAct; // !! format DATE dans la BDD !!
        private string codeEtatAct;
        private string hrRdvAct;
        private Decimal prixActe; //voir comment utiliser le type Decimal (dans le programme et la BDD)
        private string hrDebutAct; // !! format TIME dans la BDD !!
        private string hrFinAct; // !! format TIME dans la BDD 
        private string dateAnnuleAct; // !! format DATE dans la BDD !!
        private string nomResp;
        private string prenomRes;

        public Activite(string codeAnim, string dateAct, string codeEtatAct, string hrRdvAct,
                        Decimal prixActe, string hrDebutAct, string hrFinAct, string dateAnnuleAct, 
                        string nomResp, string prenomRes)
        {
            this.codeAnim = codeAnim;
            this.dateAct = dateAct;
            this.codeEtatAct = codeEtatAct;
            this.hrRdvAct = hrRdvAct;
            this.prixActe = prixActe;
            this.hrDebutAct = hrDebutAct;
            this.hrFinAct = hrFinAct;
            this.dateAnnuleAct = dateAnnuleAct;
            this.nomResp = nomResp;
            this.prenomRes = prenomRes;
        }

        public string CodeAnim { get => codeAnim; set => codeAnim = value; }
        public string DateAct { get => dateAct.Substring(0,10); set => dateAct = value; }
        public string CodeEtatAct { get => codeEtatAct; set => codeEtatAct = value; }
        public string HrRdvAct { get => hrRdvAct; set => hrRdvAct = value; }
        public decimal PrixActe { get => prixActe; set => prixActe = value; }
        public string HrDebutAct { get => hrDebutAct; set => hrDebutAct = value; }
        public string HrFinAct { get => hrFinAct; set => hrFinAct = value; }
        public string DateAnnuleAct { get => dateAnnuleAct; set => dateAnnuleAct = value; }
        public string NomResp { get => nomResp; set => nomResp = value; }
        public string PrenomRes { get => prenomRes; set => prenomRes = value; }

        public override bool Equals(object obj) //voir quel champs garder pour le equals
        {
            var activite = obj as Activite;

            return activite != null &&
                   codeAnim == activite.codeAnim &&
                   dateAct == activite.dateAct &&
                   codeEtatAct == activite.codeEtatAct &&
                   hrRdvAct == activite.hrRdvAct &&
                   prixActe == activite.prixActe &&
                   hrDebutAct == activite.hrDebutAct &&
                   hrFinAct == activite.hrFinAct &&
                   dateAnnuleAct == activite.dateAnnuleAct &&
                   nomResp == activite.nomResp &&
                   prenomRes == activite.prenomRes;
        }

        public string GetInformations()
        {
            return "L'activité " + this.codeAnim + ", a lieu le " + this.dateAct + "\n" +
                   " de " + this.hrDebutAct + " à " + this.hrFinAct + " avec l'encadrant " + this.prenomRes + " " + this.nomResp;
                  
        }

        public override string ToString() 
        {
            return codeAnim + " le " + dateAct + " de " + hrDebutAct.Substring(0, 5) + " à " + hrFinAct.Substring(0, 5); 
        }


    }
}

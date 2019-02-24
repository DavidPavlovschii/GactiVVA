using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gacti_PPE
{
    public class Animation
    {
        private string code;
        private string codeType;
        private string nom;
        private string dateCreation; // !! Champ de type DATE dans la BDD !! 
        private string dateValidite; // !! Champ de type DATE dans la BDD !! 
        private Double duree;
        private int limiteAge;
        private Decimal tarif; // voir comment utiliser le type decimal dans le programme et la BDD
        private int nbrePlace;
        private string description;
        private string comment;
        private string difficulte;


        //voir si tous les champs sont instanciés directement dans le constucteur
        public Animation(string code, string codeType, string nom, string dateCreation, string dateValidite, double duree, 
                         int limiteAge,decimal tarif, int nbrePlace, string description, string comment, string difficulte)
        {
            this.code = code;
            this.codeType = codeType;
            this.nom = nom;
            this.dateCreation = dateCreation;
            this.dateValidite = dateValidite;
            this.duree = duree;
            this.limiteAge = limiteAge;
            this.tarif = tarif;
            this.nbrePlace = nbrePlace;
            this.description = description;
            this.comment = comment;
            this.difficulte = difficulte;
        }

        public string Code { get => code; set => code = value; }
        public string CodeType { get => codeType; set => codeType = value; }
        public string Nom { get => nom; set => nom = value; }
        public string DateCreation { get => dateCreation; set => dateCreation = value; }
        public string DateValidite { get => dateValidite; set => dateValidite = value; }
        public double Duree { get => duree; set => duree = value; }
        public int LimiteAge { get => limiteAge; set => limiteAge = value; }
        public decimal Tarif { get => tarif; set => tarif = value; }
        public int NbrePlace { get => nbrePlace; set => nbrePlace = value; }
        public string Description { get => description; set => description = value; }
        public string Comment { get => comment; set => comment = value; }
        public string Difficulte { get => difficulte; set => difficulte = value; }

        public override string ToString()
        {
            return this.code;
        }

        public override bool Equals(object obj)
        {
            var animation = obj as Animation;
            return animation != null &&
                   code == animation.code &&
                   codeType == animation.codeType &&
                   nom == animation.nom &&
                   dateCreation == animation.dateCreation &&
                   dateValidite == animation.dateValidite &&
                   duree == animation.duree &&
                   limiteAge == animation.limiteAge &&
                   tarif == animation.tarif &&
                   nbrePlace == animation.nbrePlace &&
                   description == animation.description &&
                   comment == animation.comment &&
                   difficulte == animation.difficulte;
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace Gacti_PPE
{
    public static class Donnees
    {
        //Champs 
        private static String cs = @"server=localhost;user=root;password=;database=gacti";
        private static MySqlConnection conn;


        #region Connexion/deconnexion
        //Connexion/deconnexion
        public static bool Connexion()
        {
            conn = new MySqlConnection(cs);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {

                return (conn.State == ConnectionState.Open); 
            }
            return (conn.State == ConnectionState.Open);
        }

        internal static object GetLesActivitesCible()
        {
            throw new NotImplementedException();
        }

        public static bool Deconnexion()
        {
            if (Connexion() == true)
            {
                conn.Close();
                return (conn.State == ConnectionState.Closed);
            }
            return false;
        }
        #endregion
        #region Utilisateur statique
        public static bool RecupererUtilisateur(string unPseudo, string unMotDePasse)
        {
            MySqlDataReader rdrUtilisateur;
            MySqlCommand cmd = conn.CreateCommand();
            string sqlTypeCompte = "SELECT * FROM compte WHERE USER LIKE '" + unPseudo + "' AND MDP LIKE '" + unMotDePasse + "'";
            cmd.CommandText = sqlTypeCompte;
            rdrUtilisateur = cmd.ExecuteReader();

            string pseudo;
            string mdp;
            string nomCompte;
            string prenomCompte;
            DateTime dateInscrip;
            DateTime dateFerme;
            string typeProfil;
            DateTime dateDebSejour;
            DateTime dateFinSejour;
            DateTime dateNaissCompte;
            string adresseMailCompte;
            string noTelCompte;
            if (rdrUtilisateur.Read())
            {
                pseudo = (string)rdrUtilisateur["USER"];
                mdp = (string)rdrUtilisateur["MDP"];
                nomCompte = (string)rdrUtilisateur["NOMCOMPTE"];
                prenomCompte = (string)rdrUtilisateur["PRENOMCOMPTE"];
                dateInscrip = (DateTime)rdrUtilisateur["DATEINSCRIP"];
                dateFerme = (DateTime)rdrUtilisateur["DATEFERME"];
                typeProfil = (string)rdrUtilisateur["TYPEPROFIL"];
                dateDebSejour = (DateTime)rdrUtilisateur["DATEDEBSEJOUR"];
                dateFinSejour = (DateTime)rdrUtilisateur["DATEFINSEJOUR"];
                dateNaissCompte = (DateTime)rdrUtilisateur["DATENAISCOMPTE"];
                adresseMailCompte = (string)rdrUtilisateur["ADRMAILCOMPTE"];
                noTelCompte = (string)rdrUtilisateur["NOTELCOMPTE"];

                Utilisateur.SetUtilisateur(pseudo, mdp, nomCompte, prenomCompte, dateInscrip, dateFerme, typeProfil,
                                                            dateDebSejour, dateFinSejour, dateNaissCompte, adresseMailCompte, noTelCompte);
                rdrUtilisateur.Close();
                return true;
            }
            rdrUtilisateur.Close();
            return false;
        }
        #endregion
        #region Encadrant
        public static List<Encadran> GetListeEncadrant()
        {
            MySqlDataReader rdrEncadrant;
            MySqlCommand cmd = conn.CreateCommand();
            string sqlTypeCompte = "SELECT * FROM COMPTE where TYPEPROFIL LIKE 'E' ";
            cmd.CommandText = sqlTypeCompte;
            rdrEncadrant = cmd.ExecuteReader();

            List<Encadran> listeEncadrant = new List<Encadran>();

            string pseudo;
            string mdp;
            string nomCompte;
            string prenomCompte;
            DateTime dateInscrip;
            DateTime dateFerme;
            string typeProfil;
            DateTime dateNaissCompte;
            string adresseMailCompte;
            string noTelCompte;
            if (rdrEncadrant.HasRows)
            {
                while (rdrEncadrant.Read())
                {
                    pseudo = (string)rdrEncadrant["USER"];
                    mdp = (string)rdrEncadrant["MDP"];
                    nomCompte = (string)rdrEncadrant["NOMCOMPTE"];
                    prenomCompte = (string)rdrEncadrant["PRENOMCOMPTE"];
                    dateInscrip = (DateTime)rdrEncadrant["DATEINSCRIP"];
                    dateFerme = (DateTime)rdrEncadrant["DATEFERME"];
                    typeProfil = (string)rdrEncadrant["TYPEPROFIL"];
                    dateNaissCompte = (DateTime)rdrEncadrant["DATENAISCOMPTE"];
                    adresseMailCompte = (string)rdrEncadrant["ADRMAILCOMPTE"];
                    noTelCompte = (string)rdrEncadrant["NOTELCOMPTE"];

                    Encadran unEncadrant = new Encadran(pseudo, mdp, nomCompte, prenomCompte, 
                                                        dateInscrip, dateFerme, typeProfil,
                                                        dateNaissCompte, adresseMailCompte, noTelCompte);
                    listeEncadrant.Add(unEncadrant);
                }
            }
            rdrEncadrant.Close();
            return listeEncadrant;
        }
        // - - - - - - - - - - - - - - - - - - - - - - - ENCADRANT - - - - - - - - - - - - - - - - - - - - - - - - - - - -\\
        #region Animation
        // - - - - - - - - - - - - - - - - - - - - - - - Animations - - - - - - - - - - - - - - - - - - - - - - - - - - - -\\
        public static List<Animation> GetLesAnimations()
        {
            MySqlDataReader rdrActivite;
            MySqlCommand cmd = conn.CreateCommand();
            string sqlTypeCompte = "SELECT * FROM animation";
            cmd.CommandText = sqlTypeCompte;
            rdrActivite = cmd.ExecuteReader();

            List<Animation> listeAnimations = new List<Animation>();

            string code;
            string codeType;
            string nom;
            string dateCreation; // !! Champ de type DATE dans la BDD !! 
            string dateValidite; // !! Champ de type DATE dans la BDD !! 
            Double duree;
            int limiteAge;
            Decimal tarif; // voir comment utiliser le type decimal dans le programme et la BDD
            int nbrePlace;
            string description;
            string comment;
            string difficulte;
            if (rdrActivite.HasRows)
            {
                while (rdrActivite.Read())
                {
                    code = (string)rdrActivite["CODEANIM"];
                    codeType = (string)rdrActivite["CODETYPEANIM"];
                    nom = (string)rdrActivite["NOMANIM"];
                    dateCreation = Convert.ToString(rdrActivite["DATECREATIONANIM"]);
                    dateValidite = Convert.ToString(rdrActivite["DATEVALIDITEANIM"]);
                    duree = (Double)rdrActivite["DUREEANIM"];
                    limiteAge = (int)rdrActivite["LIMITEAGE"];
                    tarif = (Decimal)rdrActivite["TARIFANIM"];
                    nbrePlace = (int)rdrActivite["NBREPLACEANIM"];
                    description = (string)rdrActivite["DESCRIPTANIM"];
                    comment = (string)rdrActivite["COMMENTANIM"];
                    difficulte = (string)rdrActivite["DIFFICULTEANIM"];
                    Animation uneAnimation = new Animation(code, codeType, nom, dateCreation, dateValidite, duree, limiteAge, tarif, nbrePlace, description, comment, difficulte);
                    listeAnimations.Add(uneAnimation);
                }
            }
            rdrActivite.Close();
            return listeAnimations;
        }

        public static List<TypeAnimation> GetLesTypesDAnimations()
        {
            MySqlDataReader rdrActivite;
            MySqlCommand cmd = conn.CreateCommand();
            string sqlTypeAnim = "SELECT * FROM type_anim";
            cmd.CommandText = sqlTypeAnim;
            rdrActivite = cmd.ExecuteReader();

            List<TypeAnimation> listeTypeAnimations = new List<TypeAnimation>();

            string codeType;
            string nomType;
            
            if (rdrActivite.HasRows)
            {
                while (rdrActivite.Read())
                {
                    codeType = (string)rdrActivite["CODETYPEANIM"];
                    nomType = (string)rdrActivite["NOMTYPEANIM"];

                    TypeAnimation unTypeAnimation = new TypeAnimation(codeType, nomType);
                    listeTypeAnimations.Add(unTypeAnimation);
                }
            }
            rdrActivite.Close();
            return listeTypeAnimations;
        }
       
        public static bool AjouterAnimation(Animation uneAnimation)
        {
            string reqI;
            int nbMaj;
            MySqlCommand cmd = conn.CreateCommand();
            reqI = "INSERT INTO animation(CODEANIM, CODETYPEANIM, NOMANIM, DATECREATIONANIM, DATEVALIDITEANIM, DUREEANIM, LIMITEAGE, TARIFANIM," +
                " NBREPLACEANIM, DESCRIPTANIM, COMMENTANIM, DIFFICULTEANIM) " +
                " VALUES('" + uneAnimation.Code.Replace("'", "''") + "', (SELECT CODETYPEANIM FROM TYPE_ANIM WHERE CODETYPEANIM  LIKE '" + uneAnimation.CodeType.Replace("'", "''") + "'),'" + uneAnimation.Nom.Replace("'", "''") + "', '" + uneAnimation.DateCreation + "'  , '" + uneAnimation.DateValidite + "' , " + 
                uneAnimation.Duree + " , " + uneAnimation.LimiteAge + " , " + uneAnimation.Tarif + " , " + uneAnimation.NbrePlace + " , '" + 
                uneAnimation.Description.Replace("'", "''") + "', '" + uneAnimation.Comment.Replace("'", "''") + "', '" + uneAnimation.Difficulte + "' )";

            cmd.CommandText = reqI;
            nbMaj = cmd.ExecuteNonQuery();
            if (nbMaj == 1)
                return true;
            return false;
        }

        public static bool ExisteAnimation(Animation uneAnimation)
        {
            string reqExiste;
            Object nbMaj;
            MySqlCommand cmd = conn.CreateCommand();
            reqExiste = "SELECT COUNT(*) FROM ANIMATION WHERE CODEANIM  like '" + uneAnimation.Code + "' ";
            cmd.CommandText = reqExiste;
            nbMaj = cmd.ExecuteScalar();

            if ((long)nbMaj == 1)
                return true;
             return false;
        }

        public static bool ModifierAnimation(Animation modifAnim)
        {
            string reqUpdteAnim;
            int nbMaj;
            Animation uneAnimation = Modification.GetAnimation();
            MySqlCommand cmd = conn.CreateCommand();
            reqUpdteAnim = "UPDATE animation SET CODEANIM = '" + modifAnim.Code + "' ," +
                          " CODETYPEANIM = '" + modifAnim.CodeType +"' ," +
                          " NOMANIM  = '" + modifAnim.Nom.ToString().Replace("'", "''") + "' ," +
                          " DATECREATIONANIM = '" + modifAnim.DateCreation + "' ," +
                          " DATEVALIDITEANIM = '" + modifAnim.DateValidite + "' ," +
                          " DUREEANIM = " + modifAnim.Duree + " ," +
                          " LIMITEAGE =" + modifAnim.LimiteAge + " ," +
                          " TARIFANIM =" + modifAnim.Tarif.ToString().Replace(",", ".") + " ," +
                          " NBREPLACEANIM =" + modifAnim.NbrePlace + " ," +
                          " DESCRIPTANIM = '" + modifAnim.Description.ToString().Replace("'", "''") + "' ," + //mysql n'accepte pas de ' dans les requetes, 
                          " COMMENTANIM = '" + modifAnim.Comment.ToString().Replace("'", "''") + "' ," + //il faut mettre '', c'est pourquoi il y a le replace
                          " DIFFICULTEANIM = '" + modifAnim.Difficulte + "'" +
                          " WHERE CODEANIM  LIKE  '" + uneAnimation.Code + "'";

            cmd.CommandText = reqUpdteAnim;
            nbMaj = cmd.ExecuteNonQuery();
            if (nbMaj == 1)
                return true;
            return false;
        }

        #endregion
        
        #region Activités
        // - - - - - - - - - - - - - - - - - - - - - - - Activités - - - - - - - - - - - - - - - - - - - - - - - - - - - -\\
        public static List<Activite> GetLesActivites()
        {
            MySqlDataReader rdrActivite;
            MySqlCommand cmd = conn.CreateCommand();
            string sqlActi = "SELECT * FROM ACTIVITE";
            cmd.CommandText = sqlActi;
            rdrActivite = cmd.ExecuteReader();

            List<Activite> listeActivite = new List<Activite>();

            string codeAnim;
            string dateAct; // !! format DATE dans la BDD !!
            string codeEtatAct;
            string hrRdvAct;
            Decimal prixActe; //voir comment utiliser le type Decimal (dans le programme et la BDD)
            string hrDebutAct; // !! format TIME dans la BDD !!
            string hrFinAct; // !! format TIME dans la BDD 
            string dateAnnuleAct; // !! format DATE dans la BDD !!
            string nomResp;
            string prenomRes;

            if (rdrActivite.HasRows)
            {
                while (rdrActivite.Read())
                {
                    codeAnim = (string)rdrActivite["CODEANIM"];
                    dateAct = Convert.ToString(rdrActivite["DATEACT"]); 
                    codeEtatAct = (string)rdrActivite["CODEETATACT"];
                    hrRdvAct = Convert.ToString(rdrActivite["HRRDVACT"]);
                    prixActe = (Decimal)rdrActivite["PRIXACT"]; 
                    hrDebutAct = Convert.ToString(rdrActivite["HRDEBUTACT"]); 
                    hrFinAct = Convert.ToString(rdrActivite["HRFINACT"]); 
                    dateAnnuleAct = Convert.ToString(rdrActivite["DATEANNULEACT"]); 
                    nomResp = (string)rdrActivite["NOMRESP"];
                    prenomRes = (string)rdrActivite["PRENOMRESP"];

                    Activite uneActivite = new Activite(codeAnim, dateAct, codeEtatAct, hrRdvAct, prixActe,
                                                        hrDebutAct, hrFinAct, dateAnnuleAct, nomResp, prenomRes);
                    listeActivite.Add(uneActivite);
                }
            }
            rdrActivite.Close();
            return listeActivite;
        }

        public static List<Activite> GetLesActivitesCible(string unCodeAnim)
        {
            MySqlDataReader rdrActivite;
            MySqlCommand cmd = conn.CreateCommand();
            string sqlActi = "SELECT * FROM ACTIVITE WHERE CODEANIM = '" + unCodeAnim + "'";
            cmd.CommandText = sqlActi;
            rdrActivite = cmd.ExecuteReader();

            List<Activite> listeActivite = new List<Activite>();

            string codeAnim;
            string dateAct; // !! format DATE dans la BDD !!
            string codeEtatAct;
            string hrRdvAct;
            Decimal prixActe; //voir comment utiliser le type Decimal (dans le programme et la BDD)
            string hrDebutAct; // !! format TIME dans la BDD !!
            string hrFinAct; // !! format TIME dans la BDD 
            string dateAnnuleAct; // !! format DATE dans la BDD !!
            string nomResp;
            string prenomRes;

            if (rdrActivite.HasRows)
            {
                while (rdrActivite.Read())
                {
                    codeAnim = (string)rdrActivite["CODEANIM"];
                    dateAct = Convert.ToString(rdrActivite["DATEACT"]).Substring(0, 11); // Récupere seulement la date et vire l'heure chiante (hh:mm:ss)
                    codeEtatAct = (string)rdrActivite["CODEETATACT"];
                    hrRdvAct = Convert.ToString(rdrActivite["HRRDVACT"]).Substring(0, 5);
                    prixActe = (Decimal)rdrActivite["PRIXACT"];
                    hrDebutAct = Convert.ToString(rdrActivite["HRDEBUTACT"]).Substring(0, 5);
                    hrFinAct = Convert.ToString(rdrActivite["HRFINACT"]).Substring(0, 5);
                    dateAnnuleAct = Convert.ToString(rdrActivite["DATEANNULEACT"]);
                    nomResp = Convert.ToString(rdrActivite["NOMRESP"]);
                    prenomRes = Convert.ToString(rdrActivite["PRENOMRESP"]);

                    Activite uneActivite = new Activite(codeAnim, dateAct, codeEtatAct, hrRdvAct, prixActe,
                                                        hrDebutAct, hrFinAct, dateAnnuleAct, nomResp, prenomRes);
                    listeActivite.Add(uneActivite);
                }
            }
            rdrActivite.Close();
            return listeActivite;
        }

        public static List<Activite> GetLesActivitesPourUneAnimation(Animation uneAnimation)
        {
            MySqlDataReader rdrActivite;
            MySqlCommand cmd = conn.CreateCommand();
            string sqlActi = "SELECT * FROM ACTIVITE WHERE CODEANIM LIKE '" + uneAnimation.Code + "'" ;
            cmd.CommandText = sqlActi;
            rdrActivite = cmd.ExecuteReader();

            List<Activite> listeActivite = new List<Activite>();

            string codeAnim;
            string dateAct; // !! format DATE dans la BDD !!
            string codeEtatAct;
            string hrRdvAct;
            Decimal prixActe; //voir comment utiliser le type Decimal (dans le programme et la BDD)
            string hrDebutAct; // !! format TIME dans la BDD !!
            string hrFinAct; // !! format TIME dans la BDD 
            string dateAnnuleAct; // !! format DATE dans la BDD !!
            string nomResp;
            string prenomRes;

            if (rdrActivite.HasRows)
            {
                while (rdrActivite.Read())
                {
                    codeAnim = (string)rdrActivite["CODEANIM"];
                    dateAct = Convert.ToString(rdrActivite["DATEACT"]).Substring(0,11); // Récupere seulement la date et vire l'heure chiante (hh:mm:ss)
                    codeEtatAct = (string)rdrActivite["CODEETATACT"];
                    hrRdvAct = Convert.ToString(rdrActivite["HRRDVACT"]).Substring(0, 5); 
                    prixActe = (Decimal)rdrActivite["PRIXACT"];
                    hrDebutAct = Convert.ToString(rdrActivite["HRDEBUTACT"]).Substring(0, 5); 
                    hrFinAct = Convert.ToString(rdrActivite["HRFINACT"]).Substring(0, 5);  
                    dateAnnuleAct = Convert.ToString(rdrActivite["DATEANNULEACT"]); 
                    nomResp = Convert.ToString(rdrActivite["NOMRESP"]);
                    prenomRes = Convert.ToString(rdrActivite["PRENOMRESP"]);

                    Activite uneActivite = new Activite(codeAnim, dateAct, codeEtatAct, hrRdvAct, prixActe,
                                                        hrDebutAct, hrFinAct, dateAnnuleAct, nomResp, prenomRes);
                    listeActivite.Add(uneActivite);
                }
            }
            rdrActivite.Close();
            return listeActivite;
        }

        public static List<EtatActivite> GetLesEtatsDActivite()
        {
            MySqlDataReader rdrActivite;
            MySqlCommand cmd = conn.CreateCommand();
            string sqlEtatActi = "SELECT * FROM ETAT_ACT";
            cmd.CommandText = sqlEtatActi;
            rdrActivite = cmd.ExecuteReader();

            List<EtatActivite> listeEtatActivite = new List<EtatActivite>();

            string codeEtat;
            string nomEtat;

            if (rdrActivite.HasRows)
            {
                while (rdrActivite.Read())
                {
                    codeEtat = (string)rdrActivite["CODEETATACT"];
                    nomEtat = (string)rdrActivite["NOMETATACT"];

                    EtatActivite unEtatActivite = new EtatActivite(codeEtat, nomEtat);
                    listeEtatActivite.Add(unEtatActivite);
                }
            }
            rdrActivite.Close();
            return listeEtatActivite;
        }

        public static bool AjouterActivite(Activite uneActivite)
        {
            string reqI;
            int nbMaj;
            MySqlCommand cmd = conn.CreateCommand();
            reqI = "INSERT INTO activite(CODEANIM, DATEACT, CODEETATACT, HRRDVACT, PRIXACT, HRDEBUTACT, HRFINACT, DATEANNULEACT, NOMRESP, PRENOMRESP" +
                ") " +
                " VALUES( '"+ uneActivite.CodeAnim + "' , '" + uneActivite.DateAct + "' , '" + uneActivite.CodeEtatAct + "', '" + 
                             uneActivite.HrRdvAct + "' , " + uneActivite.PrixActe + ",'" + uneActivite.HrDebutAct + "', '" + 
                             uneActivite.HrFinAct + "', '" + uneActivite.DateAnnuleAct + "','" + uneActivite.NomResp + "','" + 
                             uneActivite.PrenomRes+ "' );";

            cmd.CommandText = reqI;
            
            nbMaj = cmd.ExecuteNonQuery();
            if (nbMaj == 1)
                return true;
            return false;
        }

        public static bool ExisteActivite(Activite uneActivite) // to do
        {
            string reqExiste;
            MySqlCommand cmd = conn.CreateCommand();
            reqExiste = "SELECT COUNT(*) AS NBACTIVITE FROM ACTIVITE WHERE DATEACT = '" + uneActivite.DateAct + "' AND CODEANIM = '" + uneActivite.CodeAnim + "';";
            cmd.CommandText = reqExiste;
            int nbMaj = int.Parse(cmd.ExecuteScalar().ToString());
            if (nbMaj == 0)
                return false;
            return true;
        }

        public static bool ModifierActivite(Activite uneActivite) // à modifier, plante quand l'activité 
        {                                                         //est mise a la meme date qu'une autre
            string reqUpdteEtu;
            int nbMaj;
            Activite modifActi = Modification.GetActvite();
            MySqlCommand cmd = conn.CreateCommand();
            reqUpdteEtu = "UPDATE activite SET CODEANIM = '" + uneActivite.CodeAnim + "' ," +
                          " DATEACT = '" + uneActivite.DateAct + "' ," +
                          " CODEETATACT  = '" + uneActivite.CodeEtatAct.ToString() + "' ," +
                          " HRRDVACT = '" + uneActivite.HrRdvAct + "' ," +
                          " PRIXACT = " + uneActivite.PrixActe+ " ," +
                          " HRDEBUTACT = '" + uneActivite.HrDebutAct + "' ," +
                          " HRFINACT = '" + uneActivite.HrFinAct + "' ," +
                          " DATEANNULEACT = '" + uneActivite.DateAnnuleAct + "' ," +
                          " NOMRESP = '" + uneActivite.NomResp + "' ," +
                          " PRENOMRESP = '" + uneActivite.PrenomRes + "'" + //mysql n'accepte pas de ' dans les requetes, 
                          " WHERE CODEANIM  =  '" + modifActi.CodeAnim + "' AND DATEACT = '" + Convert.ToString(DateTime.Parse(modifActi.DateAct).ToString("yyyy'-'MM'-'dd")) + "'";

            cmd.CommandText = reqUpdteEtu;
            nbMaj = cmd.ExecuteNonQuery();
            if (nbMaj == 1)
                return true;
            return false;
        }

        public static bool AnnulerActivite(Activite uneActivite)
        {
            string reqUpdteEtu;
            int nbMaj;
            Activite modifActi = Modification.GetActvite();
            MySqlCommand cmd = conn.CreateCommand();
            reqUpdteEtu = "UPDATE activite SET CODEANIM = '" + uneActivite.CodeAnim + "' ," +
                          " DATEACT = '" + Convert.ToString(DateTime.Parse(uneActivite.DateAct).ToString("yyyy'-'MM'-'dd")) + "' ," +
                          " CODEETATACT  = 'AN' ," +
                          " HRRDVACT = '" + uneActivite.HrRdvAct + "' ," +
                          " PRIXACT = " + uneActivite.PrixActe.ToString().Replace(",",".") + " ," + //remplace la virgule par un point car la bdd n'accepte pas de virgule pour des decimaux
                          " HRDEBUTACT = '" + uneActivite.HrDebutAct + "' ," +
                          " HRFINACT = '" + uneActivite.HrFinAct + "' ," +
                          " DATEANNULEACT = '" + Convert.ToString(DateTime.Parse(uneActivite.DateAnnuleAct).ToString("yyyy'-'MM'-'dd")) + "' ," +
                          " NOMRESP = '" + uneActivite.NomResp + "' ," +
                          " PRENOMRESP = '" + uneActivite.PrenomRes + "'" + //mysql n'accepte pas de ' dans les requetes, 
                          " WHERE CODEANIM  =  '" + modifActi.CodeAnim + "' AND DATEACT = '" + Convert.ToString(DateTime.Parse(modifActi.DateAct).ToString("yyyy'-'MM'-'dd")) + "'";

            cmd.CommandText = reqUpdteEtu;
            nbMaj = cmd.ExecuteNonQuery();
            if (nbMaj == 1)
                return true;
            return false;
        }

        public static List<Vacanciere> GetLesInscritsAUneActivite(Activite uneActivite)
        {
            MySqlDataReader rdrVacancier;
            MySqlCommand cmd = conn.CreateCommand();
            DateTime dateActi = Convert.ToDateTime(uneActivite.DateAct);
            string sqlTypeCompte = "SELECT DISTINCT P.USER, P.NOMCOMPTE, P.PRENOMCOMPTE, P.DATEINSCRIP, " +
                                   "P.DATEFERME, P.DATEDEBSEJOUR, P.DATEFINSEJOUR, " +
                                   "P.DATENAISCOMPTE, P.ADRMAILCOMPTE, P.NOTELCOMPTE, I.NOINSCRIP " +
                                   "FROM INSCRIPTION I, COMPTE P WHERE P.USER = I.USER " +
                                   "AND P.TYPEPROFIL = 'V' AND I.CODEANIM = '"+ uneActivite.CodeAnim +"' " +
                                   "AND I.DATEANNULE IS NULL AND I.DATEACT = '"+ dateActi.ToString("yyyy-MM-dd") + "'";
            cmd.CommandText = sqlTypeCompte;
            rdrVacancier = cmd.ExecuteReader();

            List<Vacanciere> listeVacancier = new List<Vacanciere>();

            string pseudo;
            string nomCompte;
            string prenomCompte;
            DateTime dateInscrip;
            DateTime dateFerme;
            DateTime dateDebSejour;
            DateTime dateFinSejour;
            DateTime dateNaissCompte;
            string adresseMailCompte;
            string noTelCompte;
            string noInscrip; 

            if (rdrVacancier.HasRows)
            {
                while (rdrVacancier.Read())
                {
                    pseudo = (string)rdrVacancier["USER"];
                    nomCompte = (string)rdrVacancier["NOMCOMPTE"];
                    prenomCompte = (string)rdrVacancier["PRENOMCOMPTE"];
                    dateInscrip = (DateTime)rdrVacancier["DATEINSCRIP"];
                    dateFerme = (DateTime)rdrVacancier["DATEFERME"];
                    dateDebSejour = (DateTime)rdrVacancier["DATEDEBSEJOUR"];
                    dateFinSejour = (DateTime) rdrVacancier["DATEFINSEJOUR"];
                    dateNaissCompte = (DateTime)rdrVacancier["DATENAISCOMPTE"];
                    adresseMailCompte = (string)rdrVacancier["ADRMAILCOMPTE"];
                    noTelCompte = (string)rdrVacancier["NOTELCOMPTE"];
                    noInscrip = Convert.ToString(rdrVacancier["NOINSCRIP"]);

                    Vacanciere uneVacanciere = new Vacanciere(pseudo, nomCompte, prenomCompte, dateInscrip, dateFerme, 
                                                              dateDebSejour, dateFinSejour, dateNaissCompte, adresseMailCompte,
                                                              noTelCompte, noInscrip);
                    listeVacancier.Add(uneVacanciere);
                }
            }
            rdrVacancier.Close();
            return listeVacancier;
        } 

        #endregion

        #endregion
        #region Vacancier 

        public static bool InscriptionVacancier(Activite uneActivite) // TO DO INSCRIPTION NE FONCTIONNE PAS 
        {
            if(Utilisateur.EstVacancier())
            {
                string dateInscript = DateTime.Now.ToString("yyyy-MM-dd");
                string dateAct = Convert.ToDateTime(uneActivite.DateAct).ToString("yyyy-MM-dd");
                string dateAnnul = Convert.ToDateTime(uneActivite.DateAnnuleAct).ToString("yyyy-MM-dd");
                string reqI;
                int nbMaj;
                MySqlCommand cmd = conn.CreateCommand();
                reqI = "INSERT INTO INSCRIPTION(NOINSCRIP, USER, CODEANIM, DATEACT, DATEINSCRIP, DATEANNULE) " +
                    "          VALUES(null ," +
                                      "'" + Utilisateur.GetPseudo() + "', '" + uneActivite.CodeAnim + "', " +
                                      "'" + dateAct + "' ," +
                                      " '" + dateInscript + "'" +
                                      ", null  )"; //to do
                cmd.CommandText = reqI;
                nbMaj = cmd.ExecuteNonQuery();
                if (nbMaj == 1)
                    return true;
                return false;
            }
            return false;
        }

        public static bool AnnulerInscriptionActivite(Activite uneActivite) // TO DO ANNULATION FONCTIONNE PAS 
        {
            if (Utilisateur.EstVacancier())
            {
                string dateInscript = DateTime.Now.ToString("yyyy-MM-dd");
                string dateAct = Convert.ToDateTime(uneActivite.DateAct).ToString("yyyy-MM-dd");
                string dateAnnul = Convert.ToDateTime(uneActivite.DateAnnuleAct).ToString("yyyy-MM-dd");

                string reqUpdteAnim;
                int nbMaj;
                MySqlCommand cmd = conn.CreateCommand(); 
                reqUpdteAnim = "UPDATE inscription SET DATEANNULE = '" + dateAnnul + "' " +
                               "WHERE DATEACT = '"+ dateAct + "' " +
                               "AND USER = '" + Utilisateur.GetPseudo() + "' " +
                               "AND CODEANIM = '"+ uneActivite.CodeAnim + "' ;";


                cmd.CommandText = reqUpdteAnim;
                nbMaj = cmd.ExecuteNonQuery();
                if (nbMaj == 1)
                    return true;
                return false;
            }
            return false;
        }

        public static bool ReinscriptionActivite(Activite uneActivite)
        {
            if (Utilisateur.EstVacancier())
            {
                string dateInscript = DateTime.Now.ToString("yyyy-MM-dd");
                string dateAct = Convert.ToDateTime(uneActivite.DateAct).ToString("yyyy-MM-dd");
                string dateAnnul = Convert.ToDateTime(uneActivite.DateAnnuleAct).ToString("yyyy-MM-dd");

                string reqUpdte;
                int nbMaj;
                MySqlCommand cmd = conn.CreateCommand();
                reqUpdte = "UPDATE inscription SET DATEANNULE = null " +
                               "WHERE DATEACT = '" + dateAct + "' " +
                               "AND USER = '" + Utilisateur.GetPseudo() + "' " +
                               "AND CODEANIM = '" + uneActivite.CodeAnim + "' ;";


                cmd.CommandText = reqUpdte;
                nbMaj = cmd.ExecuteNonQuery();
                if (nbMaj == 1)
                    return true;
                return false;
            }
            return false;
        }

        public static List<Activite> GetLesActivitesInscripVacancier()
        {
            MySqlDataReader rdrActivite;
            MySqlCommand cmd = conn.CreateCommand();
            string sqlActi = "SELECT a.CODEANIM, a.DATEACT, a.CODEETATACT, a.HRRDVACT, a.PRIXACT, a.HRDEBUTACT, " +
                             "a.HRFINACT, a.DATEANNULEACT, a.NOMRESP, a.PRENOMRESP " +
                             "FROM activite a, inscription i " +
                             "WHERE a.CODEANIM = i.CODEANIM " +
                             "AND a.DATEACT = i.DATEACT AND i.USER = '" + Utilisateur.GetPseudo() + "'" +
                             "AND a.CODEETATACT != 'AN'" +
                             "AND i.DATEANNULE IS NULL";

            cmd.CommandText = sqlActi;
            rdrActivite = cmd.ExecuteReader();

            List<Activite> listeActivite = new List<Activite>();

            string codeAnim;
            string dateAct; // !! format DATE dans la BDD !!
            string codeEtatAct;
            string hrRdvAct;
            Decimal prixActe; //voir comment utiliser le type Decimal (dans le programme et la BDD)
            string hrDebutAct; // !! format TIME dans la BDD !!
            string hrFinAct; // !! format TIME dans la BDD 
            string dateAnnuleAct; // !! format DATE dans la BDD !!
            string nomResp;
            string prenomRes;

            if (rdrActivite.HasRows)
            {
                while (rdrActivite.Read())
                {
                    codeAnim = (string)rdrActivite["CODEANIM"];
                    dateAct = Convert.ToString(rdrActivite["DATEACT"]);
                    codeEtatAct = (string)rdrActivite["CODEETATACT"];
                    hrRdvAct = Convert.ToString(rdrActivite["HRRDVACT"]);
                    prixActe = (Decimal)rdrActivite["PRIXACT"];
                    hrDebutAct = Convert.ToString(rdrActivite["HRDEBUTACT"]);
                    hrFinAct = Convert.ToString(rdrActivite["HRFINACT"]);
                    dateAnnuleAct = Convert.ToString(rdrActivite["DATEANNULEACT"]);
                    nomResp = (string)rdrActivite["NOMRESP"];
                    prenomRes = (string)rdrActivite["PRENOMRESP"];

                    Activite uneActivite = new Activite(codeAnim, dateAct, codeEtatAct, hrRdvAct, prixActe,
                                                        hrDebutAct, hrFinAct, dateAnnuleAct, nomResp, prenomRes);
                    listeActivite.Add(uneActivite);
                }
            }
            rdrActivite.Close();
            return listeActivite;
        }

        /// <summary>
        /// Récupère une activité 
        /// </summary>
        /// <param name="testActivite"></param>
        /// <returns></returns>
        public static Activite GetActivite(Activite testActivite)
        {
            {
                string testDateAct = Convert.ToDateTime(testActivite.DateAct).ToString("yyyy-MM-dd");

                MySqlDataReader rdrActivite;
                MySqlCommand cmd = conn.CreateCommand();
                string sqlActi = "SELECT a.CODEANIM, a.DATEACT, a.CODEETATACT, a.HRRDVACT, a.PRIXACT, a.HRDEBUTACT, " +
                                 "a.HRFINACT, a.DATEANNULEACT, a.NOMRESP, a.PRENOMRESP " +
                                 "FROM activite a, inscription i " +
                                 "WHERE a.CODEANIM = i.CODEANIM " +
                                 "AND a.DATEACT = i.DATEACT AND i.USER = '" + Utilisateur.GetPseudo() + "'" +
                                 "AND a.CODEETATACT != 'AN'" +
                                 "AND i.DATEANNULE IS NULL" +
                                 "AND a.DATEACT = '" + testDateAct + "'" +
                                 "AND a.CODEANIM = '" + testActivite.CodeAnim + "'";

                cmd.CommandText = sqlActi;
                rdrActivite = cmd.ExecuteReader();

                List<Activite> listeActivite = new List<Activite>();

                string codeAnim;
                string dateAct; // !! format DATE dans la BDD !!
                string codeEtatAct;
                string hrRdvAct;
                Decimal prixActe; //voir comment utiliser le type Decimal (dans le programme et la BDD)
                string hrDebutAct; // !! format TIME dans la BDD !!
                string hrFinAct; // !! format TIME dans la BDD 
                string dateAnnuleAct; // !! format DATE dans la BDD !!
                string nomResp;
                string prenomRes;

                Activite uneActivite = null;

                if (rdrActivite.HasRows)
                {
                    if (rdrActivite.Read())
                    {
                        codeAnim = (string) rdrActivite["CODEANIM"];
                        dateAct = Convert.ToString(rdrActivite["DATEACT"]);
                        codeEtatAct = (string) rdrActivite["CODEETATACT"];
                        hrRdvAct = Convert.ToString(rdrActivite["HRRDVACT"]);
                        prixActe = (Decimal) rdrActivite["PRIXACT"];
                        hrDebutAct = Convert.ToString(rdrActivite["HRDEBUTACT"]);
                        hrFinAct = Convert.ToString(rdrActivite["HRFINACT"]);
                        dateAnnuleAct = Convert.ToString(rdrActivite["DATEANNULEACT"]);
                        nomResp = (string) rdrActivite["NOMRESP"];
                        prenomRes = (string) rdrActivite["PRENOMRESP"];

                        uneActivite = new Activite(codeAnim, dateAct, codeEtatAct, hrRdvAct, prixActe,
                            hrDebutAct, hrFinAct, dateAnnuleAct, nomResp, prenomRes);
                        return uneActivite;
                    }
                }

                rdrActivite.Close();
                return uneActivite;
            }
        }

        public static int GetNbPlaceDispo(Activite uneActivite)
        {
            string reqNbPlaceDispo;
            DateTime dateActi = Convert.ToDateTime(uneActivite.DateAct);
            Object nbMaj;
            MySqlCommand cmd = conn.CreateCommand();
            reqNbPlaceDispo = "SELECT AN.NBREPLACEANIM - (SELECT COUNT(I.USER)AS NBPLACEDISPO FROM inscription I " +
                              "WHERE I.DATEACT = '"+ dateActi.ToString("yyyy-MM-dd") + "' " +
                              "AND I.CODEANIM = '"+ uneActivite.CodeAnim + "') AS NBPLACEDISPO " +
                              "FROM  animation AN " +
                              "WHERE AN.CODEANIM = '"+ uneActivite.CodeAnim + "' ;";
            cmd.CommandText = reqNbPlaceDispo;
            nbMaj = cmd.ExecuteScalar();
            int nbPlacesDispo = Convert.ToInt32(nbMaj);
            if (nbPlacesDispo != 0)
                return nbPlacesDispo;
            return 0;
        }

        public static bool VerifierInscription(Activite uneActivite)
        {
            string reqNbInscrip;
            DateTime dateActi = Convert.ToDateTime(uneActivite.DateAct);
            Object nbMaj;
            MySqlCommand cmd = conn.CreateCommand();
            reqNbInscrip = "SELECT COUNT(I.USER)AS NBINSCRIP " +
                           "FROM inscription I " +
                           "WHERE I.DATEACT = '" + dateActi.ToString("yyyy-MM-dd") + "' " +
                           "AND I.CODEANIM = '" + uneActivite.CodeAnim + "'" +
                           "AND I.USER = '" + Utilisateur.GetPseudo() + "';";
            cmd.CommandText = reqNbInscrip;
            nbMaj = cmd.ExecuteScalar();
            if (Convert.ToInt32(nbMaj) == 0) //si le vacancier n'est pas déjà inscrit, retourne faux, s'il est déjà inscrit
                return false;                // retourne vrai   
            return true;
        }

        public static int GetNoInscrip(Activite uneActivite)
        {
            string reqNbInscrip;
            DateTime dateActi = Convert.ToDateTime(uneActivite.DateAct);
            Object nbMaj;
            MySqlCommand cmd = conn.CreateCommand();
            reqNbInscrip = "SELECT NOINSCRIP " +
                           "FROM inscription I " +
                           "WHERE I.DATEACT = '" + dateActi.ToString("yyyy-MM-dd") + "' " +
                           "AND I.CODEANIM = '" + uneActivite.CodeAnim + "'" +
                           "AND I.USER = '" + Utilisateur.GetPseudo() + "';";
            cmd.CommandText = reqNbInscrip;
            nbMaj = cmd.ExecuteScalar();
            
            return Convert.ToInt32(nbMaj);
        }

        public static bool estCreneauValide(Activite uneActivite)
        {
            List<Activite> lesActivites = new List<Activite>();
            DateTime dateActi = Convert.ToDateTime(uneActivite.DateAct);
           
            string sTous = "SELECT a.CODEANIM, a.DATEACT, a.CODEETATACT, a.HRRDVACT, a.PRIXACT, a.HRDEBUTACT, a.HRFINACT, a.DATEANNULEACT, a.NOMRESP, a.PRENOMRESP " +
                           "FROM activite A, inscription i " +
                           "WHERE A.DATEACT = '" + dateActi.ToString("yyyy-MM-dd") + "' " +
                           "AND i.USER = '" + Utilisateur.GetPseudo() + "' " +
                           "GROUP BY a.CODEANIM";
            string codeAnim;
            string dateAct;
            string codeEtatAct;
            string hrRdvAct;
            Decimal prixActe;
            string hrDebutAct;
            string hrFinAct;
            string dateAnnuleAct;
            string nomResp;
            string prenomRes;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sTous;
            MySqlDataReader rdrActivite = cmd.ExecuteReader();

            if (rdrActivite.HasRows)
            {
                while (rdrActivite.Read())
                {
                    codeAnim = (string)rdrActivite["CODEANIM"];
                    dateAct = Convert.ToString(rdrActivite["DATEACT"]).Substring(0, 11); // Récupere seulement la date et vire l'heure chiante (hh:mm:ss)
                    codeEtatAct = (string)rdrActivite["CODEETATACT"];
                    hrRdvAct = Convert.ToString(rdrActivite["HRRDVACT"]).Substring(0, 5);
                    prixActe = (Decimal)rdrActivite["PRIXACT"];
                    hrDebutAct = Convert.ToString(rdrActivite["HRDEBUTACT"]).Substring(0, 5);
                    hrFinAct = Convert.ToString(rdrActivite["HRFINACT"]).Substring(0, 5);
                    dateAnnuleAct = Convert.ToString(rdrActivite["DATEANNULEACT"]);
                    nomResp = Convert.ToString(rdrActivite["NOMRESP"]);
                    prenomRes = Convert.ToString(rdrActivite["PRENOMRESP"]);

                    Activite testActivite = new Activite(codeAnim, dateAct, codeEtatAct, hrRdvAct, prixActe,
                        hrDebutAct, hrFinAct, dateAnnuleAct, nomResp, prenomRes);
                    lesActivites.Add(testActivite);
                }
                rdrActivite.Close();
            }

            foreach (Activite a in lesActivites)
            {
                
            }
            rdrActivite.Close();
            return true;
        }

        #endregion

        /*
        //ORM, intéractions avec les objets Etudiants
        public static bool AjouterEtudiant(Etudiant leEtudiant)
        {
            Etudiant unEtudiant = leEtudiant;
            string reqI;
            int nbMaj;
            MySqlCommand cmd = conn.CreateCommand();
            reqI = "INSERT INTO etudiant(id, nom, noteOrale, noteEcrit) VALUES(null, '" + unEtudiant.GetNom() + "'," + unEtudiant.GetOrale().ToString().Replace(",", ".") + "," + unEtudiant.GetEcrit().ToString().Replace(",", ".") + ")";
            cmd.CommandText = reqI;
            nbMaj = cmd.ExecuteNonQuery();
            if (nbMaj == 1)
                return true;
            return false;
        }

        public static bool ModifierEtudiant(Etudiant unEtudiant)
        {
            string reqUpdteEtu;
            int nbMaj;
            MySqlCommand cmd = conn.CreateCommand();
            reqUpdteEtu = "UPDATE etudiant SET nom = '" + unEtudiant.GetNom() + "', noteOrale =" + unEtudiant.GetOrale().ToString().Replace(",", ".") + ", noteEcrit =" + unEtudiant.GetEcrit().ToString().Replace(",", ".") + " WHERE nom LIKE'" + unEtudiant.GetNom() + "'";
            cmd.CommandText = reqUpdteEtu;
            nbMaj = cmd.ExecuteNonQuery();
            if (nbMaj == 1)
                return true;
            return false;
        }

        public static bool ExisteEtudiant(Etudiant unEtudiant)
        {
            string reqExiste;
            Object nbMaj;
            MySqlCommand cmd = conn.CreateCommand();
            reqExiste = "SELECT COUNT(*) FROM etudiant WHERE nom like '%" + unEtudiant.GetNom() + "%' ";
            cmd.CommandText = reqExiste;
            nbMaj = cmd.ExecuteScalar();
            if (nbMaj != null)
                return true;
            return false;
        }

        public static Etudiant GetLeader()
        {
            string reqLeader = "SELECT nom, noteOrale, noteEcrit FROM etudiant where ((noteOrale + noteEcrit) / 2) =" +
                "(SELECT MAX((noteOrale + noteEcrit) /2)from etudiant)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = reqLeader;
            MySqlDataReader rdrLeader = cmd.ExecuteReader();
            Etudiant leader;
            string nomLeader;
            float noteOraleLeader;
            float noteEcritLeader;

            if (rdrLeader.Read())
            {
                nomLeader = rdrLeader.GetString("nom");
                noteOraleLeader = rdrLeader.GetFloat("noteOrale");
                noteEcritLeader = rdrLeader.GetFloat("noteEcrit");
                leader = new Etudiant(nomLeader, noteEcritLeader, noteOraleLeader);
                rdrLeader.Close();
                return leader;
            }
            rdrLeader.Close();
            return null;
        }

        public static int GetNombreEtudiant()
        {
            string reqNbEtu;
            Object nbMaj;
            MySqlCommand cmd = conn.CreateCommand();
            reqNbEtu = "SELECT COUNT(*) FROM etudiant";
            cmd.CommandText = reqNbEtu;
            nbMaj = cmd.ExecuteScalar();
            int nbEtudiant = Convert.ToInt32(nbMaj);
            if (nbEtudiant != 0)
                return nbEtudiant;
            return 0;

        }

        public static float GetMoyenneSection()
        {
            string reqMoySection;
            Object moySectionSql;
            MySqlCommand cmd = conn.CreateCommand();
            reqMoySection = "SELECT (AVG(noteOrale) + AVG(noteEcrit))/2 FROM etudiant";
            cmd.CommandText = reqMoySection;
            moySectionSql = cmd.ExecuteScalar();
            float moySection = Convert.ToSingle(moySectionSql);
            if (moySection != 0)
                return moySection;
            return 0;
        }

        public static float GetMoyenneEtudiant(Etudiant unEtudiant)
        {
            string reqMoyEtu;
            Object moyEtudiantSQL;
            MySqlCommand cmd = conn.CreateCommand();
            reqMoyEtu = "SELECT (AVG(noteOrale) + AVG(noteEcrit))/2 FROM etudiant WHERE nom LIKE '" + unEtudiant.GetNom() + "'";
            cmd.CommandText = reqMoyEtu;
            moyEtudiantSQL = cmd.ExecuteScalar();
            float moyEtudiant = Convert.ToSingle(moyEtudiantSQL);
            if (moyEtudiant != 0)
                return moyEtudiant;
            return 0;
        }

        public static bool SupprimerEtudiant(Etudiant unEtudiant)
        {
            Object supprEtuSQL;
            MySqlCommand cmd = conn.CreateCommand();
            string reqSupprEtu = "DELETE FROM etudiant WHERE nom LIKE '" + unEtudiant.GetNom() + "'";
            cmd.CommandText = reqSupprEtu;
            supprEtuSQL = cmd.ExecuteNonQuery();
            int nbSuppression = Convert.ToInt32(supprEtuSQL);
            if (nbSuppression == 1)
                return true;
            return false;
        }

        public static List<Etudiant> ChargerEtudiants()
        {
            List<Etudiant> lesEtudiants = new List<Etudiant>();
            MySqlCommand cmd = conn.CreateCommand();
            string sTous = "SELECT * FROM ETUDIANT";
            cmd.CommandText = sTous;
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Etudiant unEtudiant = new Etudiant((string)rdr["nom"], (float)rdr["noteEcrit"], (float)rdr["noteOrale"]);
                lesEtudiants.Add(unEtudiant);
            }
            rdr.Close();
            return lesEtudiants;
        }
        */
    }

}

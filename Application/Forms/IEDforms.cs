using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IHM.Forms
{
    public partial class IEDforms : Form
    {
        public IEDforms()
        {
            InitializeComponent();
            //Initialise la taille max des textes
            IP1txt.MaxLength = 3;
            IP2txt.MaxLength = 3;
            IP3txt.MaxLength = 1;
            IP4txt.MaxLength = 1;
            MAC1txt.MaxLength = 3;
            MAC2txt.MaxLength = 3;
            MAC3txt.MaxLength = 3;
            MAC4txt.MaxLength = 3;
            Porttxt.MaxLength = 3;
            UIDtxt.MaxLength = 1;
        }
        public bool SameIED()
        {
            bool Same = false; //On initalise la variable comme fausse
            if (GridDonnee.Rows.Count > 0) // On recherche si la donnée est identique uniquement lorsque la liste comporte au moins une ligne 
            {
                for (int i = 0; i < GridDonnee.Rows.Count; i++) // On parcours toutes les données déja dans le tableau
                {
                    if (GridDonnee.Rows[i].Cells[3].Value.ToString() == Nomtxt.Text) //Si une valeur du tableau est identique à la valeur rentre par l'utilisateur alors on passe le flag à vrai
                    {
                        Same = true;
                        break;
                    }
                }
            }
            return Same;
        }

        // Variable Globale
        String pathIMG;
        public void ImageIED_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false; //Permet à l'utilisateur de ne choisir que un fichier image
            openFileDialog.Filter = "All picture files (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathIMG = openFileDialog.FileName;
                ImageIED.Image = new Bitmap(pathIMG); // Permet de creer une instance de notre image
            }

        }
        public void Effacer_Click(object sender, EventArgs e)
        {
            Marquetxt.Text = "";
            Modeletxt.Text = "";
            Nomtxt.Text = "";
            IP1txt.Text = "";
            IP2txt.Text = "";
            IP3txt.Text = "";
            IP4txt.Text = "";
            MAC1txt.Text = "";
            MAC2txt.Text = "";
            MAC3txt.Text = "";
            MAC4txt.Text = "";
            Porttxt.Text = "";
            UIDtxt.Text = "";
            ImageIED.Image = null;
        }

        public void Vider_Click(object sender, EventArgs e)
        {
            GridDonnee.Rows.Clear(); // On supprime toutes les données du tableau
            Gestion.ListeRelais.Clear(); //Supprime toute la liste de relais selectionnées
            Gestion.FNrelais.RefreshListe();
        }
        public void Supprimer_Click(object sender, EventArgs e)
        {
            if (GridDonnee.Rows.Count > 0)
            {
                int Ligne = GridDonnee.CurrentRow.Index; //On initialise une variable qui prend comme paramètre le nom de la ligne du tabelau selectionnée
                int indextab = 0;
                for (int i = 0; i < Gestion.ListeRelais.Count; i++)
                {
                    if (Gestion.ListeRelais[i].getNom() == GridDonnee.CurrentRow.Cells[3].Value)
                    {
                        indextab = i;
                        break;
                    }

                }
                GridDonnee.Rows.RemoveAt(Ligne);
                Gestion.ListeRelais.RemoveAt(indextab); //Supprime dans la liste de relais le relais selectionné
                Gestion.FNrelais.RefreshListe();
            }

        }
        public void Rechercher_Click(object sender, EventArgs e)
        {
            if (SameIED()) //Si la méthode renvoie Same = Vrai
            {
                MessageBox.Show("The IED exists", "Found!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The IED doesn't exists", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Variables Globales
        String ResultMarque;
        String ResultModele;
        String ResultNom;
        String ResultIP;
        String ResultMAC;
        String ResultPort;
        String ResultUID;
        String ResultpathImage;

        public void Ajouter_Click(object sender, EventArgs e)
        {
            if (!SameIED()) //Si la méthode renvoie Same = Faux alors c'est qu'il n'existe pas de relais sous ce nom on peut donc le créer
            {
                if (TESTIED())
                {
                    try
                    {
                        // Stockage des résultats
                        ResultMarque = Marquetxt.Text.ToString();
                        ResultModele = Modeletxt.Text.ToString();
                        ResultNom = Nomtxt.Text.ToString();
                        ResultIP = (float.Parse(IP1txt.Text) + "." + float.Parse(IP2txt.Text) + "." + float.Parse(IP3txt.Text) + "." + float.Parse(IP4txt.Text)).ToString();
                        ResultMAC = (float.Parse(MAC1txt.Text) + "." + float.Parse(MAC2txt.Text) + "." + float.Parse(MAC3txt.Text) + "." + float.Parse(MAC4txt.Text)).ToString();
                        ResultPort = (float.Parse(Porttxt.Text)).ToString();
                        ResultUID = (float.Parse(UIDtxt.Text)).ToString();
                        GridDonnee.Rows.Add(ResultMarque, ResultModele, ImageIED.Image, ResultNom, ResultIP, ResultMAC, ResultPort, ResultUID);
                        // Stockage des relais dans une liste (Relais list préalablement crée)
                        Relais relais = new Relais(ResultMarque, ResultModele, ResultNom, ResultIP, ResultMAC, Convert.ToInt32(ResultPort), Convert.ToInt32(ResultUID), ImageIED.Image, pathIMG); // Definit un objet relais
                        Gestion.ListeRelais.Add(relais); // Ajout du relais à la liste de relais
                        Gestion.FNrelais.RefreshListe();
                    }
                    catch
                    {
                        MessageBox.Show("Please note the format", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The data of the IED is not correct please correct it", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The IED already exists", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool TESTIED()
        {
            bool FlagTESTIED = false;
            if (Nomtxt.Text.Length > 0 && Nomtxt.Text != "" && Modeletxt.Text.Length > 0 && Modeletxt.Text != "" && Marquetxt.Text.Length > 0 && Marquetxt.Text != "" && ImageIED.Image != null)
            {
                FlagTESTIED = true;
            }
            return FlagTESTIED;
        }

        public void AjoutModif()
        {
            // Stockage des résultats
            ResultMarque = Marquetxt.Text.ToString();
            ResultModele = Modeletxt.Text.ToString();
            ResultNom = Nomtxt.Text.ToString();
            ResultIP = (float.Parse(IP1txt.Text) + "." + float.Parse(IP2txt.Text) + "." + float.Parse(IP3txt.Text) + "." + float.Parse(IP4txt.Text)).ToString();
            ResultMAC = (float.Parse(MAC1txt.Text) + "." + float.Parse(MAC2txt.Text) + "." + float.Parse(MAC3txt.Text) + "." + float.Parse(MAC4txt.Text)).ToString();
            ResultPort = (float.Parse(Porttxt.Text)).ToString();
            ResultUID = (float.Parse(UIDtxt.Text)).ToString();

            // Stockage des relais dans une liste (Relais list préalablement crée)
            Relais relais = new Relais(ResultMarque, ResultModele, ResultNom, ResultIP, ResultMAC, Convert.ToInt32(ResultPort), Convert.ToInt32(ResultUID), ImageIED.Image, pathIMG); // Definit un objet relais
            Gestion.ListeRelais.Add(relais); // Ajout du relais à la liste de relais
            Gestion.FNrelais.RefreshListe();
        }

        int ligneselec = -1;
        public void Modifier_Click(object sender, EventArgs e)
        {
            if (GridDonnee.Rows.Count > 0)
            {
                if (ligneselec == -1)
                {
                    ligneselec = GridDonnee.CurrentCell.RowIndex; //La variable prend le numéro de la ligne selectionnée

                    // Suppression de l'IED dans l'object relais avant de le modifier 
                    int indextab = 0;
                    for (int i = 0; i < Gestion.ListeRelais.Count; i++)
                    {
                        if (Gestion.ListeRelais[i].getNom() == GridDonnee.CurrentRow.Cells[3].Value)
                        {
                            indextab = i;
                            break;
                        }

                    }

                    // Récupération des informations pour la mofification
                    Marquetxt.Text = GridDonnee.Rows[ligneselec].Cells[0].Value.ToString(); //Affiche dans la case Marque la valeur du tableau correspondant
                    Modeletxt.Text = GridDonnee.Rows[ligneselec].Cells[1].Value.ToString();
                    ImageIED.Image = (Image)GridDonnee.Rows[ligneselec].Cells[2].Value;
                    Nomtxt.Text = GridDonnee.Rows[ligneselec].Cells[3].Value.ToString();
                    pathIMG = Gestion.ListeRelais[indextab].getpath();
                    //Variable de récupération
                    String[] RecupIP;
                    String[] RecupMAC;
                    RecupIP = GridDonnee.Rows[ligneselec].Cells[4].Value.ToString().Split(".");
                    IP1txt.Text = RecupIP[0].ToString();
                    IP2txt.Text = RecupIP[1].ToString();
                    IP3txt.Text = RecupIP[2].ToString();
                    IP4txt.Text = RecupIP[3].ToString();
                    RecupMAC = GridDonnee.Rows[ligneselec].Cells[5].Value.ToString().Split(".");
                    MAC1txt.Text = RecupMAC[0].ToString();
                    MAC2txt.Text = RecupMAC[1].ToString();
                    MAC3txt.Text = RecupMAC[2].ToString();
                    MAC4txt.Text = RecupMAC[3].ToString();

                    Porttxt.Text = GridDonnee.Rows[ligneselec].Cells[6].Value.ToString();
                    UIDtxt.Text = GridDonnee.Rows[ligneselec].Cells[7].Value.ToString();

                    //Desactive les boutons Ajouer effacer rechercher pendant la manipulation
                    Ajouter.Enabled = false;
                    Effacer.Enabled = false;
                    Rechercher.Enabled = false;
                    Fromtxt.Enabled = false;
                    Supprimer.Enabled = false;
                    Vider.Enabled = false;
                    Modifier.Text = "Validate"; //Modification de l'affichage du bouton pour confirmer le choix
                    Gestion.ListeRelais.RemoveAt(indextab); //Supprime dans la liste de relais le relais selectionné
                    Gestion.FNrelais.RefreshListe();
                }
                else
                {
                    GridDonnee.Rows[ligneselec].Cells[0].Value = Marquetxt.Text;
                    GridDonnee.Rows[ligneselec].Cells[1].Value = Modeletxt.Text;
                    GridDonnee.Rows[ligneselec].Cells[2].Value = ImageIED.Image;
                    GridDonnee.Rows[ligneselec].Cells[3].Value = Nomtxt.Text;

                    //Restockage des valeurs
                    GridDonnee.Rows[ligneselec].Cells[4].Value = IP1txt.Text + "." + IP2txt.Text + "." + IP3txt.Text + "." + IP4txt.Text;
                    GridDonnee.Rows[ligneselec].Cells[5].Value = MAC1txt.Text + "." + MAC2txt.Text + "." + MAC3txt.Text + "." + MAC4txt.Text;
                    //
                    GridDonnee.Rows[ligneselec].Cells[6].Value = Porttxt.Text;
                    GridDonnee.Rows[ligneselec].Cells[7].Value = UIDtxt.Text;

                    // Ajout du l'objet relais modifié
                    AjoutModif();

                    //
                    // Réactiver les boutons
                    Fromtxt.Enabled = true;
                    Ajouter.Enabled = true;
                    Effacer.Enabled = true;
                    Rechercher.Enabled = true;
                    Supprimer.Enabled = true;
                    Vider.Enabled = true;
                    Modifier.Text = "Modify";
                    //Initialiser la ligne 
                    ligneselec = -1;

                }
            }
            else
            {
            }
        }

        private void FromExcel_Click(object sender, EventArgs e)
        {
            openFileDialogtxt.Multiselect = false; //Permet à l'utilisateur de ne choisir que un fichier 
            openFileDialogtxt.Filter = "Text|*.txt|All|*.*";//Permet de ne choisir que les fichiers de type txt
            if (openFileDialogtxt.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialogtxt.FileName;

                StreamReader lecturefichier = new StreamReader(filepath);

                //Déclaration d'une variable qui lit toutes les lignes
                string ligne = lecturefichier.ReadToEnd();
                //On sépare les résultats entre chaque IED
                string[] result = ligne.Split('~');
                //On sépare les données de chaque IED
                for (int i = 0; i < result.Length - 1; i++)
                {
                    //MessageBox.Show(result.Length.ToString()); //7 
                    string[] result2 = result[i].Split('|');
                    //MessageBox.Show(result2.Length.ToString()); // 8
                    for (int a = 0; a < result2.Length - 1; a++)
                    {
                        // MessageBox.Show(image.ToString()); // 8
                        ResultMarque = result2[0];
                        ResultModele = result2[1];
                        ResultNom = result2[2];
                        ResultIP = result2[3];
                        ResultMAC = result2[4];
                        ResultPort = result2[5];
                        ResultUID = result2[6];
                        ResultpathImage = result2[8];
                        //MessageBox.Show(pathImage);
                        ImageIED.Image = new Bitmap(ResultpathImage);
                    }

                    // Stockage des relais dans une liste (Relais liste préalablement crée)
                    Relais relais = new Relais(ResultMarque, ResultModele, ResultNom, ResultIP, ResultMAC, Convert.ToInt32(ResultPort), Convert.ToInt32(ResultUID), ImageIED.Image, ResultpathImage); // Definit un objet relais
                    Gestion.ListeRelais.Add(relais); // Ajout du relais à la liste de relais
                    //MessageBox.Show(Gestion.ListeRelais[i].getIP().ToString());
                    GridDonnee.Rows.Add(Gestion.ListeRelais[i].getMarque().ToString(), Gestion.ListeRelais[i].getModele().ToString(), ImageIED.Image, Gestion.ListeRelais[i].getNom().ToString(), Gestion.ListeRelais[i].getIP().ToString(), Gestion.ListeRelais[i].getMAC().ToString(), Gestion.ListeRelais[i].getPort().ToString(), Gestion.ListeRelais[i].getUID().ToString());
                    Gestion.FNrelais.RefreshListe();
                }
                ImageIED.Image = null;
                lecturefichier.Close();
            }
        }

        private void IEDforms_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Fonctionnement");
            string execPath = AppDomain.CurrentDomain.BaseDirectory;
            string pathtxtload = execPath + "IEDsave.txt";
            if (File.Exists(pathtxtload))
            {
                StreamReader lecturefichier = new StreamReader(pathtxtload);
                //Déclaration d'une variable qui lit toutes les lignes
                string ligne = lecturefichier.ReadToEnd();
                //On sépare les résultats entre chaque IED
                string[] result = ligne.Split('~');
                //On sépare les données de chaque IED
                for (int i = 0; i < result.Length - 1; i++)
                {
                    //MessageBox.Show(result.Length.ToString()); //7 
                    string[] result2 = result[i].Split('|');
                    //MessageBox.Show(result2.Length.ToString()); // 8
                    for (int a = 0; a < result2.Length - 1; a++)
                    {
                        // MessageBox.Show(image.ToString()); // 8
                        ResultMarque = result2[0];
                        ResultModele = result2[1];
                        ResultNom = result2[2];
                        ResultIP = result2[3];
                        ResultMAC = result2[4];
                        ResultPort = result2[5];
                        ResultUID = result2[6];
                        ResultpathImage = result2[8];
                        //MessageBox.Show(Resultpath);
                        ImageIED.Image = new Bitmap(ResultpathImage);
                    }
                    // Stockage des relais dans une liste (Relais liste préalablement crée)
                    Relais relais = new Relais(ResultMarque, ResultModele, ResultNom, ResultIP, ResultMAC, Convert.ToInt32(ResultPort), Convert.ToInt32(ResultUID), ImageIED.Image, ResultpathImage); // Definit un objet relais
                    Gestion.ListeRelais.Add(relais); // Ajout du relais à la liste de relais
                    Gestion.FNrelais.RefreshListe();
                }
                lecturefichier.Close();
                if (Gestion.ListeRelais.Count > 0)
                {
                    for (int i = 0; i < Gestion.ListeRelais.Count; i++)
                    {
                        //MessageBox.Show(Gestion.ListeRelais[i].getIP().ToString());
                        GridDonnee.Rows.Add(Gestion.ListeRelais[i].getMarque().ToString(), Gestion.ListeRelais[i].getModele().ToString(), ImageIED.Image, Gestion.ListeRelais[i].getNom().ToString(), Gestion.ListeRelais[i].getIP().ToString(), Gestion.ListeRelais[i].getMAC().ToString(), Gestion.ListeRelais[i].getPort().ToString(), Gestion.ListeRelais[i].getUID().ToString()); ;
                    }
                }
                lecturefichier.Close();
                ImageIED.Image = null;
            }

        }
    }
}
   

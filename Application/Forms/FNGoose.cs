using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Security;

namespace IHM.Forms
{
    public partial class FNGoose : Form
    {
        public static byte flag_goose = 0; //indique quand un nouveau message Goose est receptionné
        public static string reception_goose;
        public static string Time_actual;
        public static string Nom_relais;
        public static string Nom_Defaut;
        public static string Nom_Phase1;
        public static string Nom_Phase2;
        public static string Nom_Phase3;
        private static int compteur_tableau=0;
        byte[] Interface_ID;
        int compteur = 0;
        private int flag_goose_started=0;
        private Thread myGoose_thread;
        string checkedItems;

        public FNGoose()
        {
            InitializeComponent();
           
        }

        [DllImport("HIRTH_TEANI.dll")]
        static extern void osKernelStart(string ID);    

        [DllImport("HIRTH_TEANI.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.BStr)]

        static extern string send_data(string tableName);


        public void ViderGoose_Click(object sender, EventArgs e)
        {
            GridGoose.Rows.Clear(); // On supprime toutes les données du tableau
            compteur_tableau = 0;
        }

        public void SupprimerGoose_Click(object sender, EventArgs e)
        {
            if (GridGoose.Rows.Count > 0)
            {
                int ligne = GridGoose.CurrentRow.Index; //On prend l'index de la ligne sélectionné
                GridGoose.Rows.RemoveAt(ligne);
                compteur_tableau--;
            }
            else
            {
            }

        }

        public void ExpoExcel_Click(object sender, EventArgs e)
        {
            if (GridGoose.Rows.Count > 0)
            {
                Excel.Application ExportExcel = new Excel.Application();
                ExportExcel.Application.Workbooks.Add(Type.Missing); //Creer un nouveau classeur excel actif

                // Recopie le texte au dessus des données pour chaque colonne
                for (int i = 1; i < GridGoose.Columns.Count + 1; i++)
                {
                    ExportExcel.Cells[1, i] = GridGoose.Columns[i - 1].HeaderText;
                }

                //Recopie les lignes et les collonnes dans le fichier excel
                // i index de la ligne et j index de la colonne
                for (int i = 0; i < GridGoose.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < GridGoose.Columns.Count; j++)
                    {
                        ExportExcel.Cells[i + 2, j + 1] = GridGoose.Rows[i].Cells[j].Value.ToString(); // Commence dans la case Excel Ligne 2 et colonne 1
                    }
                }
                ExportExcel.Columns.AutoFit(); // Permet de donnée la bonne taille de cellule en fonction de la dimension de la donnée
                ExportExcel.Visible = true; // On affiche la fenêtre à l'écran
            }
        }

        public void timer_goose_Tick(object sender, EventArgs e)
        {
            if (flag_goose_started == 1) //l'interface existe matériellement, en attente de reception de message
            {
                //check toutes les 250ms si nouveau message
                string envoi = "Request for data";
                string reception = send_data(envoi);
                compteur++; //compteur synchro avec le DLL pour savoir si nouveau message reçu entre chaque check
                var match = reception.Split('|');
                string Nombre_reçu = match[0];
                var GocBref = match[1];
                var GoID = match[2];
                var Data = match[3];
                int compteur_check = Convert.ToInt32(Nombre_reçu);
                if(compteur_check == 999999 || compteur == 99999)
                {
                    compteur = 0;
                }
                
                if (compteur_check < compteur || compteur_check==0) //même trame que déjà reçu
                {
                    compteur--;
                }
                else
                {
                    compteur_tableau++;
                    compteur = compteur_check; //resynchro des compteurs
                    string[] token_GocBref = GocBref.Split(new[] { "CON" }, StringSplitOptions.None);
                    Nom_relais = token_GocBref[0];

                    string[] token_GoID = GoID.Split('_');
                    Nom_Defaut = token_GoID[1];

                    string Data1 = Data.Substring(2, Data.Length - 2) + Data.Substring(0, 2); // shift de 2 pour enlever les {

                    string[] token_Data = Data.Split(',');
                    Nom_Phase1 = token_Data[2];
                    Nom_Phase2 = token_Data[4];
                    Nom_Phase3 = token_Data[6];

                    //obtention du temps
                    DateTime dateTime = DateTime.Now;
                    Time_actual = dateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                    //Ajout de la ligne du défaut dans le tableau datagridview du goose
                    GridGoose.Rows.Add(compteur_tableau,Time_actual, Nom_relais, Nom_Defaut, Nom_Phase1, Nom_Phase2, Nom_Phase2);
                }
            }

    }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            checkedItems = InterfaceID_list.CheckedItems.Cast<object>().Aggregate(string.Empty, (current, item) => current + item.ToString());  //regarde quelle valeur est cochée
            if(checkedItems == "") //pas de case cochée
            {
                MessageBox.Show("Please select an Interface ID and press Start Button ", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //int ID_int = Convert.ToInt32(checkedItems);
               // byte[] intBytes = BitConverter.GetBytes(ID_int);
                //Array.Reverse(intBytes);
                //Interface_ID = intBytes;     //conversion
                myGoose_thread = new Thread(New_Thread_create);  //création nouveau thread
                myGoose_thread.IsBackground = true;
                myGoose_thread.Start();     //démarrage en tâche de fond

                Button_Start.Visible = false;   //goose_observer dans la boucle infinie, impossible de rémarrer, bouton start désactivé
                Boutton_Stop.Visible = true;   //goose_observer dans la boucle infinie, impossible de rémarrer, bouton start désactivé
            }
            Thread.Sleep(200);
            if(flag_goose_started == 1) //l'interface existe matériellement, en attente de reception de message
            {
                ON_OFF_Label.Text = "ON";
                ON_OFF_Label.ForeColor = Color.Green;
                MessageBox.Show("The Interface ID exists, Goose Observer has started. If nothing is received, please check the InterfaceID", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                timer_goose.Enabled = true;
            }
            else if (flag_goose_started == 2) //l'interface n'existe pas matériellement, impossible de démarrer
            {
                ON_OFF_Label.Text = "OFF";
                ON_OFF_Label.ForeColor = Color.Red;
                Button_Start.Visible = true;   //goose_observer dans la boucle infinie, impossible de rémarrer, bouton start désactivé
                Boutton_Stop.Visible = false;
            }
        }

        private void New_Thread_create() //creation nouveau thread
        {
            try
            {
                flag_goose_started = 1; // a démarré
                Launch_Goose_Observer();  
            }
            catch (Exception ex)
            {
                flag_goose_started = 2; //echec démarrage
                MessageBox.Show("Failed to start Goose Observer. Please check that the 2 DLLs are in System32 Folder, the Interface ID or if winpcap is running, and restart the App ", "Internal Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //[MethodImpl(MethodImplOptions.Noinlining)]
        void Launch_Goose_Observer()
        {
            osKernelStart(checkedItems);  //fonction DLL, paramètre case cochée
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //une seule case check à la fois
            int index = InterfaceID_list.SelectedIndex;
            int count = InterfaceID_list.Items.Count;

            for(int i = 0; i < count; i++)
            {
                if(index != i)
                {
                    InterfaceID_list.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }


        private void Boutton_Stop_Click(object sender, EventArgs e)
        {
            Button_Start.Visible = true;   //goose_observer dans la boucle infinie, impossible de rémarrer, bouton start désactivé
            Boutton_Stop.Visible = false;   //goose_observer dans la boucle infinie, impossible de rémarrer, bouton start désactivé
            ON_OFF_Label.Text = "OFF";
            ON_OFF_Label.ForeColor = Color.Red;
            /*Code pour kill un thread et afficher son statut (ne fonctionne pas car impossible en C#)
             
            myGoose_thread.Interrupt();
            myGoose_thread.Interrupt();
            if ((myGoose_thread.ThreadState & ThreadState.Running) == ThreadState.Running)
            {
                MessageBox.Show("Thread is still running", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
            timer_goose.Enabled = false;
        }
    }
}

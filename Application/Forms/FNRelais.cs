using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEC61850.Client;
using IEC61850.Common;

namespace IHM.Forms
{
    public partial class FNRelais : Form
    {
        private byte connexion_flag = 0;
        private bool connection_error;
        private bool flag_co=true;
        Chargement myForm;
        private Thread myGui_Connection;
        public FNRelais()
        {
            InitializeComponent();
            ListeDeroulante.Enabled = false;
        }

        public void RefreshListe()
        {
            ListeDeroulante.Items.Clear();
            FNRMarque.Text = "";
            FNRModele.Text = "";
            FNRIP.Text = "";
            FNRMAC.Text = "";
            FNRPort.Text = "";
            FNRUID.Text = "";
            ListeDeroulante.Text = "";
            for (int x = 0; x < Gestion.ListeRelais.Count(); x++)
            {
                ListeDeroulante.Items.Add(Gestion.ListeRelais[x].getNom());

            }
            if (ListeDeroulante.Items.Count > 0)
            {
                //ListeDeroulante.SelectedIndex = 0; correction bug connexion
                ListeDeroulante.Enabled = true;
                ETATIED.Text = "Waiting for Connection";
                ETATIED.ForeColor = Color.Black;
            }
            else
            {
                ListeDeroulante.Enabled = false;
            }
        }
        public void ListeDeroulante_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Gestion.ListeRelais.Count(); i++)
            {
                FNRMarque.Text = "";
                FNRModele.Text = "";
                FNRIP.Text = "";
                FNRMAC.Text = "";
                FNRPort.Text = "";
                FNRUID.Text = "";
                if (Gestion.ListeRelais[i].getNom() == ListeDeroulante.Text)
                {
                    FNRMarque.Text = Gestion.ListeRelais[i].getMarque();
                    FNRModele.Text = Gestion.ListeRelais[i].getModele();
                    FNRIP.Text = Gestion.ListeRelais[i].getIP();
                    FNRMAC.Text = Gestion.ListeRelais[i].getMAC();
                    FNRPort.Text = Gestion.ListeRelais[i].getModele();
                    FNRUID.Text = Gestion.ListeRelais[i].getUID().ToString();
                    myGui_Connection = new Thread(New_Thread_create);  //création nouveau thread
                    myGui_Connection.IsBackground = true;
                    myGui_Connection.Start();     //démarrage en tâche de fond

                    try
                    {
                        IedConnection con = new IedConnection();
                        var args = Environment.GetCommandLineArgs();
                        string hostname;

                        hostname = Gestion.ListeRelais[i].getIP();
                        int port = Gestion.ListeRelais[i].getPort();

                        if (args.Length > 1)
                            port = Int32.Parse(args[1]);

                        try
                        {
                            con.Connect(hostname, port);

                            List<string> serverDirectory = con.GetServerDirectory(false);

                            foreach (string entry in serverDirectory)
                            {
                                connexion_flag = 1;
                            }
                        }
                        catch (IedConnectionException f)
                        {
                            connexion_flag = 2;
                        }
                        // release all resources - do NOT use the object after this call!!
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        ETATIED.Text = "Unable to Connect";
                        ETATIED.ForeColor = Color.Red;
                        connection_error = true;
                        MessageBox.Show("Failed to connect, please check that both DLLs are in System32 Folder or that winpcap is running", "Internal Error",    
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connexion_flag = 0;
                    }

                    if(connexion_flag != 0)
                    {
                        while (flag_co) ;
                        if (connexion_flag == 1)
                        {
                            ETATIED.Text = "Connected!";
                            ETATIED.ForeColor = Color.Green;
                            MessageBox.Show("Connection to IED is Successfull!", "Connected!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (connexion_flag == 2)
                        {
                            ETATIED.Text = "Disconnected";
                            ETATIED.ForeColor = Color.Red;
                            MessageBox.Show("Unable to Connect to the IED", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } 
                }
            }
        }
        private void New_Thread_create() //creation nouveau thread
        {
            try
            {
                Launch_Progress_Bar();
            }
            catch (Exception ex)
            {

            }
        }

        void Launch_Progress_Bar()
        {
            Thread.Sleep(200);
            if (connection_error == false)
            {
                flag_co = true;
                myForm = new Chargement();
                myForm.Show();
                myForm.Location = new Point(750, 250);
                for (int i = 0; i < 100; i++)
                {
                    myForm.progressBar_statut.Value = i;
                    Thread.Sleep(90);
                    //myForm.label_statut.Text = i + " %";
                }
                flag_co = false;
                myForm.Hide();
            }
            else
            {
                connection_error = false;
            }
            
        }
    }
}
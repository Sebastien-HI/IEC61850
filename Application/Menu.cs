using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace IHM
{
    public partial class Menu : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public int compteur = 0;
        private Form activeForm;

        //Constructor
        public Menu()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildform.Visible = false;
            Text = string.Empty; //Remove the border of the form
            ControlBox = false;
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // We indicate the limits of the maximized (equal to the working area of the desk) 
        }

        //Function of drag the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        //Methods
        public Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index) // if the color has already been selected, we select again to choose a different one.
            {
               index = random.Next(ThemeColor.ColorList.Count);        
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        public void ActivateButton (object btnsender ) //Highlight the button that has been clicked(ActiveForm), Select the color of the theme, change the background, change the font colro ant the font size
        {
        if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color; //Save the current color
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3); //Save the current color
                    btnCloseChildform.Visible = true;
                }
            }


        }

        public void DisableButton() //Disable the Highlight button
        {
            foreach (Control previousBtn in panelMenu.Controls) //For each button in Menu
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76); //We came back to the previous color background ans foreground
                    previousBtn.ForeColor = Color.White; 
                    previousBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        //Evenements 

        public void bpIED_Click(object sender, EventArgs e)
        {
            ActivateButton(sender); // We highlight the button activate
            activeForm = Gestion.IEDforms; //activeForm take the value of childform
            Gestion.IEDforms.TopLevel = false;
            Gestion.IEDforms.FormBorderStyle = FormBorderStyle.None;
            Gestion.IEDforms.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(Gestion.IEDforms);
            panelDesktop.Tag = Gestion.IEDforms;
            Gestion.IEDforms.BringToFront();
            Gestion.IEDforms.Show();
            lbltitle.Text = "IED Manager";
        }

        public  void bpFNRelais_Click(object sender, EventArgs e)
        {
            ActivateButton(sender); // We highlight the button activate
            activeForm = Gestion.FNrelais; //activeForm take the value of childform
            Gestion.FNrelais.TopLevel = false;
            Gestion.FNrelais.FormBorderStyle = FormBorderStyle.None;
            Gestion.FNrelais.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(Gestion.FNrelais);
            panelDesktop.Tag = Gestion.FNrelais;
            Gestion.FNrelais.BringToFront();
            Gestion.FNrelais.Show();
            lbltitle.Text = "Relays monitoring";
            Gestion.FNrelais.RefreshListe();
        }

        public void bpFNgoose_Click(object sender, EventArgs e)
        {
            ActivateButton(sender); // We highlight the button activate
            activeForm = Gestion.FNGoose; //activeForm take the value of childform
            Gestion.FNGoose.TopLevel = false;
            Gestion.FNGoose.FormBorderStyle = FormBorderStyle.None;
            Gestion.FNGoose.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(Gestion.FNGoose);
            panelDesktop.Tag = Gestion.FNGoose;
            Gestion.FNGoose.BringToFront();
            Gestion.FNGoose.Show();
            lbltitle.Text = "Goose";

        }

        public void btnCloseChildform_Click(object sender, EventArgs e)
        {
            Reset();
            Gestion.FNGoose.Hide();
            Gestion.FNrelais.Hide();
            Gestion.IEDforms.Hide();
        }

        public void Reset()
        {
            DisableButton();
            lbltitle.Text = "Main Menu";
            panelTitleBar.BackColor = Color.FromArgb(51, 153, 255);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildform.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (Gestion.ListeRelais.Count > 0)
            {
                string execPath = AppDomain.CurrentDomain.BaseDirectory;
                string pathtxtwrite = execPath + "IEDsave.txt";
                // On supprime les données du précédent fichier
                System.IO.File.WriteAllText(pathtxtwrite, string.Empty);
                // Ecriture des relais dans un fichier TXT
                StreamWriter fichiertxt = new StreamWriter(pathtxtwrite); // path du fichier à mettre en variable global pour laisser le choix à l'utilisateur de l'emplacement                                                                
                //MessageBox.Show(Gestion.ListeRelais[0].getpath());
                // Ecriture des relais dans le fichier
                if (Gestion.ListeRelais.Count > 0)
                {
                    for (int i = 0; i < Gestion.ListeRelais.Count; i++)
                    {
                        fichiertxt.Write(Gestion.ListeRelais[i].getMarque().ToString() + "|");
                        fichiertxt.Write(Gestion.ListeRelais[i].getModele().ToString() + "|");
                        fichiertxt.Write(Gestion.ListeRelais[i].getNom().ToString() + "|");
                        fichiertxt.Write(Gestion.ListeRelais[i].getIP().ToString() + "|");
                        fichiertxt.Write(Gestion.ListeRelais[i].getMAC().ToString() + "|");
                        fichiertxt.Write(Gestion.ListeRelais[i].getPort().ToString() + "|");
                        fichiertxt.Write(Gestion.ListeRelais[i].getUID().ToString() + "|");
                        fichiertxt.Write(Gestion.ListeRelais[i].getIMG() + "|");
                        fichiertxt.Write(Gestion.ListeRelais[i].getpath().ToString());
                        fichiertxt.Write("~");
                    }
                }
                fichiertxt.Close();
            }


            //Fermeture des objets et de l'application
            for (int i = Gestion.ListeRelais.Count() - 1; i > 0; i--)
            {
                Gestion.ListeRelais.RemoveAt(i);
            }
            Gestion.FNGoose.Close();
            Gestion.FNrelais.Close();
            Gestion.IEDforms.Close();
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Menu_SizeChanged(object sender, EventArgs e)
        {
            CenterControlInParent(panelDesktop);
        }
        private void CenterControlInParent(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 2;
        }
    }
}
namespace IHM
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());
        }

    }



    public static class Gestion
    {
        public static List<Relais> ListeRelais = new List<Relais>(); //Creer une liste permettant de stocker les relais
        public static Forms.IEDforms IEDforms = new Forms.IEDforms(); // Creer un object de type fenetre IED
        public static Forms.FNGoose FNGoose = new Forms.FNGoose(); //Creer un object de type fentre goose
        public static Forms.FNRelais FNrelais = new Forms.FNRelais(); //Creer un object de type fenetre relais
        public static Forms.Chargement chargement = new Forms.Chargement(); //Creer un object de type fenetre chargement
        public static byte flag_chargement = 0; //indique quand lancer le chargement
    }

}

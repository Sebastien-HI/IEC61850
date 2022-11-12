using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHM
{
    public class Relais
    {
        String Marque;
        String Modele;
        String Nom;
        String IP;
        String MAC;
        String path;
        int Port;
        int UID;
        Image IMG;


        public Relais(String _Marque, String _Modele, String _Nom, String _IP, String _MAC, int _Port, int _UID, Image _IMG, String _path)
        {
            Marque = _Marque;
            Modele = _Modele;
            Nom = _Nom;
            IP = _IP;
            MAC = _MAC;
            Port = _Port;
            UID = _UID;
            IMG = _IMG;
            path = _path;

        }

        public String getMarque()
        {
            return Marque;
        }

        public String getModele()
        {
            return Modele;
        }
        public String getNom()
        {
            return Nom;
        }

        public String getIP()
        {
            return IP;
        }

        public String getMAC()
        {
            return MAC;
        }

        public int getPort()
        {
            return Port;
        }

        public int getUID()
        {
            return UID;
        }

        public Image getIMG()
        {
            return IMG;
        }

        public String getpath()
        {
            return path;
        }
    }
}

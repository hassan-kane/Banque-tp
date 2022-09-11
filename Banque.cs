using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    internal class Banque
    {

        public Banque()
        {
            mesComptes = new List<Compte>();
        }

        

        private List<Compte> mesComptes;

        public List<Compte> MesComptes
        {
            get { return mesComptes; }
            set { mesComptes = value; }
        }


        public Compte compte { get; private set; }

        public void ajouterCompte(int numero, string nom, double solde, double decouvert)
        {
            compte = new Compte(numero, nom, solde, decouvert);
            mesComptes.Add(compte);

        }

        public void ajouterCompte(Compte compte)
        {
            mesComptes.Add(compte);
        }

        public override string ToString()
        {
            string lesComptes = "";

            foreach(Compte compte in mesComptes)
            {
                lesComptes += compte;
            }
            return $"{lesComptes} ";
        }
    }
}

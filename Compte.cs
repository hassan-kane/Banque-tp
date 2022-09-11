using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Compte
{
    internal class Compte
    {
        private int numero;
        private string nom;
        private double solde;
        private double decouvert;

        public Compte(int numero, string nom, double solde, double decouvert)
        {
            this.numero = numero;
            this.nom = nom;
            this.solde = solde;
            this.decouvert = decouvert;
        }

        public Compte()
        {
            this.numero = 0;
            this.nom = null;
            this.solde = 0;
            this.decouvert = 0;
        }

        public int getNumero()
        {
            return numero;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public string getNom()
        {
            return nom;
        }
        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public double getSolde()
        {
            return solde;
        }
        public void setSolde(double solde)
        {
            this.solde = solde;
        }

        public double getDecouvert()
        {
            return decouvert;
        }
        public void setDecouvert(double decouvert)
        {
            this.decouvert = decouvert;
        }

        public void crediter(double montant)
        {
            this.solde += montant;
            Console.WriteLine("Votre compte à été crédité de: " + montant + " €");
        }

        public bool debiter(double montant)
        {
            /*double soldeDecouvertAutorise = System.Math.Abs(this.decouvert);*/
            if (this.solde - montant >= this.decouvert)
            {
                this.solde -= montant;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void transferer(double montant, Compte compteEnvoie)
        {
            if(this.debiter(montant) == true)
            {
                this.debiter(montant);
                compteEnvoie.crediter(montant);
            }
        }

        public bool superieur(Compte compte)
        {
            if(this.solde < compte.solde)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool inferieur(Compte compte)
        {
            if (this.solde > compte.solde)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return
                    $" \n Numéro:  {getNumero()} \n Nom:  { getNom()} \n Solde: {getSolde()} € \n Decouvert: {getDecouvert()} € \n";
        }
    }
}

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

        public int getNumero()
        {
            return numero;
        }
        public int setNumero()
        {
            return this.numero;
        }

        public string getNom()
        {
            return nom;
        }
        public string setNom()
        {
            return this.nom;
        }

        public double getSolde()
        {
            return solde;
        }
        public double setSolde()
        {
            return this.solde;
        }

        public double getDecouvert()
        {
            return decouvert;
        }
        public double setDecouvert()
        {
            return this.decouvert;
        }

        public override string ToString()
        {
            return
                    $" \n Numéro:  {getNumero()} \n Nom:  { getNom()} \n Solde: {getSolde()} \n Decouvert: {getDecouvert()}";
        }

        public bool crediter(double montant)
        {

            if(true)
            {
                this.solde = this.solde + montant;
                return true;
            }
            else
            {
                Console.WriteLine("Opération impossible: Votre compte n'est pas créditable"); 
                return false;
            }
        }

        public bool debiter(double montant)
        {
            if (this.solde >= montant || this.solde >= this.decouvert)
            {
                this.solde = this.solde - montant;
                return true ;
            }
            else
            {
                Console.WriteLine("Opération impossible: Votre compte n'est pas débitable");
                return false;
            }
        }

        public void transferer(double montant, Compte compteReception)
        {
            

            if (this.debiter(montant))
            {
                compteReception.crediter(montant);
            }
            else
            {
                Console.WriteLine("Opération impossible");
            }

        }
    }
}

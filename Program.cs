using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Compte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*//Test instanciation reussi
            Compte compte = new Compte(1, "compte", 0, 0);
            Compte compte2 = new Compte(2, "compte2", 5, 0);

            //Test créditaion reussi
            bool credit = compte.crediter(55);
           *//* Console.WriteLine("Votre compte à été créditer de: " + credit + " €");*//*
            Console.WriteLine("Après créditaion votre solde est de: " + compte.getSolde() + " €" + " compte");

            Console.WriteLine();

            //Test débitation reussi
            bool debit = compte.debiter(25);
           *//* Console.WriteLine("Votre compte à été débiter de: " + debit + " €");*//*
            Console.WriteLine("Après débitation solde est de: " + compte.getSolde() + " €" + " compte");

            Console.WriteLine();

            //Test transfert reussi
            compte.transferer(30, compte2);
            Console.WriteLine("Après créditation solde est de: " + compte2.getSolde() + " €" + " compte2");*/

            /*//Test global 1 ressui
            Compte c1, c2;
            c1 = new Compte(12345, "toto", 1000, -500);
            c2 = new Compte(45657, "titi", 2000, -1000);
            c1.transferer(3300, c2);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());*/

            /*//Test global 2 reussi
            Compte c1;
            c1 = new Compte(12345, "toto", 1000, -500);
            c1.crediter(2000);
            c1.debiter(1300);
            Console.WriteLine(c1.ToString());*/

            /*//Test global 3 reussi
            Compte c1;
            c1 = new Compte(12345, "toto", 1000, -500);
            c1.crediter(2000);
            c1.debiter(3501);
            Console.WriteLine(c1.ToString());*/

            /* //Test global 4 reussi
             Compte c1, c2;
             c1 = new Compte(12345, "toto", 1000, -500);
             c2 = new Compte(45657, "titi", 2000, -1000);
             c1.transferer(1600, c2);
             Console.WriteLine(c1.ToString());
             Console.WriteLine(c2.ToString());*/

            /* //Test global 5 reussi
             Compte c1, c2;
             c1 = new Compte(12345, "toto", 1000, -500);
             c2 = new Compte(45657, "titi", 2000, -1000);
             c1.transferer(3300, c2);
             Console.WriteLine(c1.ToString());
             Console.WriteLine(c2.ToString());*/

            /*//Test superieur & inferieur reussi
            Compte c1, c2;
            c1 = new Compte(12345, "toto", 1000, -500);
            c2 = new Compte(45657, "titi", 2000, -1000);
            if (c1.inferieur(c2))
                Console.WriteLine("superieur");
            else
                Console.WriteLine("inférieur");*/

            /*Banque b = new Banque();
            Compte c1;
            Compte c2;
            c1 = new Compte(12345, "toto", 1000, -500);
            b.ajouterCompte(c1);
            b.ajouterCompte(45657, "titi", 2000, -1000);
            b.ajouterCompte(12654, "tintin", 5000, -500);
            Console.WriteLine(b.ToString());*/


            Console.ReadKey();
        }
    }
}

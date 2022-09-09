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

            //Test transfert
            compte.transferer(30, compte2);
            Console.WriteLine("Après créditation solde est de: " + compte2.getSolde() + " €" + " compte2");*/

            Compte c1, c2;
            c1 = new Compte(12345, "toto", 1500, -500);
            c2 = new Compte(45657, "titi", 2000, -1000);
            c1.transferer(1300, c2);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());



            Console.ReadKey();
        }
    }
}

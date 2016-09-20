using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TestMail
{
    class Program
    {
        static void Main(string[] args)
        {
            int restart = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("Entrez une adresse mail : ");
                string entry = Console.ReadLine();
                string erreur = CtrlMail(entry);

                Console.WriteLine(erreur);
                Console.ReadLine();
            } while (restart != 0);



        }
        /// <summary>
        /// Fonction de vérification de l'adresse mail
        /// </summary>
        /// <param name="mail">Chaine contenant l'adresse à vérifier</param>
        /// <returns>Renvoie une chaine vide si l'adresse est bonne, ou le morceau erronné</returns>
        static string CtrlMail(string mail)
        {
            string erreur = "";
            Regex test = new Regex( @"^[a-z0-9][a-z0-9_.-]{1,50}[@][a-z0-9][a-z0-9]{1,50}[.][a-z]{2,10}$");
            Regex test1 = new Regex(@"^[a-z0-9][a-z0-9_.-]{1,50}$");
            Regex test2 = new Regex(@"^@[a-z0-9][a-z0-9]{1,50}$");
            Regex test3 = new Regex(@"^.[a-z]{2,10}$");
            int posAt = 0, posPoint = 0;
            if (test.IsMatch(mail))
            {
                return erreur = "L'adresse est valide !";
            }
            else
            {
                if (mail.IndexOf("@") != -1)
                {
                    posAt = mail.IndexOf("@");//renvoie la position du 1er arobase
                    if (mail.IndexOf(".", posAt) != -1 && mail.IndexOf(".", posAt) > posAt)
                    {
                        posPoint = mail.IndexOf(".", posAt);
                    }
                    else
                    {
                        return "Il faut un point après le arobase";
                    }                   
                }
                else
                {
                    return erreur = "Il faut au moins un arobase.";
                }

                Console.WriteLine(posAt);
                Console.WriteLine(posPoint);
                Console.WriteLine(mail.Length);

                erreur += "Unne erreur se trouve dans : ";
                if (!test1.IsMatch(mail.Substring(0, posAt)))
                {
                    Console.WriteLine("Erreur 1");
                    Console.WriteLine(mail.Substring(0, posAt));
                    erreur += mail.Substring(0, posAt);
                }
                else if (!test2.IsMatch(mail.Substring(posAt, posPoint-posAt)))
                {
                    Console.WriteLine("Erreur 2");
                    Console.WriteLine(mail.Substring(posAt, posPoint - posAt));
                    erreur += mail.Substring(posAt, posPoint - posAt);
                }
                else if (!test3.IsMatch(mail.Substring(posPoint, mail.Length-posPoint)))
                {
                    Console.WriteLine("Erreur 3");
                    erreur += mail.Substring(posPoint, mail.Length - posPoint);
                }
                return erreur;
            }
        }
    }
}

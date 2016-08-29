using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string mail;
            Console.Write("Entrez une adresse E-mail : ");
            mail = Console.ReadLine();

            Console.WriteLine("Scan du mail : " + CheckMail(mail));
            Console.ReadLine();

        }

        static string CheckMail(string mail)
        {
            int posAt = -1;
            int posPoint = -1;
            string error = "";
            string[] tb_mail = new string[mail.Length];
            if (Regex.IsMatch(mail, @"^[a-zA-Z0-9][a-zA-Z0-9.-_]{1,30}[@][a-z]{2,15}[.][a-z]{2,5}$"))
            {
                return "OK";
            }
            else
            {
                for (int i = 0; i < mail.Length; i++)
                {
                    tb_mail[i] = mail.Substring(i, 1);
                    if (tb_mail[i] == "@")
                    {
                        posAt = i;
                    }
                    if (posAt > 2 && tb_mail[i] == ".")
                    {
                        posPoint = i;
                    }
                }
                
                for (int i = 0; i < posAt; i++)
                {
                    if (!Regex.IsMatch(tb_mail[i], @"[a-zA-Z0-9.-_]"))
                    {
                        error = mail.Substring(i, 1);
                    }
                }
                if (posAt > 2)
                {
                   

                    for (int i = posAt + 1; i < posPoint; i++)
                    {
                        if (!Regex.IsMatch(tb_mail[i], @"[a-zA-Z]"))
                        {
                            error = mail.Substring(i, 1);
                        }
                    }
                }
                else
                {
                   error = "un @ doit etre présent.";
                   
                }

                if (posPoint > 5)
                {
                    for (int i = posPoint; i < mail.Length; i++)
                    {
                        error = mail.Substring(i, 1);
                    }
                }
                
                return "Erreur : " + error;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Classes
{
    public class ClientDao
    {
        SqlConnection connect;

        public ClientDao (string phrase)
        {
            connect = new SqlConnection(phrase);
        }

        public string CheckMail(string mail)
        {
            int posAt = -1;
            int posPoint = -1;
            string error = "";
            string[] tb_mail = new string[mail.Length];
            if (Regex.IsMatch(mail, @"^[a-zA-Z0-9][a-zA-Z0-9.-_]{1,30}[@][a-z]{2,15}[.][a-z]{2,5}$"))
            {
                return "";
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

                for (int i = posAt+1; i < posPoint; i++)
                {
                    if (!Regex.IsMatch(tb_mail[i], @"[a-zA-Z]"))
                    {
                        error = mail.Substring(i, 1);
                    }
                }

                for (int i = posPoint; i < mail.Length; i++)
                {
                    error = mail.Substring(i, 1);
                }
                
                return error;
            }
        }
    }
}

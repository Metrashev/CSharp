using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string egn;
            long egn1;
            Console.WriteLine("Molq, napishete vasheto EGN:");
            egn = Console.ReadLine();
            while (egn.Length != 10 || !long.TryParse(egn, out egn1))
            {
                Console.WriteLine("Dopusnata e greshka. Molq, napishete vasheto EGN nanovo:");
                egn = Console.ReadLine();
            }
            string god = egn.Substring(0, 2);
            string mes = egn.Substring(2, 2);
            string den = egn.Substring(4, 2);
            int sex = int.Parse(egn.Substring(8, 1));
            string pol;
            if (sex % 2 == 0)
            {
                pol = "myj";
            }
            else
            {
                pol = "jena";
            }
            string s = den + "/" + mes + "/19" + god;
            string s1 = den + "/" + mes + "/2014";
            string s2 = den + "/" + mes + "/2015";
            int result = DateTime.Compare(DateTime.Now, DateTime.Parse(s1));
            string a;
            if (result < 0) 
                a = DateTime.Parse(s1).Subtract(DateTime.Now).Days.ToString();
            else if (result == 0) a = "0";
            else a = DateTime.Parse(s2).Subtract(DateTime.Now).Days.ToString();
            TimeSpan age = DateTime.Now.Subtract(DateTime.Parse(s));
            string age1 = age.Days.ToString();
            int age2 = int.Parse(age1);
            age2 = age2 / 365;
            Console.WriteLine("Vie ste {0} na {1} godini, roden(a) na {2}/{3}/19{4}. Ostavat {5} dni to rojdenniq Vi den.", pol, age2, den, mes, god, a);
            Console.ReadLine();
        }
    }
}
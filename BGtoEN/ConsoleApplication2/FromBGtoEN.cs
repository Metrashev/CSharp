using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAsWords
{
    class NumbersAsWords
    {
        static string FromBGtoEN(String str)
        {
            switch (str)
            {
                case "А":
                    Console.Write("A");
                    break;
                case "Б":
                    Console.Write("B");
                    break;
                case "В":
                    Console.Write("V");
                    break;
                case "Г":
                    Console.Write("G");
                    break;
                case "Д":
                    Console.Write("D");
                    break;
                case "Е":
                    Console.Write("E");
                    break;
                case "Ж":
                    Console.Write("ZH");
                    break;
                case "З":
                    Console.Write("Z");
                    break;
                case "И":
                    Console.Write("I");
                    break;
                case "Й":
                    Console.Write("Y");
                    break;
                case "К":
                    Console.Write("K");
                    break;
                case "Л":
                    Console.Write("L");
                    break;
                case "М":
                    Console.Write("M");
                    break;
                case "Н":
                    Console.Write("N");
                    break;
                case "О":
                    Console.Write("O");
                    break;
                case "П":
                    Console.Write("P");
                    break;
                case "Р":
                    Console.Write("R");
                    break;
                case "С":
                    Console.Write("S");
                    break;
                case "Т":
                    Console.Write("T");
                    break;
                case "У":
                    Console.Write("U");
                    break;
                case "Ф":
                    Console.Write("F");
                    break;
                case "Х":
                    Console.Write("H");
                    break;
                case "Ц":
                    Console.Write("TS");
                    break;
                case "Ч":
                    Console.Write("CH");
                    break;
                case "Ш":
                    Console.Write("SH");
                    break;
                case "Щ":
                    Console.Write("SHT");
                    break;
                case "Ъ":
                    Console.Write("A");
                    break;
                case "ь":
                    Console.Write("Y");
                    break;
                case "Ю":
                    Console.Write("YU");
                    break;
                case "Я":
                    Console.Write("YA");
                    break;
            }
        }


        static void Main()
        {
            Console.WriteLine("Enter word from BG to EN: ");
            string text = Console.ReadLine();
            Console.WriteLine(FromBGtoEN(text));

        }
    }
}

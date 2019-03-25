using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = 211;
            Console.BufferHeight = 78;
            Console.SetWindowSize(60,20);
            //Console.SetWindowPosition(0, 0);
            Console.SetCursorPosition(28,76);

            string path = "C:\\Users\\rcmd\\source\\repos\\projetfilrouge\\map.txt";
            string line;

            StreamReader stream = new StreamReader(path);
            while ((line = stream.ReadLine()) != null)
            {
                foreach (char caractere in line)
                {
                    if (caractere == 'Y')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (caractere == 'o')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    else if (caractere == '_')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (caractere == '-')
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (caractere == '|')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (caractere == '/')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (caractere == '\\')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (caractere == '=')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (caractere == '@')
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (caractere == '!')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (caractere == ' ')
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.Write(caractere);
                }
                Console.WriteLine();
            }
        }
    }
}

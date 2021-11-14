using System;

namespace KATA1
{

    public class Printer
    {
        public static string PrinterError(String a)
        {
            //procedimientro para encontrar letras dentro de una palabra
            int y = 0;
            string z;
            int cont = 0;
            while (y < a.Length)
            {
                if (a.Substring(y, 1) == "n" || a.Substring(y, 1) == "o" || a.Substring(y, 1) == "p" || a.Substring(y, 1) == "q" || a.Substring(y, 1) == "r" || a.Substring(y, 1) == "s" || a.Substring(y, 1) == "t" || a.Substring(y, 1) == "u" || a.Substring(y, 1) == "v" || a.Substring(y, 1) == "w" || a.Substring(y, 1) == "x" || a.Substring(y, 1) == "y" || a.Substring(y, 1) == "z")
                {
                    cont++;
                }
                y++;
            }
            z = (cont+ "/" + a.Length);
            return z;
        }

        static void Main(string[] args)
        {
            string a = "";
            Console.WriteLine("Buscador de letras (n,o,p,q,r,s,t,u,v,w,x,y,z)");
            Console.WriteLine("Digite la palabra:");
            a = Console.ReadLine();
            Console.WriteLine("la longuitud es de:" + PrinterError(a)+" es el numero de letras encontradas que hay en la palabra");
        }
    }
}
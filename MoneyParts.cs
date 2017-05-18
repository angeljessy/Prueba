using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Moneda_2
{
    class MoneyParts
    {
        static decimal[] valores = new decimal[] { 0.05m, 0.1m, 0.2m, 0.5m, 1, 2, 5, 10, 20, 50, 100, 200 };

        static void Main(string[] args)
        {
            decimal num;

            num = Convert.ToDecimal(Console.Read());
            Build(num);

            Console.ReadLine();
        }

        public static string Build(decimal n)
        {
            decimal suma = 0;
            string cadena = "";
            decimal[] menores = valores.Where(x => x <= n).ToArray();
            foreach (decimal item in menores)
            {
                if (esDivisor(n, item))
                {
                    Console.WriteLine(repetirValor(item.ToString(), int.Parse((n / item).ToString())));
                }
                else
                {
                    suma = 0;
                    cadena = "";
                    while (suma < n)
                    {
                        cadena += item.ToString() + "|";
                        suma += item;
                        convinarValores(n, suma, item, menores, cadena);
                    }
                }
            }
            return "";
        }

        public static void convinarValores(decimal val, decimal valAct, decimal n, decimal[] valores, string cadena)
        {
            decimal suma = valAct;
            string cadenaAux = "";
            string cadenaAux2 = "";
            decimal r = 0;
            bool exite = false;
            while (suma < val)
            {
                suma += n;
                cadenaAux += n.ToString() + "|";
                foreach (decimal item in valores)
                {
                    cadenaAux2 += item.ToString() + "|";
                    if (suma + item == val)
                    {
                        r = suma + item;
                        exite = true;
                        break;
                    }
                    else if (suma + item > val)
                    {
                        break;
                    }
                    else
                    {
                        //exite = false;
                        cadenaAux2 = "";
                        convinarValores(val, suma, item, valores, cadena + cadenaAux);
                    }
                }
                if (exite)
                {
                    Console.WriteLine(cadena + "**" + cadenaAux + "**" + cadenaAux2 + "-->" + r + "-->");
                }
                exite = false;
                cadenaAux2 = "";
                cadenaAux = "";
            }
        }

        public static bool esDivisor(decimal n, decimal divisor)
        {
            return n % divisor == 0;
        }

        public static string repetirValor(string valor, int nro)
        {
            string retval = "";
            for (int i = 1; i <= nro; i++)
            {
                retval += valor + "|";
            }
            return retval + "-->";
        }

    }
}

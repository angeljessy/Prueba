using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba_numeros
{
    class CompleteRange
    {

        public string Build(string cad)
        {
            string[] num;
            string resp = "", aux;
            int i, j, a;

            num = cad.Split(',');

            // Ordenamos mediante el método de la burbuja
            for(i=0;i<num.Length-1;i++)
            {
                for(j=0;j<num.Length-i-1;j++)
                {

                    if (num[j+1].CompareTo(num[j]) <= 0)
                    {
                        aux=num[j+1];
                        num[j+1]=num[j];
                        num[j]=aux; 
                    }
                }
            }

            // Agregamos solo los números faltantes
            a = 0;
            for (i = 1; i <= Convert.ToInt16(num[num.Length - 1]); i++)
            {
                // Números que ya existen
                if (i == Convert.ToInt32(num[a]))
                {
                    if (i == 1)
                        resp = num[a];
                    else
                        resp = resp + "," + num[a];

                    a++;
                }
                else
                {
                    // nuevos números
                    if (i == 1)
                        resp = Convert.ToString(i);
                    else
                        resp = resp + "," + i;
                }
            }                                

            return resp;

        }

    }
}

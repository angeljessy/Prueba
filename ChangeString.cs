using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba_Cadena
{
    class ChangeString
    {
        // Asignamos un vector de letras.
        string[] letra = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "w", "x", "y", "z" };

        public string Build(string cad)
        {
            int i, j;
            string t;

            for (i = 0; i < cad.Length; i++)
            {
                t = cad.Substring(i, 1);

                for (j = 0; j < letra.Length; j++)
                {
                    // Si es la última letra, ya no cambia
                    if (j < letra.Length - 1)
                    {
                        // Compara minúsculas; quita en la posición y agrega del vector de letras.
                        if (t == letra[j])
                        {
                            cad = cad.Remove(i, 1);
                            cad = cad.Insert(i, letra[j + 1]);
                        }
                        else
                        {
                            // Compara mayúsculas; quita en la posición y agrega del vector de letras pero en mayúscula. 
                            if (t == (letra[j]).ToUpper())
                            {
                                cad = cad.Remove(i, 1);
                                cad = cad.Insert(i, (letra[j + 1]).ToUpper());
                            }
                        }
                    }
                }
            }

            return cad;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFinalVS.Metodos
{
    class Binario
    {
        public static string Convertor(int numero) // CONVIERTE CUALQUIER NUMERO A BINARIO
        {
            int tam;
            List<string> numeros = new List<string>();
            string resultado;

            if (numero != 0) // si el numero no es 0
            {
                if (numero > 0) // si el numero es positivo
                {
                    while (numero / 2 != 0)
                    {
                        numeros.Add((numero % 2).ToString());
                        numero /= 2;
                    }
                    if (numero / 2 == 0)
                    {
                        numeros.Add(1.ToString());
                    }
                    if (numeros.Count == 1)
                    {
                        numeros.Add(0.ToString());
                        numeros.Add(0.ToString());
                    }
                    if (numeros.Count == 2)
                    {
                        numeros.Add(0.ToString());
                    }
                    numeros.Add(0.ToString());
                    numeros.Reverse();
                    resultado = string.Join("", numeros); // convierte la lista de numeros a un string unico
                    return resultado;
                }
                else if (numero < 0) // si el numero es negativo
                {
                    numero *= -1;
                    tam = (int)(Math.Log(numero, 2)) + 2; // FORMULA VISTA EN CLASE SOBRE COMPLEMENTO A 2
                    numero = (int)(Math.Pow(2, tam) - numero);
                    while (numero / 2 != 0)
                    {
                        numeros.Add((numero % 2).ToString());
                        numero /= 2;
                    }
                    if (numero / 2 == 0)
                    {
                        numeros.Add(1.ToString());
                    }
                    if (numeros.Count == 2)
                    {
                        numeros.Add(1.ToString());
                        numeros.Add(1.ToString());
                    }
                    if (numeros.Count == 3)
                    {
                        numeros.Add(1.ToString());
                    }
                    numeros.Reverse();
                    resultado = string.Join("", numeros);
                    return resultado;
                }
            }
            else // si el numero es 0
            {
                numeros.Add(0.ToString());
                numeros.Add(0.ToString());
                numeros.Add(0.ToString());
                numeros.Add(0.ToString());
                resultado = string.Join("", numeros);
                return resultado;
            }
            return "error";
        }

    }
    }


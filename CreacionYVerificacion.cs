using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDI_Tarea_5_Formulario
{
    /// <summary>
    /// clase donde implementamos los metodos que calculan tamaño de vectores, rellenan vectores,
    /// y verifican que el selector del switch contenido en el main del programa está entre los valores acepatados para ello
    /// </summary>
    internal class CreacionYVerificacion
    {
        static int cantidadNumeros = 0;
        static int cantidadLetras = 0;
        static int cantidadCaracteresEspeciales = 0;

        //metodo que analiza el priemer caracter de cada string del vector introducido por el usuario, y cuenta cuantos 
        //hay e cada uno de los 3 tipos en que subdividimos el vector proncipal
        internal static void tamanoSubVectores(string[] vector)
        {
            foreach (String s in vector)
            {
                if (s.Length > 0)
                {

                    if ("0123456789".Contains(s[0]))//en caso que sea un valor nuemrico
                    {
                        CantidadNumeros++;
                    }
                    else if ("qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM".Contains(s[0]))//en caso que sea una letra
                    {
                        CantidadLetras++;
                    }
                    else//si el primer caracter no es numero ni letra, se considera caracter especial
                    {
                        CantidadCaracteresEspeciales++;
                    }
                }
            }
        }

        //metodo para rellenar los subvectores a partir de los datos del vector inicial
        internal static void rellenarSubVectores(string[] vectorRecogido, string[] vectorNumeros,
            string[] vectorLetras, string[] vectorCaracteresEspeciales)
        {
            //variables que guardan la posicion del vector correspondiente donde se operará en cada iteracion
            int posicionNumero = 0;
            int posicionLetra = 0;
            int posicionCaracterEspecial = 0;

            foreach (String s in vectorRecogido)
            {
                if (s.Length > 0)//mientras el string que se recoja no esté vacio
                {
                    //si el primer caracter del string S es un numero, letra o caracter especial, se guardará el string S
                    //en el subvector que le corresponda y se aumentará una posicion del array para la siguiente iteracion
                    if ("0123456789".Contains((char)s[0]))
                    {
                        vectorNumeros[posicionNumero] = s;
                        posicionNumero++;
                    }
                    else if ("qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM".Contains((char)s[0]))
                    {
                        vectorLetras[posicionLetra] = s;
                        posicionLetra++;
                    }
                    else
                    {
                        vectorCaracteresEspeciales[posicionCaracterEspecial] = s;
                        posicionCaracterEspecial++;
                    }
                }
            }
        }

        //metodo que verifica que el valor introducido para el switch del main estra dentro de las opciones ofrecidas al usuario
        internal static int verificarSelector(string strSelectorOrden)
        {

            int SelectorOrden;
            bool entradaValida = false;

            while (!entradaValida)//mientras el valor introducido no se corrersponda con alguno del switch
            {
                if (!int.TryParse(strSelectorOrden, out SelectorOrden))//caso que el valor introducido no sea un numero
                {
                    Accesorios.ImprimirLineColorTexto("No ha introducido un numero valido....de hecho, ni tan siquiera un numero ¬¬\n" +
                        "Prueba otra vez...",ConsoleColor.Red);
                    strSelectorOrden = Console.ReadLine();

                }
                if (SelectorOrden > 0 && SelectorOrden < 8)//caso que sea un numero entre 1 y 7, se devuelve el valor introducido como opcion de switch
                {
                    entradaValida = true;
                    return SelectorOrden;
                }
                else//caso que se introduzca un numero fuuera del rango del switch
                {
                    Accesorios.ImprimirLineColorTexto("No ha introducido un numero valido\n",ConsoleColor.Red);
                    strSelectorOrden = Console.ReadLine();

                }
            }
            return -1;

        }

        public static int CantidadLetras { get => cantidadLetras; set => cantidadLetras = value; }
        public static int CantidadCaracteresEspeciales { get => cantidadCaracteresEspeciales; set => cantidadCaracteresEspeciales = value; }
        public static int CantidadNumeros { get => cantidadNumeros; set => cantidadNumeros = value; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDI_Tarea_5_Formulario
{
    /// <summary>
    /// clase que contiene el metodo recursivo de ordenacion de vectores. Es una implementacion del algoritmo Bubble SOrt
    /// ampliamente utilizado para este tipo de casos
    /// </summary>
    public class Ordenacion
    {
        internal static void ordenacionVector(string[] vector, int n)
        {
            //se indica primero el caso de salida del bucle recursivo, para asegurarse que no se vuelva un bucle infinito.
            //utilizamos una variable n, que al llamar al metodo comtendrá el tamaño del vector
            if (n <= 1)
            {
                return;
            }
            for (int i = 0; i < n - 1; i++)//arrancamos un bucle for standard
            {
                //definimos que pasa si, segun el criterio de ordenacion del metodo CompareTo, el valor de ordenacion de un string A
                //es mayor (detras en la secuencia de ordeancion) al del string B en la posicion siguiente en el vector.
                //En afirmativo, intercambiaremos las posiciones de ambos strings, "arrastrando" hacia atras el primero.
                //Para ello, definimos una variable temporal contenedor para almacenar el valor del string A,
                //copiamos el valor del string B en la posicion donde alacenabamos el A, e introducimos el valor guardado en el contenedor,
                //es decir, el valor del string A, en la posicion que ocupaba incialmente el string B.
                if (vector[i].CompareTo(vector[i + 1]) > 0)
                {
                    string contenedor = vector[i];
                    vector[i] = vector[i + 1];
                    vector[i + 1] = contenedor;
                }
            }
            //cuando terminamos de recorrer todo el array, el string con el valor de ordeancion mayor acabará en la ultima posicion. 
            //a continuacion repetimos el metodo, pero reduciendo en una posicion el alcance del bucle for, por lo que no va a llegar
            //a iterar sobre el string colocado en la ultima posicion sobre la que actuó en la iteracion anterior. Se repetirá hasta que
            //se cumpla la condicion If de que ya solo iteraria sobre un unico elemento del vector
            ordenacionVector(vector, n - 1);
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDI_Tarea_5_Formulario
{
    /// <summary>
    /// clase auxiliar que creé para formatear la salida de texto por ocnsola, permitiendo definir cada  salida de forma individual
    /// y regresar automaticamente al formato estandard para la siguiente linea. Creé metodos para los distintos casos de querer modificar
    /// el color del texto o del fondo o ambos a la vez, tanto saltando para el metodo WriteLine como para el Write.
    /// Lo que hacen los metodos es:
    /// 
    /// 1. guardar los atributos por defecto en una variable de tipo ConnsoleColor.
    /// 2. Definir los parametros que queremos aplicar a esa entrada en cuestion
    /// 3. Pintar el texto por pantalla
    /// 4. Restaurar valores por defecto
    /// </summary>
    public static class Accesorios
    {
        public static void ImprimirLineColorTextoYFondo(string texto, ConsoleColor colorTexto, ConsoleColor colorFondo)
        {
            ConsoleColor colorTextoOriginal = Console.ForegroundColor;
            ConsoleColor colorFondoOriginal = Console.BackgroundColor;
            Console.ForegroundColor = colorTexto;
            Console.BackgroundColor = colorFondo;
            Console.WriteLine(texto);
            Console.ForegroundColor = colorTextoOriginal;
            Console.BackgroundColor = colorFondoOriginal;
        }
        public static void ImprimirLineColorTexto(string texto, ConsoleColor colorTexto)
        {
            ConsoleColor colorTextoOriginal = Console.ForegroundColor;
            Console.ForegroundColor = colorTexto;
            Console.WriteLine(texto);
            Console.ForegroundColor = colorTextoOriginal;
        }
        public static void ImprimirLineColorFondo(string texto, ConsoleColor colorFondo)
        {
            ConsoleColor colorFondoOriginal = Console.BackgroundColor;
            Console.BackgroundColor = colorFondo;
            Console.WriteLine(texto);
            Console.BackgroundColor = colorFondoOriginal;
        }
        public static void ImprimirColorTextoYFondo(string texto, ConsoleColor colorTexto, ConsoleColor colorFondo)
        {
            ConsoleColor colorTextoOriginal = Console.ForegroundColor;
            ConsoleColor colorFondoOriginal = Console.BackgroundColor;
            Console.ForegroundColor = colorTexto;
            Console.BackgroundColor = colorFondo;
            Console.Write(texto);
            Console.ForegroundColor = colorTextoOriginal;
            Console.BackgroundColor = colorFondoOriginal;
        }
        public static void ImprimirColorTexto(string texto, ConsoleColor colorTexto)
        {
            ConsoleColor colorTextoOriginal = Console.ForegroundColor;
            Console.ForegroundColor = colorTexto;
            Console.Write(texto);
            Console.ForegroundColor = colorTextoOriginal;
        }
        public static void ImprimirColorFondo(string texto, ConsoleColor colorFondo)
        {
            ConsoleColor colorFondoOriginal = Console.BackgroundColor;
            Console.BackgroundColor = colorFondo;
            Console.Write(texto);
            Console.BackgroundColor = colorFondoOriginal;
        }
    }

}

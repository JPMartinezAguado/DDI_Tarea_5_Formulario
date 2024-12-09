using System.Numerics;
using System.Text;

namespace DDI_Tarea_5_Formulario
{
    public partial class Form1 : Form
    {
        #region Campos
        /// <summary>
        /// variables de clase accesibles por todos los metodos de la misma
        /// </summary>
        static string datoRecogido;//recoge cada item del vector introducido por el usuario

        //vectores recogidos divididos por tipo y ordenados segun criterios de ordenacion
        static string[] vectorRecogido;
        static string[] vectorNumeros;
        static string[] vectorLetras;
        static string[] vectorCaracteresEspeciales;
        string[] OrdenadoEspNumLet;
        string[] OrdenadoEspLetNum;
        string[] OrdenadoNumLetEsp;
        string[] OrdenadoNumEspLet;
        string[] OrdenadoLetEspNum;
        string[] OrdenadoLetNumEsp;
        
        //strings que recogen valoresde seleccion del combobox
        string SelectedItem;
        string SelectedItem2;
        string NoSelectedItem;

        //guarda la cadena de secuencia de orden seleccionada
        string strOrdenComboBox;
        #endregion

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1500;//duracion del timer que se usa para mostrar el mensaje de elemento incluido
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Sistema de ordenacion de vectores\n\n");
            txtTextBox1.Focus();
        }

        #region Eventos Botones de Acciones
        //acciones que se realizan al agregar un elemnto al array
        private void agregar_Click(object sender, EventArgs e)
        {
            //se recoge el dato junto a un caracter especial que dificilmente vaya a ser 
            //introducido por el usuario que sirva de splitter
            datoRecogido += txtTextBox1.Text + "Љ";
            txtTextBox1.Clear();
            MostrarLabelInsertado();
            btnMostrarVector.Enabled = true;
        }

        /// <summary>
        /// evento de click del boton mostrar vector
        /// </summary>
        private void mostrarVector_Click(object sender, EventArgs e)
        {
            //anulamos los elementos de introduccion de items,,para evitaar que se amplie elvector
            btnAgregar.Enabled = false;
            txtTextBox1.Enabled = false;

            //llamamos a los metodso que generan el vector pricipal y los subvectores
            GenerarVectorOriginal();
            GenerarSubVectores();

            //mostramos el vector original por consola y formulario. 
            Console.WriteLine("\nSu vector se compone de los siguientes elementos: \n");
            foreach (string vector in vectorRecogido)
            {
                Console.Write(vector);
                Console.Write(", ");
                txtVectorOriginal.Text += vector + ", ";
            }
            Console.WriteLine("\n");

            //eliminamos la ultima coma generada en el formulario por temas de estetica
            txtVectorOriginal.Text = txtVectorOriginal.Text.TrimEnd(',', ' ');

            groupSeleccionOrdenacion.Enabled = true;//habilitamos el selector de ordenacion
            btnMostrarVector.Enabled = false;
        }

        //evento en el que realizamos las ordenaciones de los vectores y activamos el switch con el orden que el usuario ha decidido
        private void OrdenarVector_Click(object sender, EventArgs e)
        {
            Ordenacion.ordenacionVector(vectorRecogido, vectorRecogido.Length);
            Ordenacion.ordenacionVector(vectorNumeros, vectorNumeros.Length);
            Ordenacion.ordenacionVector(vectorLetras, vectorLetras.Length);
            Ordenacion.ordenacionVector(vectorCaracteresEspeciales, vectorCaracteresEspeciales.Length);
            SwitchSeleccion(strOrdenComboBox);
            txtVectorOrdenado.Visible = true;
        }
        #endregion

        #region RadButton y Combobox
        //definimos accion para el radio button que solicita ordenacion staandard de vector
        private void rbStardard_CheckedChanged(object sender, EventArgs e)
        {
            //ordenamos el vector con el metodo de ordenacion por defecto de la clase Ordenacion
            //definimos el valor que se asignar'a al swich de elecion de tipo de ordenacion, y mostramos el boton de mostrar el vector ordenado
            radPersonalizada.Enabled = false;
            Ordenacion.ordenacionVector(vectorRecogido, vectorRecogido.Length);
            strOrdenComboBox = "defecto";
            btnMostrarVectorOrdenado.Visible = true;
            Console.WriteLine("ha elegido usted la ordeancion Unicode estandard del sistema. procedemosc a realizar dicha ordenaacion");
        }

        //si se selecciona el radiobuton de ordenacion personalizada, mostramos el comboBox que lo maneja
        private void rbPersonalizada_CheckedChanged(object sender, EventArgs e)
        {
            radStardard.Enabled = false;
            cboComboBox1.Visible = true;
        }

        //comobobox donde definimos el orden de ordenacion(valga la redundancia) del vector
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (cboComboBox1.Items.Count > 2)//cuando aparecen todos los elementos del combobox
            {
                SelectedItem = cboComboBox1.SelectedItem.ToString();//guardamos la seleccion del usuario como primer string

                //mostramos mensaje al usuario con su eleccion
                lblLabelA.Text = lblLabelA.Text + " " + SelectedItem;
                lblLabelA.Visible = true;

                cboComboBox1.Items.Remove(SelectedItem);//eliminamos el item seleccionado del combobox para evitar que lo eliga de nuevo
                strOrdenComboBox = SelectedItem;//escribimos en la variable que maneja el switch el valor seleccionado en priemr lgar


            }
            else if (cboComboBox1.Items.Count > 1)//cuando ya solo quedan dos elementos
            {

                SelectedItem2 = cboComboBox1.SelectedItem.ToString();//guardamos la eleccion como segundo string

                //mostramos mensaje al usuario con su eleccion
                lblLabelB.Text = lblLabelB.Text + " " + SelectedItem2;
                lblLabelB.Visible = true;

                cboComboBox1.Items.Remove(SelectedItem2);//eliminamos el item seleccionado del combobox para que se quede solo el no seleccionado

                NoSelectedItem = cboComboBox1.Items[0].ToString();//recogemos el unico item restante en el combobox y lo guardamos como ultima eleccion

                //mostramos mensaje al usuario con su eleccion
                lblLabelC.Text = lblLabelC.Text + " " + NoSelectedItem;
                lblLabelC.Visible = true;

                //añadimos al string control de switch los valores elegidos en el orden correspondiente,
                //con esto el string de switch contiene la secuencia completa de ordenacion elegida por el usuario
                strOrdenComboBox += SelectedItem2 + NoSelectedItem;

                //mostramos el boton para visualizar el vector ordenado 
                btnMostrarVectorOrdenado.Visible = true;

                //informamos por consola
                Console.WriteLine("Su ordenacion seleccionada tiene el siguiente orden: {0}, {1} y por ultimo {2}.\n", SelectedItem, SelectedItem2, NoSelectedItem);
                Console.WriteLine("Procedemos a realizar la ordenacion");
            }



        }

        #endregion

        #region Motodos
        //metodo que genera el vector requerido dividiendo el string suma de datos introducidos
        //por el usuario y usando el caracter especial inusual como splitter. Tambien se eliminan
        //los items de vector vacios que se pudieran producir
        private void GenerarVectorOriginal()
        {
            vectorRecogido = datoRecogido.Split('Љ', StringSplitOptions.RemoveEmptyEntries);
        }

        private void GenerarSubVectores()
        {
            //buscamos los tamaños de los subvectores que se crearan y definimos e inicializamos dichos subvectores
            CreacionYVerificacion.tamanoSubVectores(vectorRecogido);

            vectorNumeros = new string[CreacionYVerificacion.CantidadNumeros];
            vectorLetras = new string[CreacionYVerificacion.CantidadLetras];
            vectorCaracteresEspeciales = new string[CreacionYVerificacion.CantidadCaracteresEspeciales];

            //rellenamos los subvectores con los datos correspondientes a cada uno
            CreacionYVerificacion.rellenarSubVectores(vectorRecogido, vectorNumeros, vectorLetras, vectorCaracteresEspeciales);
        }

        //switch de seleccion de ordenacion, pasando el string generado en los radiobutton y combobox como parametro
        private void SwitchSeleccion(string strOrdenComboBox)
        {
            string resultado = string.Empty;

            switch (strOrdenComboBox)
            {
                //para cada casuistica, se rellena un array con los subvectores en el orden correspondiente,
                //y se recorre el array creado para mostrarlo por pantalla. Para el caso "defecto", se recorre directamente el vector recogido
                //ya ordenado
                case "Caracteres EspecialesNumerosLetras":
                    OrdenadoEspNumLet = vectorCaracteresEspeciales.Concat(vectorNumeros).Concat(vectorLetras).ToArray();

                    Console.WriteLine("Su vector ordenado por Especiales-Numeros-Letras: \n");
                    foreach (string item in OrdenadoEspNumLet)
                    {
                        resultado += item + ", ";
                        txtVectorOrdenado.Text += item + ", ";
                    }
                    resultado = resultado.TrimEnd(',', ' ');
                    Console.WriteLine(resultado);
                    txtVectorOrdenado.Text = txtVectorOrdenado.Text.TrimEnd(',', ' ');
                    break;

                case "Caracteres EspecialesLetrasNumeros":
                    OrdenadoEspLetNum = vectorCaracteresEspeciales.Concat(vectorLetras).Concat(vectorNumeros).ToArray();

                    Console.WriteLine("Su vector ordenado por Especiales-Letras-Numeros: \n");
                    foreach (string item in OrdenadoEspLetNum)
                    {
                        resultado += item + ", ";
                        txtVectorOrdenado.Text += item + ", ";
                    }
                    resultado = resultado.TrimEnd(',', ' ');
                    Console.WriteLine(resultado);
                    txtVectorOrdenado.Text = txtVectorOrdenado.Text.TrimEnd(',', ' ');
                    break;

                case "NumerosLetrasCaracteres Especiales":
                    OrdenadoNumLetEsp = vectorNumeros.Concat(vectorLetras).Concat(vectorCaracteresEspeciales).ToArray();

                    Console.WriteLine("Su vector ordenado por Numeros-Letras-Especiales: \n");
                    foreach (string item in OrdenadoNumLetEsp)
                    {
                        resultado += item + ", ";
                        txtVectorOrdenado.Text += item + ", ";
                    }
                    resultado = resultado.TrimEnd(',', ' ');
                    Console.WriteLine(resultado);
                    txtVectorOrdenado.Text = txtVectorOrdenado.Text.TrimEnd(',', ' ');
                    break;

                case "NumerosCaracteres EspecialesLetras":
                    OrdenadoNumEspLet = vectorNumeros.Concat(vectorCaracteresEspeciales).Concat(vectorLetras).ToArray();

                    Console.WriteLine("Su vector ordenado por Numeros-Especiales-Letras: \n");
                    foreach (string item in OrdenadoNumEspLet)
                    {
                        resultado += item + ", ";
                        txtVectorOrdenado.Text += item + ", ";
                    }
                    resultado = resultado.TrimEnd(',', ' ');
                    Console.WriteLine(resultado);
                    txtVectorOrdenado.Text = txtVectorOrdenado.Text.TrimEnd(',', ' ');
                    break;

                case "LetrasCaracteres EspecialesNumeros":
                    OrdenadoLetEspNum = vectorLetras.Concat(vectorCaracteresEspeciales).Concat(vectorNumeros).ToArray();

                    Console.WriteLine("Su vector ordenado por Letras-Especiales-Numeros: \n");
                    foreach (string item in OrdenadoLetEspNum)
                    {
                        resultado += item + ", ";
                        txtVectorOrdenado.Text += item + ", ";
                    }
                    resultado = resultado.TrimEnd(',', ' ');
                    Console.WriteLine(resultado);
                    txtVectorOrdenado.Text = txtVectorOrdenado.Text.TrimEnd(',', ' ');
                    break;

                case "LetrasNumerosCaracteres Especiales":
                    OrdenadoLetNumEsp = vectorLetras.Concat(vectorNumeros).Concat(vectorCaracteresEspeciales).ToArray();

                    Console.WriteLine("Su vector ordenado por Letras-Numeros-Especiales: \n");
                    foreach (string item in OrdenadoLetNumEsp)
                    {
                        resultado += item + ", ";
                        txtVectorOrdenado.Text += item + ", ";
                    }
                    resultado = resultado.TrimEnd(',', ' ');
                    Console.WriteLine(resultado);
                    txtVectorOrdenado.Text = txtVectorOrdenado.Text.TrimEnd(',', ' ');
                    break;

                case "defecto":
                    Console.WriteLine("Su vector ordenado por defecto: \n");
                    foreach (string item in vectorRecogido)
                    {
                        resultado += item + ", ";
                        txtVectorOrdenado.Text += item + ", ";
                    }
                    resultado = resultado.TrimEnd(',', ' ');
                    Console.WriteLine(resultado);
                    txtVectorOrdenado.Text = txtVectorOrdenado.Text.TrimEnd(',', ' ');

                    break;
            }
            //definimos los elementos que queremos que queden activos al mostrar el vector ya ordenado
            //y deshabilitamos el resto
            Control[] enables = { lblFinEjecucion, btnCerrar, btnReiniciar, groupFinPrograma, lblMensajeVectorOrdenado, txtVectorOrdenado, pbExit, pbRestart, pbInfo };

            foreach (Control control in Controls)
            {
                if (!enables.Contains(control))
                {
                    control.Enabled = false;
                }
            }

            //mostramos los elementos que dejamos hablilitados, que hasta ahora estaban no visibles
            groupFinPrograma.Visible = true;
            lblFinEjecucion.Visible = true;
            btnReiniciar.Visible = true;
            btnCerrar.Visible = true;
            lblMensajeVectorOrdenado.Visible = true;
            txtVectorOrdenado.Visible = true;

        }
        #endregion

        #region Botones de menu
        //evento de reinicio de aplicacion
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Console.Clear();
            Application.Restart();
        }

        private void pbInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La ordenacion standard del sistema utiliza el codigo Unicode de cada" +
                "caracter paara determinar el orden de los mismos.\r\n\nComo  norma general, eso supone que" +
                "ordena primero los caracteres especiales, despues numeros y finallmente letras.\r\n\n" +
                "Debido a que alguno de los caracteres especiaales puede ser qque se ordene despues de numeros" +
                "o letras, este programa ofrece diversas posibilidades de ordeancion para que el usuario" +
                "eliga la que mas le guste");
        }

        //evento de cerrar la aplicacion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region timer
        //evento que se produce al terminar el timer. Ocultamos la presentacion del label que nos informa de la insercion correcta de dato
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCOnfirmacionInsercion.Visible = false;
            timer1.Stop();
        }

        //metodo que pone en visible un mensaje de confirmacion y activa el timer para que se oculte luego
        private void MostrarLabelInsertado()
        {
            lblCOnfirmacionInsercion.Visible = true;
            timer1.Start();
        }
        #endregion
    }
}

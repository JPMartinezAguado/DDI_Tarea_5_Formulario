namespace DDI_Tarea_5_Formulario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnAgregar = new Button();
            txtTextBox1 = new TextBox();
            btnMostrarVector = new Button();
            txtVectorOriginal = new TextBox();
            groupSeleccionOrdenacion = new GroupBox();
            lblLabelC = new Label();
            lblLabelB = new Label();
            lblLabelA = new Label();
            tercerCriterio = new Label();
            SegundoCriterio = new Label();
            PrimerCriterio = new Label();
            cboComboBox1 = new ComboBox();
            radPersonalizada = new RadioButton();
            radStardard = new RadioButton();
            groupFinPrograma = new GroupBox();
            lblMensajeVectorOrdenado = new Label();
            btnReiniciar = new Button();
            txtVectorOrdenado = new TextBox();
            btnCerrar = new Button();
            lblFinEjecucion = new Label();
            btnMostrarVectorOrdenado = new Button();
            lblnsertarItem = new Label();
            lblCOnfirmacionInsercion = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pbExit = new PictureBox();
            pbRestart = new PictureBox();
            pbInfo = new PictureBox();
            groupSeleccionOrdenacion.SuspendLayout();
            groupFinPrograma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRestart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInfo).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.AliceBlue;
            btnAgregar.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.DimGray;
            btnAgregar.Location = new Point(261, 91);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Añadir";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += agregar_Click;
            // 
            // txtTextBox1
            // 
            txtTextBox1.BackColor = Color.AliceBlue;
            txtTextBox1.Font = new Font("Agency FB", 12F);
            txtTextBox1.Location = new Point(89, 91);
            txtTextBox1.Name = "txtTextBox1";
            txtTextBox1.Size = new Size(167, 26);
            txtTextBox1.TabIndex = 0;
            // 
            // btnMostrarVector
            // 
            btnMostrarVector.BackColor = Color.AliceBlue;
            btnMostrarVector.Enabled = false;
            btnMostrarVector.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarVector.ForeColor = Color.Gray;
            btnMostrarVector.Location = new Point(443, 78);
            btnMostrarVector.Name = "btnMostrarVector";
            btnMostrarVector.Size = new Size(249, 49);
            btnMostrarVector.TabIndex = 3;
            btnMostrarVector.Text = "Muestrame mi vector";
            btnMostrarVector.UseVisualStyleBackColor = false;
            btnMostrarVector.Click += mostrarVector_Click;
            // 
            // txtVectorOriginal
            // 
            txtVectorOriginal.BackColor = Color.AliceBlue;
            txtVectorOriginal.Font = new Font("Bodoni MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVectorOriginal.ForeColor = Color.SlateGray;
            txtVectorOriginal.Location = new Point(428, 146);
            txtVectorOriginal.Multiline = true;
            txtVectorOriginal.Name = "txtVectorOriginal";
            txtVectorOriginal.Size = new Size(302, 59);
            txtVectorOriginal.TabIndex = 4;
            txtVectorOriginal.TextAlign = HorizontalAlignment.Center;
            // 
            // groupSeleccionOrdenacion
            // 
            groupSeleccionOrdenacion.BackColor = Color.Transparent;
            groupSeleccionOrdenacion.BackgroundImage = Properties.Resources.fondo3;
            groupSeleccionOrdenacion.BackgroundImageLayout = ImageLayout.Stretch;
            groupSeleccionOrdenacion.Controls.Add(lblLabelC);
            groupSeleccionOrdenacion.Controls.Add(lblLabelB);
            groupSeleccionOrdenacion.Controls.Add(lblLabelA);
            groupSeleccionOrdenacion.Controls.Add(tercerCriterio);
            groupSeleccionOrdenacion.Controls.Add(SegundoCriterio);
            groupSeleccionOrdenacion.Controls.Add(PrimerCriterio);
            groupSeleccionOrdenacion.Controls.Add(cboComboBox1);
            groupSeleccionOrdenacion.Controls.Add(radPersonalizada);
            groupSeleccionOrdenacion.Controls.Add(radStardard);
            groupSeleccionOrdenacion.Enabled = false;
            groupSeleccionOrdenacion.Font = new Font("Agency FB", 12F);
            groupSeleccionOrdenacion.Location = new Point(77, 146);
            groupSeleccionOrdenacion.Name = "groupSeleccionOrdenacion";
            groupSeleccionOrdenacion.Size = new Size(320, 262);
            groupSeleccionOrdenacion.TabIndex = 5;
            groupSeleccionOrdenacion.TabStop = false;
            groupSeleccionOrdenacion.Text = "Tipo de ordenacion";
            // 
            // lblLabelC
            // 
            lblLabelC.AutoSize = true;
            lblLabelC.Font = new Font("Agency FB", 10.2F);
            lblLabelC.Location = new Point(24, 193);
            lblLabelC.Name = "lblLabelC";
            lblLabelC.Size = new Size(137, 18);
            lblLabelC.TabIndex = 9;
            lblLabelC.Text = "El ultimo elemento de orden es";
            lblLabelC.Visible = false;
            // 
            // lblLabelB
            // 
            lblLabelB.AutoSize = true;
            lblLabelB.Font = new Font("Agency FB", 10.2F);
            lblLabelB.Location = new Point(24, 172);
            lblLabelB.Name = "lblLabelB";
            lblLabelB.Size = new Size(144, 18);
            lblLabelB.TabIndex = 8;
            lblLabelB.Text = "El segundo criterio de orden es ";
            lblLabelB.Visible = false;
            // 
            // lblLabelA
            // 
            lblLabelA.AutoSize = true;
            lblLabelA.Font = new Font("Agency FB", 10.2F);
            lblLabelA.Location = new Point(24, 154);
            lblLabelA.Name = "lblLabelA";
            lblLabelA.Size = new Size(136, 18);
            lblLabelA.TabIndex = 7;
            lblLabelA.Text = "El primer criterio de orden es";
            lblLabelA.Visible = false;
            // 
            // tercerCriterio
            // 
            tercerCriterio.AutoSize = true;
            tercerCriterio.Location = new Point(20, 229);
            tercerCriterio.Name = "tercerCriterio";
            tercerCriterio.Size = new Size(0, 20);
            tercerCriterio.TabIndex = 6;
            // 
            // SegundoCriterio
            // 
            SegundoCriterio.AutoSize = true;
            SegundoCriterio.Location = new Point(18, 193);
            SegundoCriterio.Name = "SegundoCriterio";
            SegundoCriterio.Size = new Size(0, 20);
            SegundoCriterio.TabIndex = 5;
            // 
            // PrimerCriterio
            // 
            PrimerCriterio.AutoSize = true;
            PrimerCriterio.Location = new Point(27, 154);
            PrimerCriterio.Name = "PrimerCriterio";
            PrimerCriterio.Size = new Size(0, 20);
            PrimerCriterio.TabIndex = 4;
            PrimerCriterio.Visible = false;
            // 
            // cboComboBox1
            // 
            cboComboBox1.FormattingEnabled = true;
            cboComboBox1.Items.AddRange(new object[] { "Numeros", "Letras", "Caracteres Especiales" });
            cboComboBox1.Location = new Point(59, 94);
            cboComboBox1.Name = "cboComboBox1";
            cboComboBox1.Size = new Size(121, 28);
            cboComboBox1.TabIndex = 3;
            cboComboBox1.Text = "Elegir criterio";
            cboComboBox1.Visible = false;
            cboComboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // radPersonalizada
            // 
            radPersonalizada.AutoSize = true;
            radPersonalizada.Location = new Point(41, 52);
            radPersonalizada.Name = "radPersonalizada";
            radPersonalizada.Size = new Size(138, 24);
            radPersonalizada.TabIndex = 1;
            radPersonalizada.TabStop = true;
            radPersonalizada.Text = "Ordenación Personalizada";
            radPersonalizada.UseVisualStyleBackColor = true;
            radPersonalizada.CheckedChanged += rbPersonalizada_CheckedChanged;
            // 
            // radStardard
            // 
            radStardard.AutoSize = true;
            radStardard.Location = new Point(41, 34);
            radStardard.Name = "radStardard";
            radStardard.Size = new Size(153, 24);
            radStardard.TabIndex = 0;
            radStardard.TabStop = true;
            radStardard.Text = "Ordenacion Standard Unicode";
            radStardard.UseVisualStyleBackColor = true;
            radStardard.CheckedChanged += rbStardard_CheckedChanged;
            // 
            // groupFinPrograma
            // 
            groupFinPrograma.BackColor = Color.Transparent;
            groupFinPrograma.BackgroundImage = Properties.Resources.fondo4;
            groupFinPrograma.BackgroundImageLayout = ImageLayout.Stretch;
            groupFinPrograma.Controls.Add(lblMensajeVectorOrdenado);
            groupFinPrograma.Controls.Add(btnReiniciar);
            groupFinPrograma.Controls.Add(txtVectorOrdenado);
            groupFinPrograma.Controls.Add(btnCerrar);
            groupFinPrograma.Controls.Add(lblFinEjecucion);
            groupFinPrograma.Font = new Font("Agency FB", 12F);
            groupFinPrograma.Location = new Point(68, 54);
            groupFinPrograma.Margin = new Padding(3, 2, 3, 2);
            groupFinPrograma.Name = "groupFinPrograma";
            groupFinPrograma.Padding = new Padding(3, 2, 3, 2);
            groupFinPrograma.Size = new Size(683, 367);
            groupFinPrograma.TabIndex = 11;
            groupFinPrograma.TabStop = false;
            groupFinPrograma.Text = "Fin de Programa";
            groupFinPrograma.Visible = false;
            // 
            // lblMensajeVectorOrdenado
            // 
            lblMensajeVectorOrdenado.Font = new Font("Bodoni MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensajeVectorOrdenado.ForeColor = SystemColors.ControlDarkDark;
            lblMensajeVectorOrdenado.Location = new Point(114, 60);
            lblMensajeVectorOrdenado.Name = "lblMensajeVectorOrdenado";
            lblMensajeVectorOrdenado.Size = new Size(452, 23);
            lblMensajeVectorOrdenado.TabIndex = 11;
            lblMensajeVectorOrdenado.Text = "Su vector debidamente ordenado quedaria asi";
            lblMensajeVectorOrdenado.TextAlign = ContentAlignment.MiddleCenter;
            lblMensajeVectorOrdenado.Visible = false;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.Transparent;
            btnReiniciar.BackgroundImage = Properties.Resources.texturaboton;
            btnReiniciar.BackgroundImageLayout = ImageLayout.Stretch;
            btnReiniciar.Font = new Font("Agency FB", 18F, FontStyle.Bold);
            btnReiniciar.ForeColor = SystemColors.ButtonHighlight;
            btnReiniciar.Location = new Point(143, 242);
            btnReiniciar.Margin = new Padding(3, 2, 3, 2);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(156, 81);
            btnReiniciar.TabIndex = 9;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Visible = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // txtVectorOrdenado
            // 
            txtVectorOrdenado.BackColor = SystemColors.MenuBar;
            txtVectorOrdenado.Font = new Font("Bodoni MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVectorOrdenado.ForeColor = SystemColors.WindowFrame;
            txtVectorOrdenado.Location = new Point(102, 104);
            txtVectorOrdenado.Multiline = true;
            txtVectorOrdenado.Name = "txtVectorOrdenado";
            txtVectorOrdenado.Size = new Size(464, 44);
            txtVectorOrdenado.TabIndex = 7;
            txtVectorOrdenado.TextAlign = HorizontalAlignment.Center;
            txtVectorOrdenado.Visible = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = Properties.Resources.texturaboton;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Font = new Font("Agency FB", 18F, FontStyle.Bold);
            btnCerrar.ForeColor = SystemColors.ButtonHighlight;
            btnCerrar.Location = new Point(385, 244);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(164, 79);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Apagar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Visible = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblFinEjecucion
            // 
            lblFinEjecucion.Font = new Font("Bodoni MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFinEjecucion.ForeColor = SystemColors.ControlDarkDark;
            lblFinEjecucion.Location = new Point(70, 154);
            lblFinEjecucion.Name = "lblFinEjecucion";
            lblFinEjecucion.Size = new Size(536, 88);
            lblFinEjecucion.TabIndex = 10;
            lblFinEjecucion.Text = "Ha llegado al fin del programa, eliga apagar o reiniciar el Ordenador de Vectores";
            lblFinEjecucion.TextAlign = ContentAlignment.MiddleCenter;
            lblFinEjecucion.Visible = false;
            // 
            // btnMostrarVectorOrdenado
            // 
            btnMostrarVectorOrdenado.BackColor = Color.AliceBlue;
            btnMostrarVectorOrdenado.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarVectorOrdenado.ForeColor = Color.Gray;
            btnMostrarVectorOrdenado.Location = new Point(428, 239);
            btnMostrarVectorOrdenado.Name = "btnMostrarVectorOrdenado";
            btnMostrarVectorOrdenado.Size = new Size(297, 107);
            btnMostrarVectorOrdenado.TabIndex = 6;
            btnMostrarVectorOrdenado.Text = "Muestrame mi vector ordenado";
            btnMostrarVectorOrdenado.UseVisualStyleBackColor = false;
            btnMostrarVectorOrdenado.Visible = false;
            btnMostrarVectorOrdenado.Click += OrdenarVector_Click;
            // 
            // lblnsertarItem
            // 
            lblnsertarItem.AutoSize = true;
            lblnsertarItem.BackColor = Color.Transparent;
            lblnsertarItem.Font = new Font("Agency FB", 12F);
            lblnsertarItem.Location = new Point(89, 65);
            lblnsertarItem.Name = "lblnsertarItem";
            lblnsertarItem.Size = new Size(151, 20);
            lblnsertarItem.TabIndex = 12;
            lblnsertarItem.Text = "Inserte un elemento de su vector";
            // 
            // lblCOnfirmacionInsercion
            // 
            lblCOnfirmacionInsercion.AutoSize = true;
            lblCOnfirmacionInsercion.BackColor = Color.Transparent;
            lblCOnfirmacionInsercion.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCOnfirmacionInsercion.ForeColor = Color.LimeGreen;
            lblCOnfirmacionInsercion.Location = new Point(128, 126);
            lblCOnfirmacionInsercion.Name = "lblCOnfirmacionInsercion";
            lblCOnfirmacionInsercion.Size = new Size(152, 20);
            lblCOnfirmacionInsercion.TabIndex = 13;
            lblCOnfirmacionInsercion.Text = "Elemento insertado con éxito";
            lblCOnfirmacionInsercion.Visible = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pbExit
            // 
            pbExit.BackColor = Color.Transparent;
            pbExit.Image = Properties.Resources.botonXrojo__1_;
            pbExit.Location = new Point(719, 28);
            pbExit.Margin = new Padding(3, 2, 3, 2);
            pbExit.Name = "pbExit";
            pbExit.Size = new Size(22, 19);
            pbExit.SizeMode = PictureBoxSizeMode.StretchImage;
            pbExit.TabIndex = 16;
            pbExit.TabStop = false;
            pbExit.Click += btnCerrar_Click;
            // 
            // pbRestart
            // 
            pbRestart.BackColor = Color.Transparent;
            pbRestart.Image = Properties.Resources.Reset1;
            pbRestart.Location = new Point(684, 28);
            pbRestart.Margin = new Padding(3, 2, 3, 2);
            pbRestart.Name = "pbRestart";
            pbRestart.Size = new Size(22, 19);
            pbRestart.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRestart.TabIndex = 17;
            pbRestart.TabStop = false;
            pbRestart.Click += btnReiniciar_Click;
            // 
            // pbInfo
            // 
            pbInfo.BackColor = Color.Transparent;
            pbInfo.Image = Properties.Resources.info__1_;
            pbInfo.Location = new Point(639, 25);
            pbInfo.Margin = new Padding(3, 2, 3, 2);
            pbInfo.Name = "pbInfo";
            pbInfo.Size = new Size(29, 25);
            pbInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInfo.TabIndex = 18;
            pbInfo.TabStop = false;
            pbInfo.Click += pbInfo_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAgregar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = Properties.Resources.New_gradient;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pbInfo);
            Controls.Add(pbRestart);
            Controls.Add(pbExit);
            Controls.Add(groupFinPrograma);
            Controls.Add(groupSeleccionOrdenacion);
            Controls.Add(txtVectorOriginal);
            Controls.Add(btnMostrarVector);
            Controls.Add(txtTextBox1);
            Controls.Add(btnAgregar);
            Controls.Add(btnMostrarVectorOrdenado);
            Controls.Add(lblnsertarItem);
            Controls.Add(lblCOnfirmacionInsercion);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ORDENADOR (de los de ordenar cosas) DE VECTORES";
            TopMost = true;
            TransparencyKey = Color.LightSteelBlue;
            Load += Form1_Load;
            groupSeleccionOrdenacion.ResumeLayout(false);
            groupSeleccionOrdenacion.PerformLayout();
            groupFinPrograma.ResumeLayout(false);
            groupFinPrograma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRestart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtTextBox1;
        private Button btnMostrarVector;
        private TextBox txtVectorOriginal;
        private GroupBox groupSeleccionOrdenacion;
        private Button btnMostrarVectorOrdenado;
        private TextBox txtVectorOrdenado;
        private RadioButton radPersonalizada;
        private RadioButton radStardard;
        private ComboBox cboComboBox1;
        private Label tercerCriterio;
        private Label SegundoCriterio;
        private Label PrimerCriterio;
        private Label lblLabelA;
        private Label lblLabelC;
        private Label lblLabelB;
        private Button btnCerrar;
        private Button btnReiniciar;
        private Label lblFinEjecucion;
        private GroupBox groupFinPrograma;
        private Label lblMensajeVectorOrdenado;
        private Label lblnsertarItem;
        private Label lblCOnfirmacionInsercion;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pbExit;
        private PictureBox pbRestart;
        private PictureBox pbInfo;
    }
}

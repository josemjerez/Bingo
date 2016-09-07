
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Bingo
{
    public partial class Principal : Form
    {
        private ArrayList Lista_Numeros;
        private ArrayList Lista_Ultimos_Numeros;
        private System.Random rr = new Random();
        private int Faltan;
        private ArrayList Numeros_Trampa;
        private bool Loquendo = false;

        private Color Color_Fondo_Numero_Actual = Color.Pink;
        private Color Color_Texto_Numero_Actual = Color.Black;
        private Color Color_Fondo_Numero_Dicho  = Color.Pink;

        private SICE_UTILES.ARCHIVO_INI FINI;


        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        public Principal()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void Principal_Load(object sender, EventArgs e)
        {
            FINI = new SICE_UTILES.ARCHIVO_INI(Application.StartupPath + "bingo.ini");
            T_Pre_Decir.Text = FINI.Get("parametros", "predecir",", ");

            
            Lista_Numeros = new ArrayList();
            Lista_Ultimos_Numeros = new ArrayList();
            Numeros_Trampa = new ArrayList();      
            Reset_Juego();
            T_Juego.Text = "5";
            
            //Decir("Hola Rocio, ¿tenemos ganas de echar un bingo hoy?");

        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void Reposiciona_Numeros()
        {
        int ancho, alto, margen = 20, X, Y;

            ancho = (Panel_Numeros.Width - (margen * (2 + 8))) / 9;
            alto = (Panel_Numeros.Height - (margen * (2 + 9))) / 10;

            X = margen;
            Y = margen;

            foreach (Label ll in Panel_Numeros.Controls)
            {
                ll.Height = alto;
                ll.Width = ancho;
                ll.Left = X;
                ll.Top = Y;

                Y += alto + margen;

                if (Y+alto > Panel_Numeros.Height)
                {
                    Y = margen;
                    X += ancho + margen;
                }
            }
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void Reposiciona_Ultimos_Numeros()
        {
            int ancho, alto, margen = 20, X, Y;

            ancho = (Panel_Ultimos_Numeros.Width - (margen * 2));
            alto = (Panel_Ultimos_Numeros.Height - (margen * (2 + 4))) / 5;

            X = margen;
            Y = margen;

            foreach (Label ll in Panel_Ultimos_Numeros.Controls)
            {
                ll.Height = alto;
                ll.Width = ancho;
                ll.Left = X;
                ll.Top = Y;

                Y += alto + margen;

                if (Y + alto > Panel_Ultimos_Numeros.Height)
                {
                    Y = margen;
                    X += ancho + margen;
                }
            }
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void Cargar_Numeros()
        {
            //Numeros del panel principal
            foreach (Label ll in Panel_Numeros.Controls )
            {
                ll.Visible = false;
            }
            Panel_Numeros.Controls.Clear();


            Lista_Numeros.Clear();
            for ( int x=0 ; x <= 89 ; x++ )
            {
                Label nn = new Label();

                //nn = inf_numero;
                nn.TextAlign    = ContentAlignment.MiddleCenter;
                //nn.Cursor       = Cursors.Cross;
                nn.FlatStyle    = FlatStyle.Flat;
                nn.BorderStyle  = BorderStyle.FixedSingle;
                nn.Height       = 60;
                nn.Width        = 60;
                nn.Text         = (x+1).ToString();
                nn.Top          = inf_numero.Left + (inf_numero.Width * (x % 10));
                nn.Left         = inf_numero.Top + (inf_numero.Height * (x / 10));
                nn.Font         = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                nn.BackColor    = Color.White;
                nn.Name         = x.ToString();
                nn.Visible      = true;
                nn.Click        += nn_Click;
                nn.BringToFront();

                Panel_Numeros.Controls.Add(nn);

                Lista_Numeros.Add( nn );
            }

            Reposiciona_Numeros();


            //Numeros del panel de ultimos numeros
            foreach (Label ll in Panel_Ultimos_Numeros.Controls)
            {
                ll.Visible = false;
            }
            Panel_Ultimos_Numeros.Controls.Clear();

            Lista_Ultimos_Numeros.Clear();
            for ( int x=0; x<5 ; x++ )
            {
                Label nn = new Label();

                nn.TextAlign = ContentAlignment.MiddleCenter;
                nn.FlatStyle = FlatStyle.Flat;
                nn.BorderStyle = BorderStyle.FixedSingle;
                nn.Height = 60;
                nn.Width = 60;
                nn.Text = "";
                nn.Top = inf_numero.Left + (inf_numero.Width * (x % 10));
                nn.Left = inf_numero.Top + (inf_numero.Height * (x / 10));
                nn.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                nn.BackColor = Color.White;
                nn.Name = x.ToString();
                nn.Visible = true;
                nn.BringToFront();
                nn.Click += nn_Ultimo_Click;

                Panel_Ultimos_Numeros.Controls.Add(nn);

                Lista_Ultimos_Numeros.Add(nn);
            }
            Reposiciona_Ultimos_Numeros();

        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        void nn_Click(object sender, EventArgs e)
        {
        bool Encontrado = false;

            //Si el numero no esta ya seleccionado lo metemos en la lista de numeros trampa
            if (((Label)sender).BackColor == Color.White)
            {
                //Pero para meterno NO debe estar ya dentro
                foreach ( Label ll in Numeros_Trampa )
                {
                    if (ll.Text.Equals(((Label)sender).Text))
                        Encontrado = true;
                }

                if ( ! Encontrado )
                    Numeros_Trampa.Add(sender);
            }
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        void nn_Ultimo_Click(object sender, EventArgs e)
        {
        String Frase = "";

            if (Timer_Juego.Enabled) return;
            

            foreach (Label ll in Panel_Ultimos_Numeros.Controls)
            {
                if ( !ll.Text.Equals("") )
                {
                    if (Frase.Equals(""))
                        Frase = "Los últimos numeros son los siguientes, ";

                    Frase += ", " + ll.Text;
                }
            }
            
            Decir( Frase );
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void Reset_Juego()
        {
            Pausar_Juego();

            Cargar_Numeros();
            
            foreach ( Label ll in Lista_Numeros )
            {
                ll.BackColor = Color.White;
                ll.Tag = 0;
            }

            Bot_Iniciar.Text = "INICIAR";
            Faltan = 90;
            Inf_Actual.Text = "";
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void Pausar_Juego()
        {
            Decir("El juego está en pausa.");
            
            Timer_Juego.Enabled = false;
            Inf_Actual.BackColor = Color.White;
            Bot_Iniciar.Text = "CONTINUAR";
            Bot_Reset.Enabled = true;
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void Iniciar_Juego()
        {
            Decir("Presten atención, el bingo de Rocio comienza.");

            Timer_Juego.Enabled = true;
            Inf_Actual.BackColor = Color_Fondo_Numero_Actual;
            Bot_Iniciar.Text = "(Esc) PAUSAR";
            Bot_Reset.Enabled = false;
        }
        
        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void Decir_Nuevo_Numero()
        {
        int Numero=-1;


            if (Faltan == 0) return;

            if (Numeros_Trampa.Count > 0)
            {
                for ( int x=0 ; x< Lista_Numeros.Count ; x++ )
                {
                    if (((Label)Lista_Numeros[x]).Text.Equals(((Label)Numeros_Trampa[0]).Text))
                        Numero = x;
                }
                Numeros_Trampa.RemoveAt(0);

                if ( Numero == -1 )
                    Numero = rr.Next(Faltan);
                
            }
            else
            {
                Numero = rr.Next(Faltan);
            }

            ((Label)Lista_Numeros[Numero]).BackColor = Color_Fondo_Numero_Dicho;
            ((Label)Lista_Numeros[Numero]).ForeColor= Color.Black;

            Inf_Actual.Text = ((Label)Lista_Numeros[Numero]).Text;
            Inf_Actual.BackColor = Color.Pink;

            Sonar_Numero();

            Lista_Numeros.RemoveAt(Numero);

            //Mostramos el ultimo numero en la lista
            for (int x = 0; x <4; x++ )
                ((Label)Panel_Ultimos_Numeros.Controls[x]).Text = ((Label)Panel_Ultimos_Numeros.Controls[x+1]).Text;
            ((Label)Panel_Ultimos_Numeros.Controls[4]).Text = Inf_Actual.Text;

            Faltan--;
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void T_Juego_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Timer_Juego.Interval = int.Parse( T_Juego.Text ) * 1000;
                T_Juego.BackColor = Color.White;
            }
            catch
            {
                T_Juego.BackColor = Color.Tomato;
            }
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void Bot_Iniciar_Click(object sender, EventArgs e)
        {        
            if ( Timer_Juego.Enabled ) 
                Pausar_Juego();
            else
                Iniciar_Juego();
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void Bot_Reset_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("Confirme el reset del juego","Atención",MessageBoxButtons.YesNoCancel ) == System.Windows.Forms.DialogResult.Yes )
                Reset_Juego();
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void Timer_Juego_Tick(object sender, EventArgs e)
        {
            //Si hemos llegado al final, paramos el juego
            if (Faltan == 0)
            {
                Pausar_Juego();
                return;
            }

            Decir_Nuevo_Numero();
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void Decir(String frase)
        {
            try
            {
                if (Loquendo)
                {
                    //LTTS7Class xime = new LTTS7Class();

                    //xime.Voice      = "Ximena"; 
                    //xime.Language   = "SpanishAm";
                    //xime.Read("Hola, mi nombre es Ximena!");
                }
                else
                {

                    SpeechSynthesizer ss = new SpeechSynthesizer();

                    ss.SpeakAsync(frase);
                }
            }
            catch (Exception ex) { }

        }


        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void Sonar_Numero()
        {
            try
            {
                String Frase = T_Pre_Decir.Text + " EL "+ Inf_Actual.Text;
                if (Inf_Actual.Text.Length > 1)
                    Frase += ", " + Inf_Actual.Text.Substring(0,1) + " " + Inf_Actual.Text.Substring(1,1);

                Decir(Frase);
            }
            catch{ }
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Pausar_Juego();
        }

        //----------------------------------------------------------------------------------------------
        // Reorganizamos los numeros en el panel cambiando su tamaño para ajustarlo al tamaño del panel
        //----------------------------------------------------------------------------------------------
        private void Panel_Numeros_Resize(object sender, EventArgs e)
        {
            Reposiciona_Numeros();
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            Decir_Nuevo_Numero();
        }

        private void Bot_Mas_Click(object sender, EventArgs e)
        {
            try
            {
                T_Juego.Text = (int.Parse(T_Juego.Text) + 1).ToString();
            }
            catch { }
        }

        private void Bot_Menos_Click(object sender, EventArgs e)
        {
            try
            {
                T_Juego.Text = (int.Parse(T_Juego.Text) - 1).ToString();
            }
            catch { }

        }

        private void Panel_Ultimos_Numeros_Resize(object sender, EventArgs e)
        {
            Reposiciona_Ultimos_Numeros();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Decir("Gracias por utilizarme Rocio, espero que recuerdes al informático que me creo para tí.");
            Thread.Sleep(5500);
        }

        private void T_Pre_Decir_TextChanged(object sender, EventArgs e)
        {
            FINI.Write("parametros", "predecir", T_Pre_Decir.Text);
        }
    }
}

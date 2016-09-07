namespace Bingo
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Bot_Iniciar = new System.Windows.Forms.Button();
            this.inf_numero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.T_Juego = new System.Windows.Forms.TextBox();
            this.Timer_Juego = new System.Windows.Forms.Timer(this.components);
            this.Bot_Reset = new System.Windows.Forms.Button();
            this.Inf_Actual = new System.Windows.Forms.Label();
            this.Panel_Numeros = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Bot_Mas = new System.Windows.Forms.Button();
            this.Bot_Menos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_Ultimos_Numeros = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.T_Pre_Decir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel_Numeros.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bot_Iniciar
            // 
            this.Bot_Iniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bot_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bot_Iniciar.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bot_Iniciar.Location = new System.Drawing.Point(514, 232);
            this.Bot_Iniciar.Name = "Bot_Iniciar";
            this.Bot_Iniciar.Size = new System.Drawing.Size(340, 112);
            this.Bot_Iniciar.TabIndex = 0;
            this.Bot_Iniciar.Text = "INICIAR";
            this.Bot_Iniciar.UseVisualStyleBackColor = true;
            this.Bot_Iniciar.Click += new System.EventHandler(this.Bot_Iniciar_Click);
            // 
            // inf_numero
            // 
            this.inf_numero.BackColor = System.Drawing.Color.SpringGreen;
            this.inf_numero.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inf_numero.Location = new System.Drawing.Point(14, 17);
            this.inf_numero.Name = "inf_numero";
            this.inf_numero.Size = new System.Drawing.Size(60, 60);
            this.inf_numero.TabIndex = 1;
            this.inf_numero.Text = "1";
            this.inf_numero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inf_numero.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiempo";
            // 
            // T_Juego
            // 
            this.T_Juego.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.T_Juego.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Juego.Location = new System.Drawing.Point(514, 186);
            this.T_Juego.MaxLength = 2;
            this.T_Juego.Name = "T_Juego";
            this.T_Juego.Size = new System.Drawing.Size(44, 40);
            this.T_Juego.TabIndex = 3;
            this.T_Juego.Text = "1";
            this.T_Juego.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.T_Juego.TextChanged += new System.EventHandler(this.T_Juego_TextChanged);
            // 
            // Timer_Juego
            // 
            this.Timer_Juego.Interval = 1000;
            this.Timer_Juego.Tick += new System.EventHandler(this.Timer_Juego_Tick);
            // 
            // Bot_Reset
            // 
            this.Bot_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bot_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bot_Reset.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bot_Reset.Location = new System.Drawing.Point(514, 350);
            this.Bot_Reset.Name = "Bot_Reset";
            this.Bot_Reset.Size = new System.Drawing.Size(340, 91);
            this.Bot_Reset.TabIndex = 4;
            this.Bot_Reset.Text = "RESET";
            this.Bot_Reset.UseVisualStyleBackColor = true;
            this.Bot_Reset.Click += new System.EventHandler(this.Bot_Reset_Click);
            // 
            // Inf_Actual
            // 
            this.Inf_Actual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inf_Actual.BackColor = System.Drawing.Color.Pink;
            this.Inf_Actual.Font = new System.Drawing.Font("Arial Narrow", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inf_Actual.Location = new System.Drawing.Point(514, 3);
            this.Inf_Actual.Name = "Inf_Actual";
            this.Inf_Actual.Size = new System.Drawing.Size(340, 150);
            this.Inf_Actual.TabIndex = 5;
            this.Inf_Actual.Text = "1";
            this.Inf_Actual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Numeros
            // 
            this.Panel_Numeros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Numeros.BackColor = System.Drawing.Color.White;
            this.Panel_Numeros.Controls.Add(this.inf_numero);
            this.Panel_Numeros.Location = new System.Drawing.Point(3, 3);
            this.Panel_Numeros.Name = "Panel_Numeros";
            this.Panel_Numeros.Size = new System.Drawing.Size(505, 545);
            this.Panel_Numeros.TabIndex = 6;
            this.Panel_Numeros.Resize += new System.EventHandler(this.Panel_Numeros_Resize);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(514, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 91);
            this.button1.TabIndex = 7;
            this.button1.Text = "NUEVO NUMERO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bot_Mas
            // 
            this.Bot_Mas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bot_Mas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bot_Mas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bot_Mas.Location = new System.Drawing.Point(564, 186);
            this.Bot_Mas.Name = "Bot_Mas";
            this.Bot_Mas.Size = new System.Drawing.Size(50, 40);
            this.Bot_Mas.TabIndex = 8;
            this.Bot_Mas.Text = "+";
            this.Bot_Mas.UseVisualStyleBackColor = true;
            this.Bot_Mas.Click += new System.EventHandler(this.Bot_Mas_Click);
            // 
            // Bot_Menos
            // 
            this.Bot_Menos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bot_Menos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bot_Menos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bot_Menos.Location = new System.Drawing.Point(620, 186);
            this.Bot_Menos.Name = "Bot_Menos";
            this.Bot_Menos.Size = new System.Drawing.Size(50, 40);
            this.Bot_Menos.TabIndex = 9;
            this.Bot_Menos.Text = "-";
            this.Bot_Menos.UseVisualStyleBackColor = true;
            this.Bot_Menos.Click += new System.EventHandler(this.Bot_Menos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 59);
            this.label2.TabIndex = 10;
            this.label2.Text = "EL BINGO DE ROCIO";
            // 
            // Panel_Ultimos_Numeros
            // 
            this.Panel_Ultimos_Numeros.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Ultimos_Numeros.Location = new System.Drawing.Point(860, 69);
            this.Panel_Ultimos_Numeros.Name = "Panel_Ultimos_Numeros";
            this.Panel_Ultimos_Numeros.Size = new System.Drawing.Size(133, 551);
            this.Panel_Ultimos_Numeros.TabIndex = 11;
            this.Panel_Ultimos_Numeros.Resize += new System.EventHandler(this.Panel_Ultimos_Numeros_Resize);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 69);
            this.panel2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(860, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "ULTIMOS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.T_Pre_Decir);
            this.panel3.Controls.Add(this.Inf_Actual);
            this.panel3.Controls.Add(this.Bot_Iniciar);
            this.panel3.Controls.Add(this.Bot_Menos);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Bot_Mas);
            this.panel3.Controls.Add(this.T_Juego);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Bot_Reset);
            this.panel3.Controls.Add(this.Panel_Numeros);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(860, 551);
            this.panel3.TabIndex = 13;
            // 
            // T_Pre_Decir
            // 
            this.T_Pre_Decir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.T_Pre_Decir.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Pre_Decir.Location = new System.Drawing.Point(676, 186);
            this.T_Pre_Decir.MaxLength = 0;
            this.T_Pre_Decir.Name = "T_Pre_Decir";
            this.T_Pre_Decir.Size = new System.Drawing.Size(178, 40);
            this.T_Pre_Decir.TabIndex = 10;
            this.T_Pre_Decir.Text = ",";
            this.T_Pre_Decir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.T_Pre_Decir.TextChanged += new System.EventHandler(this.T_Pre_Decir_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Frase antes del número";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(993, 620);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel_Ultimos_Numeros);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EL BINGO DE ROCIO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Principal_KeyDown);
            this.Panel_Numeros.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bot_Iniciar;
        private System.Windows.Forms.Label inf_numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox T_Juego;
        private System.Windows.Forms.Timer Timer_Juego;
        private System.Windows.Forms.Button Bot_Reset;
        private System.Windows.Forms.Label Inf_Actual;
        private System.Windows.Forms.Panel Panel_Numeros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Bot_Mas;
        private System.Windows.Forms.Button Bot_Menos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel_Ultimos_Numeros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox T_Pre_Decir;
        private System.Windows.Forms.Label label4;
    }
}


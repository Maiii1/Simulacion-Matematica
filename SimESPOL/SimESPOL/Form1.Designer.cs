namespace SimESPOL
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAlpha = new TextBox();
            txtBeta = new TextBox();
            txtN = new TextBox();
            txtResultado = new TextBox();
            btnComputar = new Button();
            pb = new PictureBox();
            btnComputar2 = new Button();
            btnComputar3 = new Button();
            label6 = new Label();
            btnPI = new Button();
            label7 = new Label();
            txtEstimacion = new TextBox();
            btnJuegoDados = new Button();
            btnE = new Button();
            btnProbCondicional = new Button();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Location = new Point(90, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 15);
            label1.TabIndex = 0;
            label1.Text = "Estimación de Integral por Simulación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 45);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 1;
            label2.Text = "Alpha (Límite Inferior)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 82);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 2;
            label3.Text = "Beta (Límite Superior)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 122);
            label4.Name = "label4";
            label4.Size = new Size(177, 15);
            label4.TabIndex = 4;
            label4.Text = "Número de puntos (Simulación)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 256);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 6;
            label5.Text = "Resultado";
            // 
            // txtAlpha
            // 
            txtAlpha.Location = new Point(257, 42);
            txtAlpha.Name = "txtAlpha";
            txtAlpha.Size = new Size(100, 23);
            txtAlpha.TabIndex = 7;
            // 
            // txtBeta
            // 
            txtBeta.Location = new Point(257, 78);
            txtBeta.Name = "txtBeta";
            txtBeta.Size = new Size(100, 23);
            txtBeta.TabIndex = 9;
            // 
            // txtN
            // 
            txtN.Location = new Point(257, 117);
            txtN.Name = "txtN";
            txtN.Size = new Size(100, 23);
            txtN.TabIndex = 11;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(257, 251);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 13;
            // 
            // btnComputar
            // 
            btnComputar.BackColor = Color.FromArgb(128, 128, 255);
            btnComputar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComputar.ForeColor = Color.White;
            btnComputar.Location = new Point(37, 153);
            btnComputar.Name = "btnComputar";
            btnComputar.Size = new Size(320, 23);
            btnComputar.TabIndex = 14;
            btnComputar.Text = "Computar";
            btnComputar.UseVisualStyleBackColor = false;
            btnComputar.Click += btnComputar_Click;
            // 
            // pb
            // 
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Location = new Point(404, 26);
            pb.Name = "pb";
            pb.Size = new Size(384, 240);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.TabIndex = 15;
            pb.TabStop = false;
            // 
            // btnComputar2
            // 
            btnComputar2.BackColor = Color.FromArgb(128, 128, 255);
            btnComputar2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComputar2.ForeColor = Color.White;
            btnComputar2.Location = new Point(37, 182);
            btnComputar2.Name = "btnComputar2";
            btnComputar2.Size = new Size(320, 23);
            btnComputar2.TabIndex = 16;
            btnComputar2.Text = "Computar BBS";
            btnComputar2.UseVisualStyleBackColor = false;
            btnComputar2.Click += btnComputar2_Click;
            // 
            // btnComputar3
            // 
            btnComputar3.BackColor = Color.FromArgb(128, 128, 255);
            btnComputar3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComputar3.ForeColor = Color.White;
            btnComputar3.Location = new Point(37, 211);
            btnComputar3.Name = "btnComputar3";
            btnComputar3.Size = new Size(320, 23);
            btnComputar3.TabIndex = 17;
            btnComputar3.Text = "Computar XORShift";
            btnComputar3.UseVisualStyleBackColor = false;
            btnComputar3.Click += btnComputar3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 297);
            label6.Name = "label6";
            label6.Size = new Size(204, 15);
            label6.TabIndex = 18;
            label6.Text = "Estimación de constantes irracionales";
            label6.Click += label6_Click;
            // 
            // btnPI
            // 
            btnPI.BackColor = Color.FromArgb(0, 192, 0);
            btnPI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPI.ForeColor = Color.White;
            btnPI.Location = new Point(37, 328);
            btnPI.Name = "btnPI";
            btnPI.Size = new Size(320, 32);
            btnPI.TabIndex = 19;
            btnPI.Text = "Estimación de pi por simulación";
            btnPI.UseVisualStyleBackColor = false;
            btnPI.Click += btnPI_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 491);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 20;
            label7.Text = "Estimación";
            label7.Click += label7_Click;
            // 
            // txtEstimacion
            // 
            txtEstimacion.Location = new Point(257, 488);
            txtEstimacion.Name = "txtEstimacion";
            txtEstimacion.Size = new Size(100, 23);
            txtEstimacion.TabIndex = 21;
            // 
            // btnJuegoDados
            // 
            btnJuegoDados.BackColor = Color.FromArgb(0, 192, 0);
            btnJuegoDados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJuegoDados.ForeColor = Color.White;
            btnJuegoDados.Location = new Point(37, 366);
            btnJuegoDados.Name = "btnJuegoDados";
            btnJuegoDados.Size = new Size(320, 32);
            btnJuegoDados.TabIndex = 22;
            btnJuegoDados.Text = "Juego de los Dados";
            btnJuegoDados.UseVisualStyleBackColor = false;
            btnJuegoDados.Click += btnJuegoDados_Click;
            // 
            // btnE
            // 
            btnE.BackColor = Color.FromArgb(0, 192, 0);
            btnE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnE.ForeColor = Color.White;
            btnE.Location = new Point(37, 404);
            btnE.Name = "btnE";
            btnE.Size = new Size(320, 32);
            btnE.TabIndex = 23;
            btnE.Text = "Estimación de \"e\" por simulación";
            btnE.UseVisualStyleBackColor = false;
            btnE.Click += btnE_Click;
            // 
            // btnProbCondicional
            // 
            btnProbCondicional.BackColor = Color.FromArgb(0, 192, 0);
            btnProbCondicional.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProbCondicional.ForeColor = Color.White;
            btnProbCondicional.Location = new Point(37, 442);
            btnProbCondicional.Name = "btnProbCondicional";
            btnProbCondicional.Size = new Size(320, 32);
            btnProbCondicional.TabIndex = 24;
            btnProbCondicional.Text = "Estimación de Probabilidad Condicional";
            btnProbCondicional.UseVisualStyleBackColor = false;
            btnProbCondicional.Click += btnProbCondicional_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(btnProbCondicional);
            Controls.Add(btnE);
            Controls.Add(btnJuegoDados);
            Controls.Add(txtEstimacion);
            Controls.Add(label7);
            Controls.Add(btnPI);
            Controls.Add(label6);
            Controls.Add(btnComputar3);
            Controls.Add(btnComputar2);
            Controls.Add(pb);
            Controls.Add(btnComputar);
            Controls.Add(txtResultado);
            Controls.Add(txtN);
            Controls.Add(txtBeta);
            Controls.Add(txtAlpha);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAlpha;
        private TextBox txtBeta;
        private TextBox txtN;
        private TextBox txtResultado;
        private Button btnComputar;
        private PictureBox pb;
        private Button btnComputar2;
        private Button btnComputar3;
        private Label label6;
        private Button btnPI;
        private Label label7;
        private TextBox txtEstimacion;
        private Button btnJuegoDados;
        private Button btnE;
        private Button btnProbCondicional;
    }
}

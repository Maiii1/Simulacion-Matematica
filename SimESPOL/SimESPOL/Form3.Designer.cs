namespace SimESPOL
{
    partial class Form3
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
            lblLambda = new Label();
            txtLambdaExp = new TextBox();
            btnGenerarExp = new Button();
            lstMuestraExp = new ListBox();
            lblCota = new Label();
            lblMuestra = new Label();
            txtMuestraExp = new TextBox();
            txtCotaExp = new TextBox();
            lblMediaExp = new Label();
            SuspendLayout();
            // 
            // lblLambda
            // 
            lblLambda.AutoSize = true;
            lblLambda.Location = new Point(83, 37);
            lblLambda.Name = "lblLambda";
            lblLambda.Size = new Size(50, 15);
            lblLambda.TabIndex = 0;
            lblLambda.Text = "Lambda";
            lblLambda.Click += label1_Click;
            // 
            // txtLambdaExp
            // 
            txtLambdaExp.Location = new Point(227, 31);
            txtLambdaExp.Name = "txtLambdaExp";
            txtLambdaExp.Size = new Size(100, 23);
            txtLambdaExp.TabIndex = 1;
            // 
            // btnGenerarExp
            // 
            btnGenerarExp.Location = new Point(103, 171);
            btnGenerarExp.Name = "btnGenerarExp";
            btnGenerarExp.Size = new Size(173, 23);
            btnGenerarExp.TabIndex = 2;
            btnGenerarExp.Text = "Generar Exponencial";
            btnGenerarExp.UseVisualStyleBackColor = true;
            btnGenerarExp.Click += btnGenerarExp_Click;
            // 
            // lstMuestraExp
            // 
            lstMuestraExp.FormattingEnabled = true;
            lstMuestraExp.Location = new Point(410, 25);
            lstMuestraExp.Name = "lstMuestraExp";
            lstMuestraExp.Size = new Size(210, 169);
            lstMuestraExp.TabIndex = 3;
            lstMuestraExp.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblCota
            // 
            lblCota.AutoSize = true;
            lblCota.Location = new Point(80, 72);
            lblCota.Name = "lblCota";
            lblCota.Size = new Size(79, 15);
            lblCota.TabIndex = 4;
            lblCota.Text = "Cota Superior";
            // 
            // lblMuestra
            // 
            lblMuestra.AutoSize = true;
            lblMuestra.Location = new Point(80, 105);
            lblMuestra.Name = "lblMuestra";
            lblMuestra.Size = new Size(112, 15);
            lblMuestra.TabIndex = 5;
            lblMuestra.Text = "Tamaño de muestra";
            // 
            // txtMuestraExp
            // 
            txtMuestraExp.Location = new Point(227, 105);
            txtMuestraExp.Name = "txtMuestraExp";
            txtMuestraExp.Size = new Size(100, 23);
            txtMuestraExp.TabIndex = 6;
            // 
            // txtCotaExp
            // 
            txtCotaExp.Location = new Point(227, 70);
            txtCotaExp.Name = "txtCotaExp";
            txtCotaExp.Size = new Size(100, 23);
            txtCotaExp.TabIndex = 7;
            // 
            // lblMediaExp
            // 
            lblMediaExp.AutoSize = true;
            lblMediaExp.Location = new Point(412, 204);
            lblMediaExp.Name = "lblMediaExp";
            lblMediaExp.Size = new Size(91, 15);
            lblMediaExp.TabIndex = 8;
            lblMediaExp.Text = "Media estimada";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 496);
            Controls.Add(lblMediaExp);
            Controls.Add(txtCotaExp);
            Controls.Add(txtMuestraExp);
            Controls.Add(lblMuestra);
            Controls.Add(lblCota);
            Controls.Add(lstMuestraExp);
            Controls.Add(btnGenerarExp);
            Controls.Add(txtLambdaExp);
            Controls.Add(lblLambda);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLambda;
        private TextBox txtLambdaExp;
        private Button btnGenerarExp;
        private ListBox lstMuestraExp;
        private Label lblCota;
        private Label lblMuestra;
        private TextBox txtMuestraExp;
        private TextBox txtCotaExp;
        private Label lblMediaExp;
    }
}

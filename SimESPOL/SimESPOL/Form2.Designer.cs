namespace WindowsFormsApp1;

partial class Form2
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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        btnGenerar = new Button();
        txtmedia = new TextBox();
        txtvar = new TextBox();
        txtmuestra = new TextBox();
        ListaMuestra = new ListBox();
        groupBox1 = new GroupBox();
        lstMuestraDiscreta = new ListBox();
        btnGenerarDiscreta = new Button();
        Panel3 = new GroupBox();
        lstMuestraPoisson = new ListBox();
        btnGenerarPoisson = new Button();
        txtLambda = new TextBox();
        label5 = new Label();
        Panel3.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(5, 25);
        label1.Name = "label1";
        label1.Size = new Size(108, 15);
        label1.TabIndex = 0;
        label1.Text = "Datos de la Normal";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(45, 72);
        label2.Name = "label2";
        label2.Size = new Size(40, 15);
        label2.TabIndex = 1;
        label2.Text = "Media";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(45, 120);
        label3.Name = "label3";
        label3.Size = new Size(50, 15);
        label3.TabIndex = 2;
        label3.Text = "Varianza";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(0, 164);
        label4.Name = "label4";
        label4.Size = new Size(124, 15);
        label4.TabIndex = 3;
        label4.Text = "Tamaño de la Muestra";
        // 
        // btnGenerar
        // 
        btnGenerar.BackColor = Color.Pink;
        btnGenerar.Location = new Point(5, 211);
        btnGenerar.Name = "btnGenerar";
        btnGenerar.Size = new Size(223, 26);
        btnGenerar.TabIndex = 4;
        btnGenerar.Text = "Generar";
        btnGenerar.UseVisualStyleBackColor = false;
        btnGenerar.Click += btnGenerar_Click;
        // 
        // txtmedia
        // 
        txtmedia.Location = new Point(128, 68);
        txtmedia.Name = "txtmedia";
        txtmedia.Size = new Size(100, 23);
        txtmedia.TabIndex = 5;
        // 
        // txtvar
        // 
        txtvar.Location = new Point(128, 115);
        txtvar.Name = "txtvar";
        txtvar.Size = new Size(100, 23);
        txtvar.TabIndex = 6;
        // 
        // txtmuestra
        // 
        txtmuestra.Location = new Point(128, 159);
        txtmuestra.Name = "txtmuestra";
        txtmuestra.Size = new Size(100, 23);
        txtmuestra.TabIndex = 7;
        // 
        // ListaMuestra
        // 
        ListaMuestra.FormattingEnabled = true;
        ListaMuestra.Location = new Point(257, 68);
        ListaMuestra.Name = "ListaMuestra";
        ListaMuestra.Size = new Size(208, 169);
        ListaMuestra.TabIndex = 8;
        // 
        // groupBox1
        // 
        groupBox1.Location = new Point(494, 45);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(304, 22);
        groupBox1.TabIndex = 9;
        groupBox1.TabStop = false;
        groupBox1.Text = "Aceptación y Rechazo (Discreta con Soporte Finito)";
        // 
        // lstMuestraDiscreta
        // 
        lstMuestraDiscreta.FormattingEnabled = true;
        lstMuestraDiscreta.Location = new Point(495, 95);
        lstMuestraDiscreta.Name = "lstMuestraDiscreta";
        lstMuestraDiscreta.Size = new Size(199, 109);
        lstMuestraDiscreta.TabIndex = 10;
        // 
        // btnGenerarDiscreta
        // 
        btnGenerarDiscreta.BackColor = Color.Pink;
        btnGenerarDiscreta.Location = new Point(494, 65);
        btnGenerarDiscreta.Name = "btnGenerarDiscreta";
        btnGenerarDiscreta.Size = new Size(200, 24);
        btnGenerarDiscreta.TabIndex = 11;
        btnGenerarDiscreta.Text = "Generar Discreta";
        btnGenerarDiscreta.UseVisualStyleBackColor = false;
        btnGenerarDiscreta.Click += btnGenerarDiscreta_Click;
        // 
        // Panel3
        // 
        Panel3.Controls.Add(lstMuestraPoisson);
        Panel3.Controls.Add(btnGenerarPoisson);
        Panel3.Controls.Add(txtLambda);
        Panel3.Controls.Add(label5);
        Panel3.Location = new Point(495, 219);
        Panel3.Name = "Panel3";
        Panel3.Size = new Size(429, 128);
        Panel3.TabIndex = 12;
        Panel3.TabStop = false;
        Panel3.Text = "Aceptacion y Rechazo (Poisson)";
        // 
        // lstMuestraPoisson
        // 
        lstMuestraPoisson.FormattingEnabled = true;
        lstMuestraPoisson.Location = new Point(240, 6);
        lstMuestraPoisson.Name = "lstMuestraPoisson";
        lstMuestraPoisson.Size = new Size(170, 109);
        lstMuestraPoisson.TabIndex = 3;
        // 
        // btnGenerarPoisson
        // 
        btnGenerarPoisson.BackColor = Color.Pink;
        btnGenerarPoisson.Location = new Point(6, 79);
        btnGenerarPoisson.Name = "btnGenerarPoisson";
        btnGenerarPoisson.Size = new Size(193, 23);
        btnGenerarPoisson.TabIndex = 2;
        btnGenerarPoisson.Text = "Generar Poisson";
        btnGenerarPoisson.UseVisualStyleBackColor = false;
        btnGenerarPoisson.Click += btnGenerarPoisson_Click;
        // 
        // txtLambda
        // 
        txtLambda.Location = new Point(94, 39);
        txtLambda.Name = "txtLambda";
        txtLambda.Size = new Size(100, 23);
        txtLambda.TabIndex = 1;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(2, 43);
        label5.Name = "label5";
        label5.Size = new Size(50, 15);
        label5.TabIndex = 0;
        label5.Text = "Lambda";
        // 
        // Form2
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(927, 359);
        Controls.Add(Panel3);
        Controls.Add(btnGenerarDiscreta);
        Controls.Add(lstMuestraDiscreta);
        Controls.Add(groupBox1);
        Controls.Add(ListaMuestra);
        Controls.Add(txtmuestra);
        Controls.Add(txtvar);
        Controls.Add(txtmedia);
        Controls.Add(btnGenerar);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form2";
        Text = "Form2";
        Load += Form2_Load;
        Panel3.ResumeLayout(false);
        Panel3.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Button btnGenerar;
    private TextBox txtmedia;
    private TextBox txtvar;
    private TextBox txtmuestra;
    private ListBox ListaMuestra;
    private GroupBox groupBox1;
    private ListBox lstMuestraDiscreta;
    private Button btnGenerarDiscreta;
    private GroupBox Panel3;
    private Button btnGenerarPoisson;
    private TextBox txtLambda;
    private Label label5;
    private ListBox lstMuestraPoisson;
}
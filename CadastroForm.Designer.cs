namespace Museu13._05
{
    partial class CadastroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroForm));
            cmbFaixaEtaria = new ComboBox();
            btnCadastrar = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbFaixaEtaria
            // 
            cmbFaixaEtaria.BackColor = Color.SkyBlue;
            cmbFaixaEtaria.Font = new Font("Georgia", 14.25F);
            cmbFaixaEtaria.FormattingEnabled = true;
            cmbFaixaEtaria.Items.AddRange(new object[] { "0-12 ", "13-17 ", "18-64 ", "65+" });
            cmbFaixaEtaria.Location = new Point(37, 389);
            cmbFaixaEtaria.Name = "cmbFaixaEtaria";
            cmbFaixaEtaria.Size = new Size(271, 31);
            cmbFaixaEtaria.TabIndex = 2;
            cmbFaixaEtaria.Text = "Selecione sua idade";
            cmbFaixaEtaria.SelectedIndexChanged += cmbFaixaEtaria_SelectedIndexChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadastrar.BackColor = SystemColors.Highlight;
            btnCadastrar.Font = new Font("Georgia", 14.25F);
            btnCadastrar.ForeColor = SystemColors.ControlLightLight;
            btnCadastrar.Location = new Point(104, 456);
            btnCadastrar.Margin = new Padding(2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(121, 37);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Continuar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.SkyBlue;
            txtNome.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(37, 309);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(271, 29);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F);
            label1.Location = new Point(50, 32);
            label1.Name = "label1";
            label1.Size = new Size(245, 29);
            label1.TabIndex = 3;
            label1.Text = "Bem vindo ao Museu!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 15.75F);
            label2.Location = new Point(35, 361);
            label2.Name = "label2";
            label2.Size = new Size(269, 25);
            label2.TabIndex = 4;
            label2.Text = "Selecione a sua faixa etária:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 15.75F);
            label3.Location = new Point(37, 281);
            label3.Name = "label3";
            label3.Size = new Size(234, 25);
            label3.TabIndex = 5;
            label3.Text = "Insira seu nome abaixo:";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(333, 588);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(btnCadastrar);
            Controls.Add(cmbFaixaEtaria);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFaixaEtaria;
        private Button btnCadastrar;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}

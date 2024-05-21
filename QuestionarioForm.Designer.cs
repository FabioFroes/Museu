namespace Museuuuuuuu
{
    partial class QuestionarioForm
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
            cmbSatisfacao = new ComboBox();
            cmbArea = new ComboBox();
            cmbMotivo = new ComboBox();
            cmbSugestoes = new ComboBox();
            cmbInformacoes = new ComboBox();
            btnEnviar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRelatorio = new Button();
            lblNome = new Label();
            SuspendLayout();
            // 
            // cmbSatisfacao
            // 
            cmbSatisfacao.BackColor = Color.SkyBlue;
            cmbSatisfacao.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSatisfacao.ForeColor = SystemColors.InactiveCaptionText;
            cmbSatisfacao.FormattingEnabled = true;
            cmbSatisfacao.Items.AddRange(new object[] { "A - Insatisfeito", "B - Regular", "C - Satisfeito", "D - Muito Satisfeito" });
            cmbSatisfacao.Location = new Point(116, 111);
            cmbSatisfacao.Name = "cmbSatisfacao";
            cmbSatisfacao.Size = new Size(564, 24);
            cmbSatisfacao.TabIndex = 0;
            cmbSatisfacao.Text = "Resposta";
            cmbSatisfacao.SelectedIndexChanged += cmbSatisfacao_SelectedIndexChanged;
            // 
            // cmbArea
            // 
            cmbArea.BackColor = Color.SkyBlue;
            cmbArea.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbArea.ForeColor = SystemColors.Desktop;
            cmbArea.FormattingEnabled = true;
            cmbArea.Items.AddRange(new object[] { "A - Exposições", "B - Estruturas", "C - Espaço de pesquisa", "D - Salas comerciais " });
            cmbArea.Location = new Point(116, 177);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(564, 24);
            cmbArea.TabIndex = 1;
            cmbArea.Text = "Resposta";
            // 
            // cmbMotivo
            // 
            cmbMotivo.BackColor = Color.SkyBlue;
            cmbMotivo.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMotivo.FormattingEnabled = true;
            cmbMotivo.Items.AddRange(new object[] { "A - Explorar", "B - Aprender", "C - Convite", "D - Inspirar" });
            cmbMotivo.Location = new Point(116, 241);
            cmbMotivo.Name = "cmbMotivo";
            cmbMotivo.Size = new Size(564, 24);
            cmbMotivo.TabIndex = 2;
            cmbMotivo.Text = "Resposta";
            // 
            // cmbSugestoes
            // 
            cmbSugestoes.BackColor = Color.SkyBlue;
            cmbSugestoes.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSugestoes.FormattingEnabled = true;
            cmbSugestoes.Items.AddRange(new object[] { "A - Interatividade\t", "B - Sinalização", "C - Acessibilidade", "D - Engajamento" });
            cmbSugestoes.Location = new Point(116, 308);
            cmbSugestoes.Name = "cmbSugestoes";
            cmbSugestoes.Size = new Size(564, 24);
            cmbSugestoes.TabIndex = 3;
            cmbSugestoes.Text = "Resposta";
            // 
            // cmbInformacoes
            // 
            cmbInformacoes.BackColor = Color.SkyBlue;
            cmbInformacoes.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbInformacoes.FormattingEnabled = true;
            cmbInformacoes.Items.AddRange(new object[] { "A - Poucas informaçoes", "B - Compreensivel", "C - Detalhada", "D - Ótimo" });
            cmbInformacoes.Location = new Point(116, 377);
            cmbInformacoes.Name = "cmbInformacoes";
            cmbInformacoes.Size = new Size(564, 24);
            cmbInformacoes.TabIndex = 4;
            cmbInformacoes.Text = "Resposta";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = SystemColors.Highlight;
            btnEnviar.Font = new Font("Georgia", 12F);
            btnEnviar.ForeColor = SystemColors.ButtonHighlight;
            btnEnviar.Location = new Point(539, 480);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(141, 34);
            btnEnviar.TabIndex = 5;
            btnEnviar.Text = "Salvar resposta ";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Azure;
            label1.Font = new Font("Georgia", 12F);
            label1.Location = new Point(116, 90);
            label1.Name = "label1";
            label1.Size = new Size(363, 18);
            label1.TabIndex = 6;
            label1.Text = "Qual a sua satisfação com a experiência do museu?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F);
            label2.Location = new Point(116, 156);
            label2.Name = "label2";
            label2.Size = new Size(407, 18);
            label2.TabIndex = 7;
            label2.Text = "Qual área do museu você mais apreciou durante a visita?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F);
            label3.Location = new Point(116, 220);
            label3.Name = "label3";
            label3.Size = new Size(362, 18);
            label3.TabIndex = 8;
            label3.Text = "Qual foi o principal motivo da sua visita ao museu?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F);
            label4.Location = new Point(116, 287);
            label4.Name = "label4";
            label4.Size = new Size(564, 18);
            label4.TabIndex = 9;
            label4.Text = "Que sugestões você teria para melhorar a experiência dos visitantes do museu?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F);
            label5.Location = new Point(116, 356);
            label5.Name = "label5";
            label5.Size = new Size(502, 18);
            label5.TabIndex = 10;
            label5.Text = "As informações fornecidas nas exposições foram claras e informativas?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(95, 38);
            label6.Name = "label6";
            label6.Size = new Size(609, 29);
            label6.TabIndex = 11;
            label6.Text = "Sua opinião importa! Participe da nossa pesquisa rápida";
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = SystemColors.Highlight;
            btnRelatorio.Font = new Font("Georgia", 12F);
            btnRelatorio.ForeColor = SystemColors.ButtonHighlight;
            btnRelatorio.Location = new Point(116, 480);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(156, 34);
            btnRelatorio.TabIndex = 12;
            btnRelatorio.Text = "Visualizar relatorio";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Georgia", 12F);
            lblNome.Location = new Point(12, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(49, 18);
            lblNome.TabIndex = 13;
            lblNome.Text = "label7";
            // 
            // QuestionarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(812, 575);
            Controls.Add(lblNome);
            Controls.Add(btnRelatorio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEnviar);
            Controls.Add(cmbInformacoes);
            Controls.Add(cmbSugestoes);
            Controls.Add(cmbMotivo);
            Controls.Add(cmbArea);
            Controls.Add(cmbSatisfacao);
            Name = "QuestionarioForm";
            Text = "QuestionarioForm";
            Load += QuestionarioForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSatisfacao;
        private ComboBox cmbArea;
        private ComboBox cmbMotivo;
        private ComboBox cmbSugestoes;
        private ComboBox cmbInformacoes;
        private Button btnEnviar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRelatorio;
        private Label lblNome;
    }
}
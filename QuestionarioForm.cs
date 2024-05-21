
using Museu13._05;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste;
using static System.Windows.Forms.DataFormats;





namespace Museuuuuuuu
{


    public partial class QuestionarioForm : Form
    {
        private string[] respostasPerguntas = new string[5];
        private int respostasPerguntasIndex = 0;
        private Dictionary<string, Dictionary<string, int>> respostasQuestionario = new Dictionary<string, Dictionary<string, int>>();
        private string nome;
        private string faixaEtaria;
        private List<Dictionary<string, Dictionary<string, int>>> questionarios = new List<Dictionary<string, Dictionary<string, int>>>();
        private List<string> nomes = new List<string>();
        private List<string> faixaEtarias = new List<string>();


        public QuestionarioForm(string nome, string faixaEtaria)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(550, 50);
            InitializeComponent();
            QuestionarioController.QuestionariosAbertos.Add(this);
            AtualizarDados(nome, faixaEtaria);

        }

        public void AtualizarDados(string nome, string faixaEtaria)
        {
            this.nome = nome;
            this.faixaEtaria = faixaEtaria;
            lblNome.Text = $"Nome: {nome}";
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ValidacaoQuestionario validacaoQuestionario = new ValidacaoQuestionario();
            bool respostasValidas = validacaoQuestionario.ValidarRespostas(cmbSatisfacao, cmbInformacoes, cmbSugestoes, cmbMotivo, cmbArea);

            if (respostasValidas)
            {
                AdicionarRespostas();

                questionarios.Add(respostasQuestionario);

                LimparRespostas();

                MessageBox.Show("Agradecemos a sua participação!", "Resposta salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CadastroForm cadastroForm   = new CadastroForm();
                this.Hide();
                cadastroForm.Show();
                this.Show();
                cadastroForm.BringToFront();


            }
        }

        private void AdicionarRespostas()
        {
            Array.Resize(ref respostasPerguntas, respostasPerguntasIndex + 5);

            int index = respostasPerguntasIndex;

            respostasPerguntas[index++] = $"1) Satisfação: {cmbSatisfacao.SelectedItem?.ToString()}";
            respostasPerguntas[index++] = $"2) Área: {cmbArea.SelectedItem?.ToString()}";
            respostasPerguntas[index++] = $"3) Motivo: {cmbMotivo.SelectedItem?.ToString()}";
            respostasPerguntas[index++] = $"4) Sugestões: {cmbSugestoes.SelectedItem?.ToString()}";
            respostasPerguntas[index++] = $"5) Informações: {cmbInformacoes.SelectedItem?.ToString()}";

            for (int i = respostasPerguntasIndex; i < index; i++)
            {
                AdicionarResposta(respostasPerguntas[i]);
            }

            faixaEtarias.Add(faixaEtaria);
            nomes.Add(nome);
            respostasPerguntasIndex = index;
        }


        private void AdicionarResposta(string resposta)
        {
            if (!string.IsNullOrEmpty(resposta))
            {
                string[] partesResposta = resposta.Split(':');
                if (partesResposta.Length != 2) return; 
                string pergunta = partesResposta[0].Trim();
                string respostaTexto = partesResposta[1].Trim();

               
                if (!respostasQuestionario.ContainsKey(pergunta))
                {
                    respostasQuestionario[pergunta] = new Dictionary<string, int>();
                }

                if (!respostasQuestionario[pergunta].ContainsKey(respostaTexto))
                {
                    respostasQuestionario[pergunta][respostaTexto] = 0;
                }


                respostasQuestionario[pergunta][respostaTexto]++;
            }
        }


        private void LimparRespostas()
        {
            cmbSatisfacao.SelectedIndex = -1;
            cmbArea.SelectedIndex = -1;
            cmbMotivo.SelectedIndex = -1;
            cmbSugestoes.SelectedIndex = -1;
            cmbInformacoes.SelectedIndex = -1;
            respostasPerguntasIndex = 0;
            Array.Resize(ref respostasPerguntas, 5);
        }

        public string GerarRelatorio(List<Dictionary<string, Dictionary<string, int>>> questionarios, List<string> nomes)
        {
            StringBuilder relatorio = new StringBuilder();

            for (int i = 0; i < questionarios.Count; i++)
            {
                var questionario = questionarios[i];

               
                string nome = nomes[i];
                string faixaEtaria = faixaEtarias[i];
                relatorio.AppendLine($"Nome: {nome}");
                relatorio.AppendLine($"Faixa Etária: {faixaEtaria}");
                relatorio.AppendLine();

                foreach (KeyValuePair<string, Dictionary<string, int>> pergunta in questionario)
                {
                    relatorio.AppendLine($"{pergunta.Key}:");

                    int somaRespostas = 0;
                    int totalRespostas = 0;

                    foreach (KeyValuePair<string, int> resposta in pergunta.Value)
                    {
                        relatorio.AppendLine($"    {resposta.Key}: {resposta.Value}");
                        somaRespostas += resposta.Value;
                        totalRespostas++;
                    }

                    double mediaRespostas = totalRespostas > 0 ? (double)somaRespostas / totalRespostas : 0;
                    relatorio.AppendLine($"    Média das respostas: {mediaRespostas:F2}");
                }
                relatorio.AppendLine();
                relatorio.AppendLine("============================"); 
                relatorio.AppendLine();

            }

            return relatorio.ToString();
        }



        private void cmbSatisfacao_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            string relatorio = GerarRelatorio(questionarios, nomes); // Pass the list of names
            MessageBox.Show(relatorio, "Relatório de Respostas");
        }


        private void QuestionarioForm_Load(object sender, EventArgs e)
        {

        }
    }
}
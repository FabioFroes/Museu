using Museuuuuuuu;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.Intrinsics.X86;
using teste;

namespace Museu13._05
{
    public partial class CadastroForm : Form
    {

        
        public string Nome { get; private set; }
        public string FaixaEtaria { get; private set; }
        private CadastroController cadastroController;
        private Form1 form1;


            
        public CadastroForm()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(550, 50);
            InitializeComponent();
            cadastroController = new CadastroController();
            InitializeForm1(); 
        }

        private void InitializeForm1()
        {

            form1 = new Form1(this); 
            form1.Show(this);

        }


        public void ReceiveKeyInput(string key)
        {
            
            SendKeys.Send(key);
            txtNome.Text += key;

        }


        private void btnCadastrar_Click(object sender, EventArgs e)

        {
            string nome = txtNome.Text;
            string faixaEtaria = cmbFaixaEtaria.SelectedItem?.ToString();

            Validacao validacao = new Validacao();
            bool validarCadastro = validacao.ValidarCadastro(nome, faixaEtaria);
            if (!validarCadastro)
            {

                return;
            }


            bool cadastradoComSucesso = cadastroController.Cadastrar(nome, faixaEtaria);


            if (cadastradoComSucesso)
            {

                Nome = nome;
                FaixaEtaria = faixaEtaria;
                MessageBox.Show("Cadastro realizado com sucesso!");
                this.Hide();


                if (Application.OpenForms.OfType<QuestionarioForm>().Count() == 0)
                {
                    QuestionarioForm questionarioForm = new QuestionarioForm(nome, faixaEtaria);
                    questionarioForm.Show();
                }
                else
                {

                    QuestionarioForm questionarioForm = Application.OpenForms.OfType<QuestionarioForm>().First();
                    questionarioForm.AtualizarDados(nome, faixaEtaria);


                }
            }

            LimparCampos();
        }


        private void LimparCampos()
        {
            txtNome.Text = "";
            cmbFaixaEtaria.SelectedIndex = -1;
        }

        private void cmbFaixaEtaria_SelectedIndexChanged(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click_1(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

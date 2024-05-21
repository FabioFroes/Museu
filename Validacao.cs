using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Museuuuuuuu
{ 

    public class Validacao
{
        private List<string> erroCadastro = new List<string>();


        public bool ValidarCadastro(string nome, string faixaEtaria)
    {
        
        if (!string.IsNullOrEmpty(nome) && ContemApenasLetras(nome) && !string.IsNullOrEmpty(faixaEtaria))
        {
            return true; 
        }
        else
        {

                erroCadastro.Add($"Por favor, insira apenas letras no campo NOME, símbolos e números não são permitidos!\n\nPor favor, selecione uma faixa etária válida na lista!");
                string mensagem = string.Join("\n", erroCadastro);
                MessageBox.Show(mensagem, "Erro ao realizar o cadastro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
        }
    }

    private bool ContemApenasLetras(string input)

    {

      
        Regex regex = new Regex("^[a-zA-Z]+$");
        return regex.IsMatch(input);
         
        }
}

}

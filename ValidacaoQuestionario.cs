using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museuuuuuuu
{   

    public class ValidacaoQuestionario
    {
        public bool ValidarRespostas(ComboBox cmbSatisfacao, ComboBox cmbInformacoes, ComboBox cmbSugestoes, ComboBox cmbMotivo, ComboBox cmbArea)
        {
           
            if (cmbSatisfacao.SelectedIndex != -1 &&
                cmbInformacoes.SelectedIndex != -1 &&
                cmbSugestoes.SelectedIndex != -1 &&
                cmbMotivo.SelectedIndex != -1 &&
                cmbArea.SelectedIndex != -1)
            {
                return true; 
            }
            else
            {
                MessageBox.Show("Por favor, responda a todas as perguntas antes de salvar as respostas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
        }
    }

}

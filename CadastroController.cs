using Museuuuuuuu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu13._05
{


        public class CadastroController
        {
            private string[] nomes;
            private string[] faixasEtarias;
            private string[,] cadastros; 
            public int indice;


        public CadastroController()
            {
                nomes = new string[100];
                faixasEtarias = new string[100];
                cadastros = new string[100, 2]; 
                indice = 0;
            }

            public bool Cadastrar(string nome, string faixaEtaria)
            {
                if (indice < 100)
                {
                    nomes[indice] = nome;
                    faixasEtarias[indice] = faixaEtaria;
                    cadastros[indice, 0] = nome;
                    cadastros[indice, 1] = faixaEtaria; 
                    indice++;
                    return true;
                }
                else
                {
                MessageBox.Show("Limite de cadastros atingido!" );
                    return false;
                }
            }

            public string[,] ObterCadastros()
            {
                return cadastros;
            }
        }
    }

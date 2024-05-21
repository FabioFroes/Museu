using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museuuuuuuu
{
   
        public class QuestionarioController
        {
        public static List<QuestionarioForm> QuestionariosAbertos { get; } = new List<QuestionarioForm>();

        public List<string> RespostasSatisfacao { get; } = new List<string> { "Insatisfeito", "Regular", "Satisfeito", "Muito satisfeito" };
            public List<string> RespostasArea { get; } = new List<string> { "Exposições", "Estrutura", "Espaço de pesquisa", "Salas comerciais" };
            public List<string> RespostasMotivo { get; } = new List<string> { "Explorar", "Aprender", "Convite", "Inspiração" };
            public List<string> RespostasSugestoes { get; } = new List<string> { "Interatividade", "Sinalização", "Acessibilidade", "Engajamento" };
            public List<string> RespostasInformacoes { get; } = new List<string> { "Razoável", "Compreensível", "Detalhada", "Ótimo" };

            private Dictionary<string, Dictionary<string, int>> respostasQuestionario = new Dictionary<string, Dictionary<string, int>>();

            public void AdicionarResposta(string pergunta, string resposta)
            {
                if (!respostasQuestionario.ContainsKey(pergunta))
                {
                    respostasQuestionario[pergunta] = new Dictionary<string, int>();
                }

                if (respostasQuestionario[pergunta].ContainsKey(resposta))
                {
                    respostasQuestionario[pergunta][resposta]++;
                }
                else
                {
                    respostasQuestionario[pergunta][resposta] = 1;
                }
            }

            public Dictionary<string, Dictionary<string, int>> ObterRespostasQuestionario()
            {
                return respostasQuestionario;
            }

            public void LimparQuestionario()
            {
                respostasQuestionario.Clear();
            }

        }
    }

using System;
using System.Collections.Generic;

namespace Projeto_pratico___Duvida_e_resposta
{
    public class Menu : Email
    {
        public static List<Duvida> ListaDuvida = new List<Duvida>();
        public static List<Resposta> ListaResposta = new List<Resposta>();
        int identificador = 1;
        public void AddALuno()
        {
            Duvida DuvidaAluno = new Duvida();
            Console.WriteLine("Envie uma dúvida para o seu professor");
            DuvidaAluno.Conteudo = Console.ReadLine();
            DuvidaAluno.ID = identificador++;
            ListaDuvida.Add(DuvidaAluno);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("E-mail enviado... Aperte em qualquer tecla para continuar");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
            Console.Clear();
        }
        public void ExibirEmails()
        {   
            Duvida DuvidaAluno = new Duvida();
            if(ListaDuvida.Count > 0)
            {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------EXIBINDO E-MAILS------------------");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var duvidaA in ListaDuvida)
            {
              Console.WriteLine(duvidaA.Exibir());
            }
            foreach (var respostaA in ListaResposta)
            {
              Console.WriteLine(respostaA.Exibir(DuvidaAluno));
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Aperte em qualquer tecla para continuar");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
            } 
            else
            {
              Console.ForegroundColor = ConsoleColor.Blue;
              Console.WriteLine("Não há emails, aperte em qualquer tecla para continuar");
              Console.ForegroundColor = ConsoleColor.White;
              Console.ReadKey();
            }
        }
        public void VerDuvidas()
        {
            foreach (var email in ListaDuvida)
            {
                Console.WriteLine(email.Exibir());
            }
        }
        public void AddResposta()
        {
           if(ListaDuvida.Count > 0)
           {
            Duvida DuvidaPergunta = new Duvida();
            Resposta RespostaPergunta = new Resposta();
            Console.WriteLine("Informe o número de identificação do E-mail e envie uma resposta para seu aluno");
            RespostaPergunta.Identificacao = int.Parse(Console.ReadLine());
            
            foreach (var item in ListaDuvida)
            {
              if(item.ID == RespostaPergunta.Identificacao)
              {
                item.FoiRespondido = true;
              }
              else if (item.ID != RespostaPergunta.Identificacao)
              {
                
              }
            }
            Console.Clear();
            Console.WriteLine("Digite a sua resposta");
            RespostaPergunta.Conteudo = Console.ReadLine();
            ListaResposta.Add(RespostaPergunta);
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("E-mail enviado... Aperte em qualquer tecla para continuar");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
           }
           else
           {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Não existe E-mails, aperte em qualquer tecla para continuar");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
           }
        }
    }
}
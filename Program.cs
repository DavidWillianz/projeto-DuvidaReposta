using System;

namespace Projeto_pratico___Duvida_e_resposta
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            var opcao = 0;
            do
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|                 MENU                   |");
            Console.WriteLine("| Seja bem vindo ao sistema de E-mail.   |");
            Console.WriteLine("| Informe a opção que desejar            |");
            Console.WriteLine("| 1 - Aluno                              |");
            Console.WriteLine("| 2 - Professor                          |");
            Console.WriteLine("| 3 - Sair                               |");
            Console.WriteLine("-----------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            switch (opcao)
            {
                case 1:
                OpcaoALuno();
                break;

                case 2:
                OpcaoProfessor();
                break;
                
                default:
                Console.WriteLine("Opção digitada não existe, tente novamente.");
                break;
            }
            }while (opcao !=3);
        }
        public static void OpcaoALuno()
        {
            Menu menu = new Menu();
            var escolhaMenuAluno = 0;
            do
            {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("|            MENU ALUNO             |");
            Console.WriteLine("|                                   |");
            Console.WriteLine("| 1 - Enviar uma dúvida             |");
            Console.WriteLine("| 2 - Visualizar E-mails            |");
            Console.WriteLine("| 3 - Voltar para o menu principal  |");
            Console.WriteLine("|                                   |");
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("Escolha a opção que deseja");
            escolhaMenuAluno =Convert.ToInt32(Console.ReadLine());

            if(escolhaMenuAluno == 1)
            {
              menu.AddALuno();
            }
            else if(escolhaMenuAluno == 2)
            {
              Console.Clear();
              menu.ExibirEmails();
            }
            }  while(escolhaMenuAluno != 3);
        }
         public static void OpcaoProfessor()
        {
             Menu menu = new Menu();
            
            var escolhaMenuProfessor = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------------");
                Console.WriteLine("|            MENU PROFESSOR         |");
                Console.WriteLine("|                                   |");
                Console.WriteLine("| 1 - Ver dúvidas                   |");
                Console.WriteLine("| 2 - Enviar resposta               |");
                Console.WriteLine("| 3 - Voltar para o menu principal  |");
                Console.WriteLine("|                                   |");
                Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Escolha a opção que deseja");
                escolhaMenuProfessor = Convert.ToInt32(Console.ReadLine());

                if (escolhaMenuProfessor == 1)
                {
                   menu.VerDuvidas();
                }
                else if (escolhaMenuProfessor == 2)
                {
                  Console.Clear();
                  menu.AddResposta();
                }
            } while (escolhaMenuProfessor != 3);
        }
    }
}
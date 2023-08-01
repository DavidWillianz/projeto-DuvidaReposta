using System;
namespace Projeto_pratico___Duvida_e_resposta
{
    public class Email
    {
        private string _conteudo;
        public string Conteudo { get => _conteudo; set => _conteudo = value; }

       private int _ID;
       public int ID
       {
        get { return _ID; }
        set { _ID = value; }
       }
    }
}
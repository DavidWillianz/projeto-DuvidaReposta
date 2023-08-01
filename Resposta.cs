namespace Projeto_pratico___Duvida_e_resposta
{
    public class Resposta:Email
    {
      public bool FoiRespondido { get{return false;} set{ FoiRespondido = false;} }
      private int _idenificaçãoDuvida;
      public int Identificacao { get { return _idenificaçãoDuvida;} set {_idenificaçãoDuvida = value; } }
      public string Exibir(Duvida duvida)
      {
        return $"============= Resposta ============ \n[Número de identificação do e-mail de dúvida]: {duvida.ID} \n[Número de identificação]: {this.ID} \n[Dúvida]: {duvida.Conteudo} \n[Resposta]: {this.Conteudo}";
      }
    }
}
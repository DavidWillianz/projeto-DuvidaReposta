namespace Projeto_pratico___Duvida_e_resposta
{
    public class Duvida:Email //terminar exibir duvida
    {
       private bool _foiRespondido;
       public bool FoiRespondido {  get { return _foiRespondido; } set { _foiRespondido = value; } }

      public string Exibir()
      {
        return $"============= Dúvida ============ \n[Número de identificação]: {this.ID} \n[Pergunta]: {this.Conteudo} \n[Respondido]: {FoiRespondido}";
      }
    }
}
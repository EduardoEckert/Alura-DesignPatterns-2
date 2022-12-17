namespace Alura_DesignPatterns_2.Atividade06
{
    public class MensagemCliente : IMensagem
    {
        public string Nome { get; set; }
        public IEnviador Enviador { get; set; }

        public MensagemCliente(string nome)
        {
            Nome = nome;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o Cliente {0}", Nome);
        }
    }
}

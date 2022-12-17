namespace Alura_DesignPatterns_2.Atividade06
{
    public interface IMensagem
    {
        IEnviador Enviador { get; set; }

        void Envia();

        string Formata();
    }
}

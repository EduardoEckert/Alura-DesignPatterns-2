namespace Alura_DesignPatterns_2.Atividade06
{
    internal class EnviaPorSms : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando mensagem por sms");
            Console.WriteLine(mensagem.Formata());
        }
    }
}

using Alura_DesignPatterns_2.Atividade05;

namespace Alura_DesignPatterns_2.Atividade04
{
    public class Numero : IExpressao
    {
        public int Valor { get; private set; }

        public Numero(int valor)
        {
            Valor = valor;
        }

        public int Avalia()
        {
            return Valor;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeNumero(this);
        }
    }
}

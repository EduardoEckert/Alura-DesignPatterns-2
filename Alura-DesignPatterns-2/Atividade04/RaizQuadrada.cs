using Alura_DesignPatterns_2.Atividade05;

namespace Alura_DesignPatterns_2.Atividade04
{
    public class RaizQuadrada : IExpressao
    {
        public IExpressao Expressao { get; private set; }

        public RaizQuadrada(IExpressao num)
        {
            Expressao = num;
        }

        public int Avalia()
        {
            return (int)Math.Sqrt(Expressao.Avalia());
        }

        public void Aceita(IVisitor visitor)
        {
           visitor.ImprimeRaizQuadrada(this);
        }
    }
}

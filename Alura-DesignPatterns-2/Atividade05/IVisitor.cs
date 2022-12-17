using Alura_DesignPatterns_2.Atividade04;

namespace Alura_DesignPatterns_2.Atividade05
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada);
        void ImprimeNumero(Numero numero);
    }
}

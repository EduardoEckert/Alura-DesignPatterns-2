using Alura_DesignPatterns_2.Atividade04;

namespace Alura_DesignPatterns_2.Atividade05
{
    public class ImpressoraVisitor : IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.Aceita(this);
            Console.Write(" + ");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.Esquerda.Aceita(this);
            Console.Write(" - ");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada)
        {
            Console.WriteLine("(");
            raizQuadrada.Expressao.Aceita(this);
            Console.WriteLine(")");
        }

        public void ImprimeNumero(Numero numero) => Console.WriteLine(numero.Valor);
    }
}

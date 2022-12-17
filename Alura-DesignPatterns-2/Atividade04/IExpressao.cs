using Alura_DesignPatterns_2.Atividade05;

namespace Alura_DesignPatterns_2.Atividade04
{
    public interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor visitor);
    }
}

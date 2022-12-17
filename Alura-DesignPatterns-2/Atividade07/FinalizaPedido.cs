namespace Alura_DesignPatterns_2.Atividade07
{
    internal class FinalizaPedido : IComando
    {
        public Pedido Pedido { get; set; }

        public FinalizaPedido(Pedido pedido)
        {
            Pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Pedido do {0} foi finalizado!", Pedido.Cliente);
            Pedido.Finaliza();
        }
    }
}

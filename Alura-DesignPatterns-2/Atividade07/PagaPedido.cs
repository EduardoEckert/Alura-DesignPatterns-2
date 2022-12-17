namespace Alura_DesignPatterns_2.Atividade07
{
    public class PagaPedido : IComando
    {
        public Pedido Pedido { get; set; }

        public PagaPedido(Pedido pedido)
        {
            Pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Pedido do {0} foi pago!", Pedido.Cliente);
            Pedido.Paga();
        }
    }
}

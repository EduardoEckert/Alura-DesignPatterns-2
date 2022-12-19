namespace Alura_DesignPatterns_2.Atividade09
{
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facade = new EmpresaFacade();
        public EmpresaFacade Instancia { get { return facade; } }
    }
}

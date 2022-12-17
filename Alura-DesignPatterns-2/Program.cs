using Alura_DesignPatterns_2;
using Alura_DesignPatterns_2.Atividade01;
using Alura_DesignPatterns_2.Atividade02;
using Alura_DesignPatterns_2.Atividade03;
using Alura_DesignPatterns_2.Atividade04;
using Alura_DesignPatterns_2.Atividade05;
using Alura_DesignPatterns_2.Atividade06;
using Alura_DesignPatterns_2.Atividade07;
using Alura_DesignPatterns_2.Atividade08;
using System.Linq.Expressions;

ExecutarAtividade(8);

void ExecutarAtividade(int numAtividade)
{
    switch (numAtividade)
    {
        case 1:
            Atividade01();
            break;

        case 2:
            //Flyweight
            Atividade02();
            break;

        case 3:
            //Memento
            Atividade03();
            break;

        case 4:
            //Interpreter
            Atividade04_05();
            break;

        case 5:
            //Visitor
            Atividade04_05();
            break;

        case 6:
            //Bridge
            Atividade06();
            break;

        case 7:
            //Command
            Atividade07();
            break;

        case 8:
            //Adapter
            Atividade08();
            break;

        default:
            break;
    }
}

void Atividade01()
{
    var connection = new ConnectionFactory().GetConnection();
    var command = connection.CreateCommand();
    command.CommandText = "slect * from table";
}

void Atividade02()
{
    NotasMusicais notas = new NotasMusicais();

    var musica = new List<INota>()
    {
     notas.Pega("do"),
     notas.Pega("re"),
     notas.Pega("mi"),
     notas.Pega("fa"),
     notas.Pega("fa"),
     notas.Pega("fa"),
    };

    Piano piano = new Piano();
    piano.Toca(musica);
}

void Atividade03()
{
    var historico = new Historico();
    Contrato contrato = new Contrato(DateTime.Now, "Eduardo", TipoContrato.Novo);

    historico.Adiciona(contrato.SalvaEstado());

    contrato.Avanca();
    historico.Adiciona(contrato.SalvaEstado());

    contrato.Avanca();
    historico.Adiciona(contrato.SalvaEstado());

    Console.WriteLine(historico.Pega(3).Contrato.Tipo);
}

void Atividade04_05()
{
    var esquerda = new Soma(new Numero(1), new Numero(10));
    var direita = new Subtracao(new Numero(20), new Numero(10));
    var soma = new Soma(esquerda, direita);

    Console.WriteLine(soma.Avalia());

    var somaExpression = Expression.Add(Expression.Constant(10), Expression.Constant(100));
    var funcao = Expression.Lambda<Func<int>>(somaExpression).Compile();

    Console.WriteLine(funcao());

    var raizQuadrada = new RaizQuadrada(new Numero(49));

    Console.WriteLine(raizQuadrada.Avalia());

    //05
    var impressora = new ImpressoraVisitor();

    soma.Aceita(impressora);
    raizQuadrada.Aceita(impressora);
}

void Atividade06()
{
    var mensagem = new MensagemCliente("Eduardo");
    var enviador = new EnviaPorSms();
    mensagem.Enviador = enviador;
    mensagem.Envia();
}

void Atividade07()
{
    var fila = new FilaDeTrabalho();
    Pedido pedido1 = new Pedido("Carlos", 150);
    Pedido pedido2 = new Pedido("Maria", 1000);

    fila.Adiciona(new PagaPedido(pedido1));
    fila.Adiciona(new PagaPedido(pedido2));

    fila.Adiciona(new FinalizaPedido(pedido1));

    fila.Processa();
}

void Atividade08()
{
    var cliente = new Cliente();
    cliente.Nome = "Eduardo Eckert Sperfeld";
    cliente.Endereco = "Terra";
    cliente.DataNascimento = Convert.ToDateTime("07/03/2003");

    var xml = new GeradorDeXml().GeraXml(cliente);

    Console.WriteLine(xml);
}
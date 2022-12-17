﻿using Alura_DesignPatterns_2;
using Alura_DesignPatterns_2.Atividade01;
using Alura_DesignPatterns_2.Atividade02;
using Alura_DesignPatterns_2.Atividade03;
using Alura_DesignPatterns_2.Atividade04;
using Alura_DesignPatterns_2.Atividade05;
using Alura_DesignPatterns_2.Atividade06;
using System.Linq.Expressions;


ExecutarAtividade(6);

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
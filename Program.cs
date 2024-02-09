using System.Security.Cryptography;
using System.Text;
using DesafioProjetoHospedagem.Models;


Console.OutputEncoding = Encoding.UTF8;

string tipoBasica = "";
int capacidade = 0;
int valorDiaria = 0;

string tipoIntermediaria = "";
int capacidadeI = 0;
int valorDiariaI = 0;

string tipoPremium = "";
int capacidadeP = 0;
int valorDiariaP = 0;

string Responsavel = "";
int pessoasHospedadas = 0;

List<Pessoa> hospedes = new List<Pessoa>();


Reserva rs = new Reserva();
Suite sb = new Suite(tipoBasica, valorDiaria);
SuiteIntermediaria si = new SuiteIntermediaria(tipoIntermediaria, valorDiariaI);
SuitePremium sp = new SuitePremium(tipoPremium,valorDiariaP);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();

    Console.WriteLine("Seja Bem - Vindo Ao Nosso Sistema De Hotelária.");
    Console.WriteLine("Digite o número correspondente a Suíte que você deseja: ");

    Console.WriteLine("1 - Suíte Básica \n\n Descrição:");
    Console.WriteLine("- Cama de Solteiro");
    Console.WriteLine("- TV com canais abertos");
    Console.WriteLine("- Banheiro comum");
    Console.WriteLine("- Wifi Com 10 Mega De Velocidade");
    Console.WriteLine("- Sem Varanda \n");


    Console.WriteLine("2 - Suíte Intermediária \n\n Descrição:");
    Console.WriteLine("- Cama de Casal");
    Console.WriteLine("- Tv com Filmes e Séries");
    Console.WriteLine("- Banheiro Médio Com Banheira");
    Console.WriteLine("- Wifi Com 40 Mega De Velocidade");
    Console.WriteLine("- Varanda Com Vista Para Cidade\n");


    Console.WriteLine("3 - Suíte Premium \n\n Descrição:");
    Console.WriteLine("- Cama De Casal Grande");
    Console.WriteLine("- TV Com Qualquer Tipo De Conteúdo Liberado");
    Console.WriteLine("- Banheiro Grande Com Banheira E Hidromassagem");
    Console.WriteLine("- FrigoBar Com Bebidas E Comidas Liberadas");
    Console.WriteLine("- Wifi Com 150 Mega De Velocidade");
    Console.WriteLine("- Varanda Grande Com Vista Pra Praia");


switch (Console.ReadLine())
{
    case"1":
    sb.EscolherSuiteBasica();
    break;

    case"2":
    si.EscolherSuiteIntermediaria();
    break;

    case"3":
    sp.EscolherSuitePremium();
    break;

    case"4":
    exibirMenu = false;
    break;

    default:
    Console.WriteLine("Opção Inválida");
    break;

}

Console.WriteLine("Pressione uma tecla para continuar");
Console.ReadLine();

}

Console.WriteLine("o programa se encerrou");
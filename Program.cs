// See https://aka.ms/new-console-template for more information
// using DesafioFundamentos.Models;

using DesafioFundamentos.Models;

Console.WriteLine("Bem-vindo ao Estacionamento Csharp");

while (true)
{
  decimal precoIncial;
  decimal precoPorHora;

  while (true)
  {
    Console.WriteLine("Digite o preço inicial:");
    var userInput = Console.ReadLine();
    if (decimal.TryParse(userInput, out precoIncial))
    {
      break;
    }
    else
    {
      Console.WriteLine(
          "Entrada inválida. Certifique-se de inserir um valor válido");
    }
  }

  while (true)
  {
    Console.WriteLine("Agora digite o valor por hora:");
    var userInput = Console.ReadLine();

    if (decimal.TryParse(userInput, out precoPorHora))
    {
      break;
    }
    else
    {
      Console.WriteLine(
          "Entrada inválida. Certifique-se de inserir um valor válido!");
    }
  }

  Console.WriteLine(
      $"O valor incial é de {precoIncial} e o preco por hora é de: {precoPorHora}");

  Estacionamento e1 = new Estacionamento(precoIncial, precoPorHora);

  var opcao = "";

  while (true)
  {
    Console.WriteLine("-------------------------");
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("[1] - Cadastrar Veículo");
    Console.WriteLine("[2] - Remover Veículo");
    Console.WriteLine("[3] - Listar Veículos");
    Console.WriteLine("[4] - Encerrar");
    Console.WriteLine("-------------------------");
    opcao = Console.ReadLine();
    if (opcao == "1")
    {
      e1.AdicionarVeiculo();
    }
    else if (opcao == "2")
    {
      e1.RemoverVeiculo();
    }
    else if (opcao == "3")
    {
      e1.ListarVeiculos();
    }
    else if (opcao == "4")
    {
      Console.WriteLine("encerrando");
      break;
    }
    else
    {
      Console.WriteLine("Digite uma opção válida!");
    }
  }
  if (opcao == "4")
  {
    break;
  }
}

// Estacionamento e1 = new Estacionamento();

// e1.AdicionarVeiculo();
// e1.ListarVeiculos();

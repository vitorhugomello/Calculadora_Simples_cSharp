using System;
class Principal{
  static void Main(){
    Console.WriteLine("------------------------------");
    Console.WriteLine("----------calculadora---------");
    Console.WriteLine("------------------------------");

    inicioPrograma:
    int opcao = 0;
    int v1= 0, v2= 0;
    int resposta = 0;
    string operador = "_";

    opcao = Opcoes();

    Console.Write("Valor 1: ");
    v1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Valor 2: ");
    v2 = Convert.ToInt32(Console.ReadLine());

    switch (opcao){
      case 1:
        resposta = v1 + v2;
        operador = "+";
        break;
      case 2:
        resposta = v1 - v2;
        operador = "-";
        break;
      case 3:
        resposta = v1 * v2;
        operador = "*";
        break;
      case 4:
        resposta = v1 / v2;
        operador = "/";
        break;
      default:
        Console.WriteLine("erro 404");
        break;
    }
    Console.Clear();
    Console.WriteLine("{0} {1} {2} = {3}", v1, operador, v2, resposta);

    refazer:
    string refazer = "_";
    Console.WriteLine("Deseja fazer outra operação?[s/n]");
    Console.Write("->");
    refazer = Console.ReadLine();
    if (refazer == "s" | refazer == "S"){
      Console.Clear();
      goto inicioPrograma;
    }else if (refazer == "n" | refazer == "N"){
      Console.Clear();
      Console.WriteLine("Tchau!!");
    }else{
      Console.Clear();
      Console.WriteLine("Resposta invalida!");
      goto refazer;
    }
  }
  static int Opcoes(){
    opcoes:
    string opcao = "nada";
    int resposta = -1;

    Console.WriteLine("----------------");
    Console.WriteLine("Qual operação?");
    Console.WriteLine("[1] Adição.");
    Console.WriteLine("[2] Subtração.");
    Console.WriteLine("[3] Multiplicação.");
    Console.WriteLine("[4] Divisão.");
    Console.WriteLine("----------------");
    Console.Write("->");
    opcao = Console.ReadLine();

    if (opcao == "1" | opcao == "2" | opcao == "3" | opcao == "4"){
      resposta = Convert.ToInt32(opcao);
      Console.Clear();
    }else{
      Console.Clear();
      Console.WriteLine("Resposta invalida!");
      goto opcoes;
    }

    return resposta;
  }
}

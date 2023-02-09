using System;
class Program {
  public static void Main (string[] args) {
     string nome, entrada;
    Double n1, n2, n3, media;
//Escreval("texto")
    Console.WriteLine("Digite o nome do aluno");
//leia(variavel)
    nome = Console.ReadLine();
//solicita que o usuario digite a n1
    
    Console.WriteLine("Digite a primeira nota");
//recebe a nota 1 na variavel de texto
    entrada = Console.ReadLine();
// converter a entrada em um Double
    n1 =  Double.Parse(entrada);
//repete para a n2
    Console.WriteLine ("Digite a nota 2");
    entrada = Console.ReadLine();
    n2 = Double.Parse(entrada);
//repete para a n3
     Console.WriteLine ("Digite a nota 3");
    entrada = Console.ReadLine();
    n3 = Double.Parse(entrada);
//calculo a media
    media = (n1 * 2 + n2 * 3 + n3 * 5)/10;
    Console.WriteLine ("A média do(a) aluno(a) " + nome + " é " +media);
    Console.WriteLine ();
  }
}


using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;


static void ex1(string[] args)
{
    int a = 10;
    int b = 20;
    int c = ((a+b)/2);
    c = c - 40;
    int[] vetor = new int[3]{a,b,c};
    vetor[0] = a + b + c;
    Console.WriteLine($"A saída do vetor é igual {vetor[0]}");
}

static void ex2(string[] args)
{
    Console.WriteLine("informe um valor");
    int a = int.Parse(Console.ReadLine());
    while (a<6)
    {
        int[] vet = new int[] {a};
        vet[0] = 10 * a;
        a += 1;
        Console.WriteLine($"Verdadeiro: {vet[0]}");
    }
}

  static void Main (string[] args) {
  int a = 7;
  int b = a - 6;
  int[] v = new int[]{b};
  while(b<a){
    v[0] = b+a;
    Console.WriteLine($"Verdadeiro: {v[0]}");
    b = b + 2;
    }
  }

Console.WriteLine("informe qual ex deseja ver a resposta; ex1, ex2 ou ex3: ");
string resposta = Console.ReadLine();
switch(resposta){
    case "ex1":
        ex1(args);
        break;
    case "ex2":
        ex2(args);
        break;
    case "ex3":
        Main(args);
        break;
    default:
        Console.WriteLine("ERRO");
        break;
}
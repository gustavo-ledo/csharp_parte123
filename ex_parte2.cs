using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

static void Main(string[] args){
    double p, i, F, v;
    int n;
    int cont = 1;
    n = 10;
    p = 1.000;
    i = 0.0530f;
    while(cont <= 10)
    {
        v = Math.Pow(1+i, cont);
        F = p * v; 
        cont ++;
        Console.WriteLine($"{F:C}");
    }
}


static void Main2(string[] args){
    double p, i, F;
    int n;
    int cont = 1;
    n = 6;
    double[] v = new double[12];
    p = 3.800;
    i = 0.0125f;
    while(cont <= 6)
    {
        v[cont] = Math.Pow(1+i, cont);
        F = p * v[cont]; 
        cont ++;
        Console.WriteLine($"{F:C}");
    }
}


static void Main3(string[] args){
double p, i, F;
int n;
Console.WriteLine("informe o periodo 1/12: ");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor presente: ");
p = Convert.ToDouble(Console.ReadLine());
int cont = 1;
double[] v = new double[12];
Console.WriteLine("informe a taxa de juros: ");
i = Convert.ToDouble(Console.ReadLine());
i = i /100;
    while(cont <= n)
    {
        v[cont] = Math.Pow(1+i, cont);
        F = p * v[cont]; 
        cont ++;
        Console.WriteLine($"{F:C}");
    }
}


static void Main4(string[] args){
    int cont = 1;
    double F;
    double[] v = new double[12];
    double v_saldo = 20000;
    double tx_juros = 0.0200;
    int periodo = 6;
    tx_juros = tx_juros/100;
    while(cont <= periodo){ 
        v[cont] = Math.Pow(1 + tx_juros, cont);
        F = v_saldo * v[cont];
        Console.WriteLine($"seu saldo é {v_saldo:C}");
        cont++;
          
    
}


static void Main5(string[] args){
      double p, i, F;
    int n;
    int cont = 1;
    n = 6;
    double[] v = new double[12];
    i = 0.0125f;
    F = 7390.61;
    while(cont <= 6)
    {
        v[cont] = Math.Pow(1+i, cont);
        p = F / v[cont]; 
        cont ++;
        Console.WriteLine($"{p:C}");
    }
}
Console.WriteLine("informe o ex desejado (ex1, ex2, ex3, ex4, ex5)");
string resposta = Console.ReadLine();
switch(resposta){
    case "ex1":
        Main(args);
        break;
    case "ex2":
        Main2(args);
        break;
    case "ex3":
        Main3(args);
        break;
    case "ex4":
        Main4(args);
        break;
    case "ex5":
        Main5(args);
        break;
    default:
        Console.WriteLine("ERRO");
        break;
}
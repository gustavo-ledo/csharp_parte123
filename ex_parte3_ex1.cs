using System;

 class program{

    static void Main(string[] args){
        metodo R = new metodo();
        Console.Write("informe o valor presente: ");
        R.valor_p = Convert.ToDouble(Console.ReadLine());
        Console.Write("informe a taxa de juros presente: ");
        R.tx_juros = Convert.ToDouble(Console.ReadLine());
        Console.Write("informe o periodo: ");
        R.periodo = int.Parse(Console.ReadLine()); 
        R.valor_F();
    }
}

public class metodo{
    public double valor_p;
    public double tx_juros;
    public int periodo;
    
    public void valor_F(){
        
        tx_juros = tx_juros / 100;
       double valor_final = valor_p*Math.Pow(1+tx_juros, periodo);
        Console.Write(valor_final);

    }
}
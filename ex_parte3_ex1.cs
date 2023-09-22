using System;

class Program {
    static void Main(string[] args) {
        RecebeDados dados_recebidos = new RecebeDados();
        dados_recebidos.Dados();
    }
}

class RecebeDados {
    public void Dados() {
        Metodo R = new Metodo();

        Console.Write("Informe o valor presente: ");
        R.valor_p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a taxa de juros mensal (em %): ");
        R.tx_juros = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Informe o período em dias: ");
        R.periodoDias = int.Parse(Console.ReadLine());
        R.valor_F();
    }
}

public class Metodo {
    public double valor_p;
    public double tx_juros;
    public int periodoDias;
    public void valor_F() {
        int diasNoMes = 30;
        int meses = periodoDias / diasNoMes;
        int diasRestantes = periodoDias % diasNoMes;

        double valor_final = valor_p * Math.Pow(1 + tx_juros, meses) * Math.Pow(1 + tx_juros * diasRestantes / diasNoMes, 1);
        Console.WriteLine($"O valor final é:{valor_final:C}");
    }
}
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

        Console.Write("Informe o período em meses: ");
        R.periodoMeses = int.Parse(Console.ReadLine());
        Console.WriteLine("+-------------------------------------------+");
        R.Saque();
    }
}

public class Metodo {
    public double valor_p;
    public double tx_juros;
    public int periodoMeses;

    public void Saque() {
        double valor_final = valor_p;
        int mesesPassados = 0;

        while (mesesPassados < periodoMeses) {
            Console.WriteLine($"O valor após {mesesPassados + 1} meses é: {valor_final:C}");
            
            Console.Write("Deseja realizar um saque neste mês? (s/n): ");
            string r = Console.ReadLine();

            if (r == "s") {
                Console.Write("Informe o valor do saque: ");
                double saque = Convert.ToDouble(Console.ReadLine());
                valor_final -= saque;
                Console.WriteLine("+-------------------------------------------+");
                Console.WriteLine($"Novo saldo após saque: {valor_final:C}");

            }

            valor_final *= Math.Pow(1 + tx_juros, 1);
            mesesPassados++;
        }

        Console.WriteLine($"O valor final após {periodoMeses} meses é: {valor_final:C}");
            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine("|    MENSAL     |      MÊS      |      TAXA |");
            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine($"|    {valor_final:C}      |    {mesesPassados}       |    {tx_juros}  | ");
            Console.WriteLine("+-------------------------------------------+");
            
    }
}

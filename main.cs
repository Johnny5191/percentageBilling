using System;

class Program {
  public static void Main (string[] args) {
    decimal totalFaturamento = 0;
        decimal faturamentoSP = 67836.43m;
        decimal faturamentoRJ = 36678.66m;
        decimal faturamentoMG = 29229.88m;
        decimal faturamentoES = 27165.48m;
        decimal faturamentoOutros = 19849.53m;

        // Calcula o total de faturamento mensal da distribuidora
        totalFaturamento = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

        // Calcula o percentual de representação de cada estado no faturamento mensal da distribuidora
        decimal percentualSP = (faturamentoSP / totalFaturamento) * 100;
        decimal percentualRJ = (faturamentoRJ / totalFaturamento) * 100;
        decimal percentualMG = (faturamentoMG / totalFaturamento) * 100;
        decimal percentualES = (faturamentoES / totalFaturamento) * 100;
        decimal percentualOutros = (faturamentoOutros / totalFaturamento) * 100;

        // Exibe o percentual de representação de cada estado no faturamento mensal da distribuidora
        Console.WriteLine("Percentual de representação do faturamento mensal por estado:");
        Console.WriteLine("SP: {0}%", percentualSP);
        Console.WriteLine("RJ: {0}%", percentualRJ);
        Console.WriteLine("MG: {0}%", percentualMG);
        Console.WriteLine("ES: {0}%", percentualES);
        Console.WriteLine("Outros: {0}%", percentualOutros);

        Console.ReadLine();
  }
}
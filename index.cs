using System;

class Program
{
    static void Main()
    {
      string nome = Console.ReadLine();
       
       double quilometrosPorDia = double.Parse(Console.ReadLine());
       
       int horasDeEletronicos = int.Parse(Console.ReadLine());
       
       int refeicoesComCarne = int.Parse(Console.ReadLine());

       double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
        
      Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

    }

    // TODO: Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:
  
        static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
        {
        double fatorTransporte = 0.2;
        double fatorEletronicos = 0.1;
        double fatorRefeicoesCarne = 0.5;

        double pegadaTotal = (quilometrosPorDia * 365 * fatorTransporte) +
                             (horasDeEletronicos * fatorEletronicos) +
                             (refeicoesComCarne * fatorRefeicoesCarne);

        return pegadaTotal;
    }
}
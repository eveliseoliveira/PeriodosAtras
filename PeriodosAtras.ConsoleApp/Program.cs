using System;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //teste
            Console.WriteLine("Informe a data: "); 
            string data = Console.ReadLine();

            DateTime atual = DateTime.Now;

            TimeSpan diferenca = atual.Subtract(Convert.ToDateTime(data));

            int segundos = (diferenca.Days * 86400) + diferenca.Seconds;

            int minutos = (diferenca.Days * 1440) + diferenca.Minutes;

            int horas = (diferenca.Days * 24) + diferenca.Hours;

            int dias = diferenca.Days;

            int semana = diferenca.Days / 7;

            int meses = diferenca.Days / 30;

            int anos = diferenca.Days / 365;


            if (diferenca.Days < (1/1440))
            {
                Console.WriteLine(minutos + " minutos atrás e " + segundos + " segundos");
            }
            else if(diferenca.Days < 1)
            {
                Console.WriteLine(horas + " hora(s) " + minutos + " minutos e " + segundos + " segundos atrás");
            }
            else if (diferenca.Days >= 1 && diferenca.Days < 7)
            {
                Console.WriteLine(dias + " dia(s) e " + horas + " hora(s) atrás");
            }
            else if (diferenca.Days >= 7 && diferenca.Days < 29)
            {
                Console.WriteLine(semana + " semana(s) e" + dias + " dia(s) e " + horas + " hora(s) atrás");
            }
            else if(diferenca.Days >= 30 && diferenca.Days <= 365)
            {
                Console.WriteLine(meses + " mes(es) " + semana + " semana(s) e " + dias + " dia(s) atrás");
            }
            else if(diferenca.Days > 365 && diferenca.Days < 3650)
            {
                if(diferenca.Days > 365 && diferenca.Days <= 729)
                {
                    Console.WriteLine(anos + " ano e " + meses + " mes(es) atrás");
                }
                else if(diferenca.Days >= 730 && diferenca.Days <= 3650)
                {
                    Console.WriteLine(anos + " ano(s) e " + meses + " mes(es) atrás");
                }
            }
            else if(diferenca.Days >= 3650)
            {
                Console.WriteLine(anos + " anos atrás");
            }
        }
    }
}

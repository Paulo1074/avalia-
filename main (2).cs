using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Dia de início:");
        int diaInicio = int.Parse(Console.ReadLine().Split(' ')[1]);

        Console.WriteLine("Hora de início (hh:mm:ss):");
        string[] horarioInicio = Console.ReadLine().Split(':');
        int horaInicio = int.Parse(horarioInicio[0]);
        int minutoInicio = int.Parse(horarioInicio[1]);
        int segundoInicio = int.Parse(horarioInicio[2]);

        Console.WriteLine("Dia de término:");
        int diaFim = int.Parse(Console.ReadLine().Split(' ')[1]);

        Console.WriteLine("Hora de término (hh:mm:ss):");
        string[] horarioFim = Console.ReadLine().Split(':');
        int horaFim = int.Parse(horarioFim[0]);
        int minutoFim = int.Parse(horarioFim[1]);
        int segundoFim = int.Parse(horarioFim[2]);

        int inicioEmSegundos = segundoInicio + minutoInicio * 60 + horaInicio * 3600 + diaInicio * 86400;
        int fimEmSegundos = segundoFim + minutoFim * 60 + horaFim * 3600 + diaFim * 86400;

        int duracaoEmSegundos = fimEmSegundos - inicioEmSegundos;

        int dias = duracaoEmSegundos / 86400;
        duracaoEmSegundos %= 86400;
        int horas = duracaoEmSegundos / 3600;
        duracaoEmSegundos %= 3600;
        int minutos = duracaoEmSegundos / 60;
        int segundos = duracaoEmSegundos % 60;

        Console.WriteLine($"{dias} dia(s)");
        Console.WriteLine($"{horas} hora(s)");
        Console.WriteLine($"{minutos} minuto(s)");
        Console.WriteLine($"{segundos} segundo(s)");
    }
}

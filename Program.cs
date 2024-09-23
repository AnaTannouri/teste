using System;
using System.Threading;

class Program
{
    // Método que será executado pela primeira thread
    static void ImprimirNumeros()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Thread 1 - Número: {i}");
            Thread.Sleep(1000); // Pausa por 1 segundo
        }
    }

    // Método que será executado pela segunda thread
    static void ImprimirLetras()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Thread 2 - Letra: {(char)(i + 64)}");
            Thread.Sleep(800); // Pausa por 0.8 segundos
        }
    }

    static void Main(string[] args)
    {
        // Criação da primeira thread para executar ImprimirNumeros
        Thread thread1 = new Thread(new ThreadStart(ImprimirNumeros));

        // Criação da segunda thread para executar ImprimirLetras
        Thread thread2 = new Thread(new ThreadStart(ImprimirLetras));

        // Início das duas threads
        thread1.Start();
        thread2.Start();

        // Aguarda ambas as threads finalizarem antes de continuar
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Execução completa das duas threads!");
    }
}
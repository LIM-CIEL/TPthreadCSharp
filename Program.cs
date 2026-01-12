using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Program
{
    static void AfficheA()
    {
        while (true)
        {
            Console.WriteLine($"AfficheA thread : {Thread.CurrentThread.Name}");
            Thread.Sleep(1000);
        }
    }

    static void Main(string[] args)
    {
        // Infos sur le thread principal
        Thread mainThread = Thread.CurrentThread;
    
        // Changer le nom du thread principal
        mainThread.Name = "MainThread";
        Console.WriteLine($"Nom modifié du thread principal : {mainThread.Name}");

        // Créer un thread pour AfficheA
        Thread t1 = new Thread(AfficheA);
        t1.Name = "Thread-A1";
        t1.Start();

        Thread t2 = new Thread(AfficheA);
        t2.Name = "Thread-A2";
        t2.Start();

        Thread t3 = new Thread(AfficheA);
        t3.Name = "Thread-A3";
        t3.Start();
    }
}

namespace csharp_practice17;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();
        for (int i = 1; i <= 1000; i++)
        {
            arrayList.Add(i);
        }
        Stopwatch stopwatch1 = new Stopwatch();
        stopwatch1.Start();
        int sum1 = 0;
        foreach (int i in arrayList)
            sum1 += i;
        stopwatch1.Stop();
        
        Console.WriteLine("--- ARRAY LIST ---");
        Console.WriteLine($"Sum: {sum1}");
        Console.WriteLine($"Time: {stopwatch1.Elapsed.TotalMilliseconds} ms");
        Console.WriteLine($"Ticks: {stopwatch1.ElapsedTicks}");
        Console.WriteLine("");

        List<int> list = new List<int>();
        for (int i = 1; i <= 1000; i++)
            list.Add(i);
        Stopwatch stopwatch2 = new Stopwatch();
        stopwatch2.Start();
        int sum2 = 0;
        foreach (int i in list)
            sum2 += i;
        stopwatch2.Stop();
        
        Console.WriteLine("--- LIST ---");
        Console.WriteLine($"Sum: {sum2}");
        Console.WriteLine($"Time: {stopwatch2.Elapsed.TotalMilliseconds} ms");
        Console.WriteLine($"Ticks: {stopwatch2.ElapsedTicks}");
    }
}
// See https://aka.ms/new-console-template for more information


class Test
{
    static async Task Main(string[] args)
    {
        Console.WriteLine($"Starting tasks at {DateTime.Now:HH:mm:ss.fff}...");

        Task task1 = Task1();
        Task3();
        Task task2 = Task2();
        Task4();


        await Task.WhenAll(task1, task2); // Wait for both tasks to complete

        Console.WriteLine($"Both tasks completed at {DateTime.Now:HH:mm:ss.fff}!");
    }

    static async Task Task1()
    {
        await Task.Delay(2000); // Simulate 2-second delay
        Console.WriteLine($"Task 1 completed at {DateTime.Now:HH:mm:ss.fff}");
    }

    static async Task Task2()
    {
        await Task.Delay(1000);
        Console.WriteLine($"Task 2 completed at {DateTime.Now:HH:mm:ss.fff}");
    }

    static void Task3()
    {
        Thread.Sleep(2000);
        Console.WriteLine($"Task 3 completed at {DateTime.Now:HH:mm:ss.fff}");
    }

    static void Task4()
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Task 4 completed at {DateTime.Now:HH:mm:ss.fff}");
    }
}
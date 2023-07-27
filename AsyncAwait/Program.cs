await PrintAsync();
Console.WriteLine("Some actions in main...\n");

void Print() {
    Thread.Sleep(3000);
    Console.WriteLine("Hello World!");
}

async Task PrintAsync()
{
    Console.WriteLine("Start method PrintAsync");
    await Task.Run(() => { Print(); });
    Console.Write("End method PrintAsync\n");
}
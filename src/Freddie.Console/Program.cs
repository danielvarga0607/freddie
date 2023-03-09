await Task.WhenAll(Task1(), Task2())
    .ContinueWith(task => Console.WriteLine(task.Exception?.Message), TaskContinuationOptions.OnlyOnFaulted)
    .ConfigureAwait(false);

Task Task1()
{
    Thread.Sleep(2000);
    throw new Exception(nameof(Task1) + " something went wrong!");
}

Task Task2()
{
    Thread.Sleep(1000);
    throw new Exception(nameof(Task2) + " something other when wrong!");
}
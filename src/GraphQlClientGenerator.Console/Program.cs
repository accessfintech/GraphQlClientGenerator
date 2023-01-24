using System.CommandLine;
using GraphQlClientGenerator.Console;

internal class Program
{
    public static async Task<int> Main(string[] args)
    {
        return await Commands.GenerateCommand.InvokeAsync(args);
    }
}
using System.Runtime.InteropServices;

namespace Mobility.WorkerService
{

    [StructLayout(LayoutKind.Sequential)]
    public class ListOperations
    {
        List<int> a;
    }
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }
        private const string dllPath = @"C:\Users\yunus\Documents\GitHub\WinForms-CRUD-EFCore\x64\Debug\ListOperationsDll.dll";

        [DllImport(dllPath)]
        public static extern int Multiply(int a, int b);

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            int result = Multiply(3, 5);
            _logger.LogInformation(result.ToString());
            await Task.Delay(1000, stoppingToken);
        }
    }
}
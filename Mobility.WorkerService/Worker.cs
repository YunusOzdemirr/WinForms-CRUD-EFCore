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
        private const string dllPath = @"C:\\Users\\yunus\\source\\repos\\MobilityPay\\x64\\Debug\ListOperationsDll.dll";
     
        [DllImport(dllPath)]
        public static extern object PrintList(ListOperations node);
        [DllImport(dllPath)]
        public static extern IntPtr CreateListOperations();
        [DllImport(dllPath)]
        public static extern ListOperations CreateNode(int data);
        [DllImport(dllPath)]
        public static extern void main();
        [DllImport(dllPath)]
        public static extern void DeleteListOperations(IntPtr listOps);
        [DllImport(dllPath)]
        public static extern void AddToList(IntPtr listOps, int data);
        [DllImport(dllPath)]
        public static extern IntPtr GetList(IntPtr listOps);
        [DllImport(dllPath)]
        public static extern void PrintList(IntPtr head);

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            IntPtr listOpsPtr = CreateListOperations();

            AddToList(listOpsPtr, 10);
            AddToList(listOpsPtr, 20);
            AddToList(listOpsPtr, 30);
            var getList = GetList(listOpsPtr);
            int value = Marshal.ReadInt32(getList);

            IntPtr headPtr = GetList(listOpsPtr);
            int intValue = Marshal.ReadInt32(headPtr);
            PrintList(headPtr);

            DeleteListOperations(listOpsPtr);
            //var asd2 = addToEnd(1);
            //var asd22 = getList();
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
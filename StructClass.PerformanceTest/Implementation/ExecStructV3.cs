using System.Diagnostics;
using StructClass.PerformanceTest.Dto;

namespace StructClass.PerformanceTest.Implementation
{
    public static class ExecStructV3
    {
        const int counter = 15_000_000;

        public static void Exec()
        {
            var listCoordinates = new List<CoordinatesStructV3>();
            var sw = new Stopwatch();

            for (var i = 0; i < counter; i++)
            {
                listCoordinates.Add(new CoordinatesStructV3
                {
                    Latitude = i,
                    Longitude = i
                });
            }

            var garbageV0 = GC.CollectionCount(0);
            var find = new CoordinatesStructV3
            {
                Latitude = -1,
                Longitude = -1
            };

            sw.Start();
            listCoordinates.Contains(find);
            sw.Stop();

            Console.WriteLine($"{Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024} MB.");
            Console.WriteLine($"Time: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine($"GC Gen0: {GC.CollectionCount(0) - garbageV0}");
        }
    }
}
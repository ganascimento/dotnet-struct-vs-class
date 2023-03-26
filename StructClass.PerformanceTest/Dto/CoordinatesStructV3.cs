namespace StructClass.PerformanceTest.Dto
{
    public struct CoordinatesStructV3 : IEquatable<CoordinatesStructV3>
    {
        public double Latitude;
        public double Longitude;

        public bool Equals(CoordinatesStructV3 other)
        {
            return Math.Abs(Latitude - other.Latitude) < 0.0001 &&
                   Math.Abs(Longitude - other.Longitude) < 0.0001;
        }
    }
}
namespace StructClass.PerformanceTest.Dto
{
    public struct CoordinatesStructV2
    {
        public double Latitude;
        public double Longitude;

        public override bool Equals(object obj)
        {
            if (!(obj is CoordinatesClass other))
            {
                return false;
            }

            return Math.Abs(Latitude - other.Latitude) < 0.0001 &&
                   Math.Abs(Longitude - other.Longitude) < 0.0001;
        }
    }
}
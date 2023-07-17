using System;
using ProjNet.CoordinateSystems;

namespace ValidatingNetTopology.ProjectedCoordinatesConverter
{
    public static class CoordinateTransformationExtension
    {
        public static (int, bool) GetZoneAndDirection(this (double latitude, double longitude) coordinate)
        {
            int zone = (int)Math.Round((coordinate.longitude + 180.0) / 6.0);
            bool north = coordinate.latitude >= 0;
            return (zone, north);
        }

        public static CoordinateSystem GetUtmCoordinateSystem(this (double latitude, double longitude) coordinate)
        {
            (int zone, bool north) = coordinate.GetZoneAndDirection();
            return ProjectedCoordinateSystem.WGS84_UTM(zone, north);
        }
    }
}
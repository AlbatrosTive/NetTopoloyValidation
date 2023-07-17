using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace ValidatingNetTopology.Interfaces
{
    public interface ICoordinatesTestingService
    {
        /// <summary>
        /// tests if points in WGS 84 coordinate system are inside a Polygon
        /// </summary>
        /// <param name="polygonBorders"></param>
        /// <param name="insidePolygonPoints"></param>
        /// <returns></returns>
        void RunInsidePointsInGcs(List<double[]>polygonBorders, List<double[]>insidePolygonPoints, string stateName);

        /// <summary>
        /// tests if points in UTM coordinate system are inside a Geometrical field
        /// </summary>
        /// <param name="polygonBorders"></param>
        /// <param name="insidePolygonPoints"></param>
        /// <returns></returns>
        void RunInsidePointsInPcs(List<double[]>polygonBorders, List<double[]>insidePolygonPoints, string stateName);

    }
}
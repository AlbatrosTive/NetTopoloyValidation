using System;
using System.Collections.Generic;
using System.Linq;
using NetTopologySuite.Geometries;
using ProjNet.CoordinateSystems.Transformations;
using ValidatingNetTopology.Interfaces;
using ValidatingNetTopology.ProjectedCoordinatesConverter;

namespace ValidatingNetTopology.Implementations
{
    public class CoordinatesTestingService : ICoordinatesTestingService
    {
        private readonly List<double[]> _coordinatesInAsia = new List<double[]>
        {
            new[] {103.76925806718371, 1.3665747904193317},
            new[] {101.72855752794992, 15.403381669193635},
            new[] {100.78243125585068, 30.990613144787794},
            new[] {103.93617884940618, 43.490282247774964},
            new[] {96.68255938422851, 29.354830504451236}
        };

        
        public void RunInsidePointsInGcs(List<double[]>polygonBorders, List<double[]> insidePolygonPoints, string stateName)
        {
            int counter = 0;

            foreach (var coordinate in insidePolygonPoints)
            {
                Polygon polygon = GetPolygon(polygonBorders);

                Point point = new Point(new Coordinate(coordinate[0], coordinate[1]));
                
                bool isInside = polygon.Covers(point);
                
                if (isInside)
                {
                    counter++;
                }
            }
            
            Console.WriteLine($"GCS-{stateName}\t\t\t Out of {insidePolygonPoints.Count}, GCS has asserted that {counter} are inside");
            
        }

        public void RunInsidePointsInPcs(List<double[]>polygonBorders, List<double[]>insidePolygonPoints, string stateName)
        {
            CoordinatesConverter converter = new CoordinatesConverter(new CoordinateTransformationFactory());

            int counter = 0;
            
            foreach (var coordinate in insidePolygonPoints)
            {
                Polygon polygon = GetPolygon(polygonBorders);
                double lat = coordinate[0];
                double lng = coordinate[1];
                Point point = new Point(new Coordinate(lat, lng));
                converter.WgsToUtm(lat, lng,  polygon, point);
                
                bool isInside = polygon.Covers(point);

                if (isInside)
                {
                    counter++;
                }
            }
            Console.WriteLine($"PCS-{stateName}\t\t\t Out of {insidePolygonPoints.Count}, PCS has asserted that {counter} are inside");
        }
        
        private Polygon GetPolygon(List<double[]> polygonBorders)
        {
            GeometryFactory factory = GeometryFactoryHelper.CreateGeometryFactory(GlobalConstants.GCS_WGS_FORMAT);

            return factory.CreatePolygon(polygonBorders.Select(row => new Coordinate(row[0], row[1])).ToArray());
        }
    }
}
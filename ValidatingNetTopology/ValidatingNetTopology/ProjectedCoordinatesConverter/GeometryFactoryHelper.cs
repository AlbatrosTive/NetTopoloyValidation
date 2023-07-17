using NetTopologySuite.Geometries;

namespace ValidatingNetTopology.ProjectedCoordinatesConverter
{
    public static class GeometryFactoryHelper
    {
        public static GeometryFactory CreateGeometryFactory(int srid)
        {
            return new GeometryFactory(new PrecisionModel(), srid);
        } 
    }
}
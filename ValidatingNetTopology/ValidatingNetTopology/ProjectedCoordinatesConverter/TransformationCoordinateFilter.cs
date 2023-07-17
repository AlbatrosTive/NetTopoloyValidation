using NetTopologySuite.Geometries;
using ProjNet.CoordinateSystems.Transformations;

namespace ValidatingNetTopology.ProjectedCoordinatesConverter
{
    public class TransformationCoordinateFilter : ICoordinateFilter
    {
        private ICoordinateTransformation _transformation;

        public TransformationCoordinateFilter(ICoordinateTransformation transformation)
        {
            _transformation = transformation;
        }

        public void Filter(Coordinate coord) =>
            (coord.X, coord.Y) = _transformation.MathTransform.Transform(coord.X, coord.Y);
    }
}
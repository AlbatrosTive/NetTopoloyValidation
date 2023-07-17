using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;
using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;

namespace ValidatingNetTopology.ProjectedCoordinatesConverter
{
    public class CoordinatesConverter
    {
        private const double UTM_LONGITUDE = 6;
        private readonly CoordinateTransformationFactory _factory;

        public CoordinatesConverter(CoordinateTransformationFactory factory)
        {
            _factory = factory;
        }

        public void WgsToUtm(double latitude, double longitude, params Geometry [] geometries)
        {
            ICoordinateTransformation transformation = GetWgs84ToUtm(latitude, longitude);
            
            ChangeCoordinates(transformation, geometries);
        }

        private void ChangeCoordinates(ICoordinateTransformation transformation, params Geometry [] geometries)
        {
            TransformationCoordinateFilter filter = new TransformationCoordinateFilter(transformation);

            foreach (Geometry geometry in geometries)
            {
                geometry.Apply(filter);
            }
        }

        private ICoordinateTransformation GetWgs84ToUtm(double latitude, double longitude)
        {
            CoordinateSystem destSystem = (longitude, latitude).GetUtmCoordinateSystem();

            return _factory.CreateFromCoordinateSystems(
                GeographicCoordinateSystem.WGS84,
                destSystem
            );
        }
    }
}
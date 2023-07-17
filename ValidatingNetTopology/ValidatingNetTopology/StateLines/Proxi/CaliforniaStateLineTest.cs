﻿using System.Collections.Generic;

namespace ValidatingNetTopology.StateLines.Proxi
{
    public class CaliforniaStateLineTest : BaseStateLineTest
    {
        public override List<double[]> StateLineCoordinates => new List<double[]>
        {
            new []{-119.858244,34.752382},
            new []{-120.448511,34.547073},
            new []{-121.496143,35.993001},
            new []{-121.820298,36.415582},
            new []{-121.745432,36.988859},
            new []{-122.269238,37.15242},
            new []{-122.452628,37.706631},
            new []{-123.627184,38.935402},
            new []{-123.848889,39.888138},
            new []{-124.389265,40.436597},
            new []{-124.106584,41.047615},
            new []{-123.998482,41.42069},
            new []{-124.1731,41.936115},
            new []{-120.057647,41.959488},
            new []{-120.046762,39.047568},
            new []{-116.853966,36.707218},
            new []{-114.647987,34.988825},
            new []{-114.717383,33.372513},
            new []{-114.673035,32.773422},
            new []{-116.200148,32.631204},
            new []{-117.031531,32.635886},
            new []{-118.265127,34.03156},
            new []{-118.265127,33.851696},
            new []{-118.481933,33.851696},
            new []{-119.858244,34.752382}
        };

        public override List<double[]> InsideCoordinates => new List<double[]>
        {
            new [] {-123.77636191990406, 41.608327708423296},
            new [] {-121.2523604478131, 41.160721172909696},
            new [] {-122.62908852349908, 39.26856800045371},
            new [] {-120.70166921753872, 39.09070198903636},
            new [] {-121.06879670438832, 37.214354438079006},
            new [] {-120.10508705140812, 35.99871789906644},
            new [] {-117.53519464346097, 35.96158200974967},
            new [] {-116.158466567775, 34.8394156630196},
            new [] {-117.21395809246758, 33.89242034645052},
            new [] {-116.25024843948738, 33.51063693408537}
        };

        public override string StateName => "California";
    }
}
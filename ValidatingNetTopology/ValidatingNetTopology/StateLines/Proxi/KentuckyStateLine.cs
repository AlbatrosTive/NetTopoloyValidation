using System.Collections.Generic;

namespace ValidatingNetTopology.StateLines.Proxi
{
    public class KentuckyStateLine : BaseStateLineTest
    {
        public override List<double[]> StateLineCoordinates => new List<double[]>
        {
            new [] {-83.049888,38.643583},
            new [] {-82.654138,38.014912},
            new [] {-81.87932,36.727306},
            new [] {-87.823766,36.614367},
            new [] {-89.024804,36.543769},
            new [] {-89.125371,36.941949},
            new [] {-88.40841,37.072497},
            new [] {-87.94934,37.472894},
            new [] {-86.389667,37.925727},
            new [] {-85.037587,38.503871},
            new [] {-83.654051,38.562854},
            new [] {-83.494912,38.4897},
            new [] {-83.049888,38.643583}
        };

        public override List<double[]> InsideCoordinates => new List<double[]>
        {
            new [] {-87.87121447907533, 36.99695168369732},
            new [] {-86.65119427230078, 37.65947122856918},
            new [] {-85.40141747511706, 37.98853570717426},
            new [] {-84.12188408752424, 38.1525172013599},
            new [] {-83.02802826062214, 37.417682536083184},
            new [] {-84.14669324049503, 36.91003972773602},
            new [] {-84.90800690735296, 36.84789905927026},
            new [] {-84.62834066238474, 37.7501184361755},
            new [] {-86.04220890083519, 36.897615639347244},
            new [] {-87.28516998958287, 36.86033123775655}
        };

        public override string StateName => "Kentucky";
    }
}
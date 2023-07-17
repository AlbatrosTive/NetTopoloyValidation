using System.Collections.Generic;

namespace ValidatingNetTopology.StateLines
{
    public class PennsylvaniaStateLineTest : BaseStateLineTest
    {
        public override List<double[]> StateLineCoordinates => new List<double[]>
        {
            new []{-80.508954, 41.99161},
            new []{-75.343173, 41.9767},
            new []{-74.941605, 41.464658},
            new []{-73.89476, 40.973872},
            new []{-74.335113, 39.756713},
            new []{-80.499674, 39.728166},
            new []{-80.508954, 41.99161}
        };

        public override List<double[]> InsideCoordinates => new List<double[]>
        {
            new[] {-79.95332447753555, 41.60228780535873},
            new[] {-79.83942835396014, 40.437590258424635},
            new[] {-77.85063625558413, 40.273254321326},
            new[] {-76.14938036420224, 41.09092342775544},
            new[] {-77.7308295026699, 41.45110795059003},
            new[] {-75.61130009544765, 41.271431058518914},
            new[] {-77.68814354248053, 40.875300251986715},
            new[] {-79.66489814869254, 41.66517272693191},
            new[] {-77.18769933837622, 41.84250797954881},
            new[] {-79.38965383643519, 40.93203647364709}
        };

        public override string StateName => "Pennsylvania";
    }
}
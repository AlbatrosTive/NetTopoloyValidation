using System.Collections.Generic;

namespace ValidatingNetTopology.StateLines.Proxi
{
    public class MultipleStateLinesTest : BaseStateLineTest
    {
        public override List<double[]> StateLineCoordinates => new List<double[]>
        {
            // new [] {48.386833, -124.747423},
            // new [] {48.244681, -118.504529},
            // new [] {48.442036, -89.860006},
            // new [] {34.270998, -90.539443},
            // new [] {34.088642, -113.003979},
            // new [] {34.6101, -120.721064},
            // new [] {48.386833, -124.747423}
            
            new [] {-124.747423, 48.386833},
            new [] {-118.504529, 48.244681},
            new [] {-89.860006, 48.442036},
            new [] {-90.539443, 34.270998},
            new [] {-113.003979, 34.088642},
            new [] {-120.721064, 34.6101},
            new [] {-124.747423, 48.386833}
        };

        public override List<double[]> InsideCoordinates => new List<double[]>
        {
            // new [] {38.21026151399588, -120.43705154503422},
            // new [] {41.501075105810024, -112.73069269168741},
            // new [] {41.03394983778384, -102.84915190392817},
            // new [] {38.063616357801024, -105.45937022522307}
            
            new [] {-120.43705154503422, 38.21026151399588},
            new [] {-112.73069269168741, 41.501075105810024},
            new [] {-102.84915190392817, 41.03394983778384},
            new [] {-105.45937022522307, 38.063616357801024}
        };

        public override string StateName => "Multiple States";
    }
}
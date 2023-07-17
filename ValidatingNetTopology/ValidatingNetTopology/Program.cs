using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ValidatingNetTopology.Implementations;
using ValidatingNetTopology.StateLines;
using ValidatingNetTopology.StateLines.Proxi;

namespace ValidatingNetTopology
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CoordinatesTestingService testingService = new CoordinatesTestingService();

            List<BaseStateLineTest> stateLineTests = new List<BaseStateLineTest>()
            {
                new OhioStateLineTest(),
                new PennsylvaniaStateLineTest(),
                new CaliforniaStateLineTest(),
                new TexasStateLineTest(),
                new KentuckyStateLine(),
                new MichiganStateLineTest(),
                new MultipleStateLinesTest()
            };
            
            
            Console.WriteLine("INSIDE POINTS TEST");

            foreach (var stateLineTest in stateLineTests)
            {
                testingService.RunInsidePointsInGcs(stateLineTest.StateLineCoordinates, 
                    stateLineTest.InsideCoordinates, stateLineTest.StateName);
                
                testingService.RunInsidePointsInPcs(stateLineTest.StateLineCoordinates, 
                    stateLineTest.InsideCoordinates, stateLineTest.StateName);
            }

            #region test seperators

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            #endregion
            
            Console.WriteLine("OUTSIDE POINTS TEST");
            
            foreach (var stateLineTest in stateLineTests)
            {
                testingService.RunInsidePointsInGcs(stateLineTest.StateLineCoordinates,
                    stateLineTest.ALotOfCoordinatesInAsia, stateLineTest.StateName);
                
                testingService.RunInsidePointsInPcs(stateLineTest.StateLineCoordinates, 
                    stateLineTest.ALotOfCoordinatesInAsia, stateLineTest.StateName);
            }

        }
    }
}

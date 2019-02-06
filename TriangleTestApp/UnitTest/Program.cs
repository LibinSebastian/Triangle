using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleTestApp;


namespace UnitTest
{
    public class Program
    {
        [TestFixture]
        class TriangleTest
        {
            [Test]
            public void
                GetTriangle_Validation_Inputside1as7andside2as10andside3as5_ReturnsresultValid()
            {
                string output = TriangleSolver.analyzeFunction(7,10,5);
            }
            [Test]
            public void
                GetTriangleValidation_Inputside1as1andside2as10andside3as12_ReturnsresultValid()
            {
                //Arrange
             string output = TriangleSolver.analyzeFunction(1, 10, 12);
                        Console.Write(output);
            }
            [Test]
            public void
                GetTriangleScalene_Inputside1as2andside2as3andside3as4_Returnsresult()
            {
                //Arrange
                
             string output = TriangleSolver.analyzeFunction(2, 3, 4);
                        Console.Write(output);

            }
            [Test]
            public void
                GetTriangleScalene_Inputside1as7andside2as12andside3as23_Returnsresult()
            {
             string output = TriangleSolver.analyzeFunction(7, 12, 23);
                         Console.Write(output);
            }
            [Test]
            public void
                GetTriangleEquilateral_Inputsside1as3andside2as3side3as3_Returnsresult()
            {
             string output = TriangleSolver.analyzeFunction(3, 3, 3);
                         Console.Write(output);
            }
            [Test]
            public void
                GetTriangleEquilateral_Inputsside1as88andside2as88andside3as88_Returnsresult()
            {
             string output = TriangleSolver.analyzeFunction(88, 88, 88);
                          Console.Write(output);
            }
            [Test]
            public void
                GetTriangleIsoceles_Inputsside1as11andside2as11andside3as23_Returnsresult()
            {
                string output = TriangleSolver.analyzeFunction(11, 11, 23);
                Console.Write(output);
            }
            [Test]
            public void
                GetTriangleIsoceles_Inputsside1as66andside2as34andside3as66_Returnsresult()
            {
                string output = TriangleSolver.analyzeFunction(66, 34, 66);
                Console.Write(output);
            }
        }


    }
}

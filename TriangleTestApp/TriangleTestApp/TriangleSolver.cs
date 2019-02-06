using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TriangleTestApp;
using System.Threading.Tasks;

namespace TriangleTestApp
{
     public static class TriangleSolver
    {
        
        public static string analyzeFunction(int fisrtsideOf,int secsideOf,int thsideOf)
        {
            string tTriangle = string.Empty;
            if (!(secsideOf + thsideOf <= fisrtsideOf || fisrtsideOf + secsideOf <= thsideOf || fisrtsideOf + thsideOf <= secsideOf))
            {
                if((fisrtsideOf==secsideOf)||(fisrtsideOf==thsideOf)||(secsideOf==thsideOf))
                {
                    tTriangle = "This is an Isoceles triangle";
                }
                else if((fisrtsideOf==secsideOf)||(thsideOf==fisrtsideOf)||(thsideOf==secsideOf))
                    {
                    tTriangle = "The triangle is an Equilateral triangle";
                    }
                else
                {
                    tTriangle = "The triangle is a Scalene Triangle";
                }
            }
            else
            {
                tTriangle = "False";
            }
            return tTriangle;
        }
    }
}

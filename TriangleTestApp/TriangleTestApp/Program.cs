using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleTestApp;

namespace TriangleTestApp
{
    class Program
    {
        

        public static void Main(string[] args)
        {

            string ch = string.Empty;
            int sA = 0;
            int sB = 0;
            int sC = 0;
            string ans = string.Empty;
            Console.WriteLine("Triangle Test Program");
            do
            {

                Console.WriteLine("1. Enter the dimensions of the triangle");
                Console.WriteLine("2. Exit");
                ch = Console.ReadLine();
            } while (ch != "1" && ch != "2");

            if (!ch.Equals("1") && !ch.Equals("2"))
            {
                Console.WriteLine("Enter a valid input");
            }
            else if (ch.Equals("1"))
            {
                bool isValidated = false;
                do
                {
                    //recieveing the first side of the triangle
                            isValidated = false;
                    Console.WriteLine("Enter the first side of the triangle : ");
                        isValidated = int.TryParse(Console.ReadLine(), out sA);
                    if (!isValidated || sA <= 0)
                    {
                        Console.WriteLine("please enter a valid input for the triangle side \n");
                    }
                } while (!isValidated || sA <= 0);
                do
                {
                    //recieving the second side of the triangle
                            isValidated = false;
                    Console.WriteLine("Enter the second side of the triangle : ");
                        isValidated = int.TryParse(Console.ReadLine(), out sB);
                    if (!isValidated || sB <= 0)
                    {
                        Console.WriteLine("please enter a valid input for the triangle side \n");
                    }
                } while (!isValidated || sB <= 0);
                do
                {
                    //recieving the third side of the triangle
                            isValidated = false;
                    Console.WriteLine("Enter the third side of the triangle : ");
                        isValidated = int.TryParse(Console.ReadLine(), out sC);
                    if (!isValidated || sC <= 0)
                    {
                    Console.WriteLine("please do enter a valid input for the triangle side \n");
                    }
                } while (!isValidated || sC <= 0);
                string tTriangle = string.Empty;
                tTriangle = TriangleSolver.analyzeFunction(sA, sB, sC);
                Console.WriteLine(tTriangle);
            } while (ch != "2") ;
        }   
    
    }
}




                
                        
                
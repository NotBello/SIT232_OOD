// Written by Venujan Malaiyandi for Task 3.3C
// BSCP|CS|61|101


using System;

namespace Polynomials
{
    class TestMyPolynomial
    {
        static void Main(string[] args)
        {
            double[] equation1 = { 3, 2, 1 }; // i.e 1*x^2 + 2*x^1 + 3

            double[] equation2 = { 6, 5, 4 }; // similarly, 4*x^2 + 5*x^1 + 6

            MyPolynomial polynomial1 = new MyPolynomial(equation1);
            MyPolynomial polynomial2 = new MyPolynomial(equation2);

            Console.WriteLine("The two polynomials");

            Console.WriteLine(polynomial1.ToString()); 
            Console.WriteLine(polynomial2.ToString());  

            Console.WriteLine();

            Console.WriteLine("Evaluate if x = 2");
            Console.WriteLine(polynomial1.Evaluate(2));

            Console.WriteLine();

            Console.WriteLine("Add");
            MyPolynomial sum = polynomial1.Add(polynomial2);
            Console.WriteLine(sum.ToString());

            Console.WriteLine();

            Console.WriteLine("Multiply");
            MyPolynomial product = polynomial1.Multiply(polynomial2);
            Console.WriteLine(product.ToString()); 
        }
    }
}

// /*No. In C# it's not necessary to keep the degree of the polynomial
// as an instance variable in the MyPolynomial class.
// The degree can be calculated on the go with the method GetDegree()
// Simailar observation is made for C/C++
// 
// Although this could be considered for compute optimization and to prevent slow access times. 


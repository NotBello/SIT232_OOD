using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomials
{
    public class MyPolynomial
    {   
        private double[] _coeffs;



        // Constructor
        public MyPolynomial(double[] coeffs)
        {
            _coeffs = new double[coeffs.Length];
            for (int i = 0; i < coeffs.Length; i++)
            {
                _coeffs[i] = coeffs[i];
            }

        }

        // Returns the degree of the polynomial.
        public int GetDegree()
        {
            return _coeffs.Length - 1;
        }

        //Returns a string that represents the polynomial as a string formatted to the general form
        public override string ToString()
        {
            List<string> terms = new List<string>();

            for (int i = _coeffs.Length - 1; i >= 0; i--)
            {
                if (_coeffs[i] != 0)
                {
                    if (i == _coeffs.Length - 1)
                    {
                        terms.Add(string.Format("{0}x^{1}", _coeffs[i], i));
                    }
                    else if (i == 1)
                    {
                        terms.Add(string.Format("{0}{1}x", _coeffs[i] > 0 ? " + " : " - ", Math.Abs(_coeffs[i])));
                    }
                    else if (i == 0)
                    {
                        terms.Add(string.Format("{0}{1}", _coeffs[i] > 0 ? " + " : " - ", Math.Abs(_coeffs[i])));
                    }
                    else
                    {
                        terms.Add(string.Format("{0}{1}x^{2}", _coeffs[i] > 0 ? " + " : " - ", Math.Abs(_coeffs[i]), i));
                    }
                }
            }

            return string.Join("", terms);
        }

        // Evaluates the polynomial for the given x by substituting the x into the polynomial expression.
        public double Evaluate(double x)
        {
            double result = 0;

            for (int i = 0; i < _coeffs.Length; i++)
            {
                result += _coeffs[i] * Math.Pow(x, i);
            }

            return result;
        }

        // Adding another polynomial object to .this polynomial object
        public MyPolynomial Add(MyPolynomial another)
        {
            int maxLength = Math.Max(_coeffs.Length, another._coeffs.Length);
            double[] resultCoeffs = new double[maxLength];

            for (int i = 0; i < maxLength; i++)
            {
                double thisCoeff = (i < _coeffs.Length) ? _coeffs[i] : 0;
                double anotherCoeff = (i < another._coeffs.Length) ? another._coeffs[i] : 0;
                resultCoeffs[i] = thisCoeff + anotherCoeff;
            }

            return new MyPolynomial(resultCoeffs);
        }

        // Multiply another polynomial object to .this polynomial object
        public MyPolynomial Multiply(MyPolynomial another)
        {
            int resultDegree = GetDegree() + another.GetDegree();
            double[] resultCoeffs = new double[resultDegree + 1];

            for (int i = 0; i <= GetDegree(); i++)
            {
                for (int j = 0; j <= another.GetDegree(); j++)
                {
                    resultCoeffs[i + j] += _coeffs[i] * another._coeffs[j];
                }
            }

            return new MyPolynomial(resultCoeffs);
        }

    }

}

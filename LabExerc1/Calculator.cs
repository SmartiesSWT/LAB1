using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExerc1
{
    public class Calculator : ICalculator
    {
        public Calculator()
        {
            Accumulator = 0;
        }

        public double Add(double a, double b)
        {
            return Accumulator = a + b;
        }

        public double Subtract(double a, double b)
        {
            return Accumulator = a - b;
        }

        public double Multiply(double a, double b)
        {
            return Accumulator = a * b;
        }

        public double Power(double a, double b)
        {
            return Accumulator = Math.Pow(a, b);
        }

        public double Divide(double a, double b)
        {

            if (b == 0)
            {
                throw new ZeroException();
            }

            return Accumulator = a / b;

        }

        public double Accumulator { get; private set;}

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double a)
        {
            return Accumulator += a;
        }

        public double Subtract(double a)
        {
            return Accumulator -= a;
        }

        public double Multiply(double a)
        {
            return Accumulator *= a;
        }

        public double Power(double a)
        {
            return Accumulator = Math.Pow(Accumulator, a);
        }

        public double Divide(double a)
        {

            if (a == 0)
            {
                throw new ZeroException();
            }

            return Accumulator /= a;
        }
    }
}

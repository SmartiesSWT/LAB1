﻿using System;
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
            if (a < 0)
            {
                a *= -1;

                if (b % 2 == 0)
                {
                    return Accumulator = Math.Pow(a, b);
                }

                return Accumulator = -Math.Pow(a, b);
            }

            return Accumulator = Math.Pow(a, b);
        }

        public double Divide(double a, double b)
        {
            // Hvis man prøver at dele med 0 kastes der en exeption, da dette ikke 
            // er lovligt i den matematiske verden! 
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

            if (Accumulator < 0)
            {
                Accumulator *= -1;

                if (a % 2 == 0)
                {
                    return Accumulator = Math.Pow(Accumulator, a);
                }

                return Accumulator = -Math.Pow(Accumulator, a);
            }

            return Accumulator = Math.Pow(Accumulator, a);

            /*
            if (Accumulator < 0)
            {
                Accumulator *= -1;

                if (a % 2 != 0)
                {
                    return Accumulator = Math.Pow(Accumulator, a);
                }
            }
            return Accumulator = -1* Math.Pow(Accumulator, a);
            */
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

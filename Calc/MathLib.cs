﻿namespace Calc
{
    public class MathLib
    {
        public float Add(float op1, float op2)
        {
            return op1 + op2;
        }

        public float Sub(float op1, float op2)
        {
            return op1 - op2;
        }

        public float Mul(float op1, float op2)
        {
            return op1 * op2;
        }

        public float Div(float op1, float op2)
        {
            return op1 / op2;
        }

        public float Square(float op1)
        {
            throw new NotImplementedException();
        }
    }
}
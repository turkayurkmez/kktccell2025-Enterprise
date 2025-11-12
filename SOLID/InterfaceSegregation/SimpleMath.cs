using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal class SimpleMath : IMath
    {
        public int Add(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Divide(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int x, int y)
        {
            throw new NotImplementedException();
        }
    }

    public class ComplexMath : IMath, IComplexMath
    {
        public int Add(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Divide(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Modulo(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int SquareRoot(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int x, int y)
        {
            throw new NotImplementedException();
        }

        public double Tan(int x)
        {
            throw new NotImplementedException();
        }
    }

    public interface IComplexAlternate: IMath
    {
        int Modulo(int x, int y);

        int SquareRoot(int x, int y);

        double Tan(int x);
    }

    public class ComplexMathInfo : IComplexAlternate
    {
        public int Add(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Divide(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Modulo(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int SquareRoot(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int x, int y)
        {
            throw new NotImplementedException();
        }

        public double Tan(int x)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IMath
    {
        int Add(int x, int y);
        int Subtract(int x, int y);
        int Multiply(int x, int y);

        int Divide(int x, int y);

       

    }

    public interface IComplexMath
    {
        int Modulo(int x, int y);

        int SquareRoot(int x, int y);

        double Tan(int x);
    }
}

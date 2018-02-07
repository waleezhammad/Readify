using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readify.KnockKnock.Business
{
    public class Triangle
    {
        public TriangleType CheckTriangleType(int a, int b, int c)
        {
            if (!CheckTriangleIsValid(a, b, c))
                return TriangleType.Error;

            if (a == b && a == c && b == c)
                return TriangleType.Equilateral;
            if (a == b || a == c || b == c)
                return TriangleType.Isosceles;
            if (a != b && a != c && b != c)
                return TriangleType.Scalene;

            return TriangleType.Error;
        }

        private bool CheckTriangleIsValid(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return false;
            if (((long)a + b) <= c || ((long)b + c) <= a || ((long)a + c) <= b)
                return false;
            return true;
        }
    }

    public enum TriangleType
    {
        Error = 1,
        Equilateral = 2,
        Isosceles = 3,
        Scalene = 4
    }
}

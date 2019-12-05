using System;
using System.Linq;

namespace MyAPI.Services
{
    public class TriangleTypeService
    {
        int _a = 0;
        int _b = 0;
        int _c = 0;
        public TriangleTypeService(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public string GetTriangleType()
        {
            if(_a <= 0 || _b < 0 || _c <= 0)
            {
                return "Error";
            }
            else
            {
                int[] values = { _a, _b, _c };
                int count = values.GroupBy(v => v).Count();
                if( count == 1)
                {
                    return "Equilateral";
                }
                else if(count == 2)
                {
                    return "Isosceles";
                }
                else if(count == 3)
                {
                    return "Scalene";
                }
                else
                {
                    return "Error";
                }
            }
        }
    }
}

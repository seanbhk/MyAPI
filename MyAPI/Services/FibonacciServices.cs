using System;

namespace MyAPI.Services
{
    public class FibonacciServices
    {
        private int _n;
        private int _result = 0;

        public FibonacciServices(int n)
        {
            _n = n;
        }

        public int CalFibonacci()
        {
            if (_n == 1 || _n == 0)
            {
                return _result = _n;
            }
            else
            {
                int a = 0;
                int b = 1;
                int c = 0;
                for (int i = 0; i < _n - 1; i++)
                {
                    a = b + c;
                    c = b;
                    b = a;
                }
                return _result = a;
            }
        }
    }
}

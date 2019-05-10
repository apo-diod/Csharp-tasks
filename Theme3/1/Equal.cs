using System;
namespace Classes_basic_solution
{
    public class Equal
    {
        private double a;

        private double b;

        public double A
        {
            get
            {
                return a;
            }
        }

        public double B
        {
            get
            {
                return b;
            }
        }

        public Equal(double A, double B)
        {
            this.a = A;
            this.b = B;
        }

        public double Func(double x)
        {
            return A * x + B;
        }

        public (bool, double) Root()
        {
            bool v = Math.Abs(A) > 0 ;
            return v ? (true, (-B) / A) : (false, 0);
        }
    }
}

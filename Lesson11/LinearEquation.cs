using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    struct LinearEquation
    {
        double k;
        double b;

        public LinearEquation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            if (k == 0 && b != 0)
                return "Уравнение не имеет решения";
            else if (k == 0 && b == 0)
                return "Уравнение имеет бесконечное множество решений";
            else
                return $"Решение уравнение x={-b / k}";
        }
    }
}

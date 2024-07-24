using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV01
{
    internal class Range_T
    {
        public class Range<T> where T : IComparable<T>
        {
            public T Minimum { get; private set; }
            public T Maximum { get; private set; }
            public Range(T minimum, T maximum)
            {
                if (minimum.CompareTo(maximum) > 0)
                {
                    throw new ArgumentException("Minimum should be less than or equal to Maximum");
                }

                Minimum = minimum;
                Maximum = maximum;
            }
            public bool IsInRange(T value)
            {
                return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
            }

            public T Length()
            {
                
                dynamic min = Minimum;
                dynamic max = Maximum;
                return max - min;
            }
        }

    }
}

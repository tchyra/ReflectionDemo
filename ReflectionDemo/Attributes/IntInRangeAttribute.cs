using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class IntInRangeAttribute : Attribute
    {
        public int Min { get; }
        public int Max { get; }

        public IntInRangeAttribute(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }
}

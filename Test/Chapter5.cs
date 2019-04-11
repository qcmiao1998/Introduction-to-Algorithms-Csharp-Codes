using System;
using Xunit;
using Introduction_to_Algorithms.Chapter_5;

namespace Test
{
    public class Chapter5
    {
        [Theory]
        [InlineData(new[]{ 2.0, 1.0 }, 1.0, 3.0)]
        [InlineData(new[]{10, 6, 1.5, 3, 7.5, 15}, 3.0, 4375.0)]
        public void E5_2(double[] a, double x, double result)
        {
            var r = Example_5_2.PolynomialEvaluation(a, x);
            Assert.Equal(result, r);
        }
    }
}

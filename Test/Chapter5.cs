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

        [Theory]
        [InlineData(new[]{ 2, 0, 0, 4, 4, 3, 5 }, 7, new[]{0, 2, 4})]
        public void E5_4(int[] f, int n, int[] result)
        {
            var r = Example_5_4.Algorithm_Mapping(f, n);
            Assert.Equal(result, r);
        }

        [Theory]
        [InlineData(new[]{ 2, -3, 1.5, -1, 3, -2, -3, 3 }, 3.5)]
        public void E5_8(double[] x, double result)
        {
            var r = Example_5_8.Maximum_Consecutive_Subsequence(x);
            Assert.Equal(result, r);
        }
    }
}

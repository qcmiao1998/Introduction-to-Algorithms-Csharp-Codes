﻿using Xunit;
using Introduction_to_Algorithms.Chapter_6;

namespace Test
{
    public class Chapter6
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 3, 3)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 6, 0)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 2, 2)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 4, 4)]
        public void E6_2_1(int[] x, int z, int result)
        {
            var r = Example_6_2.Binary_Search(x, z);
            Assert.Equal(result, r);
        }

        [Theory]
        [InlineData(new[] { 4, 5, 1, 2, 3 }, 3)]
        [InlineData(new[] { 3, 4, 5, 1, 2 }, 4)]
        public void E6_2_2(int[] x, int result)
        {
            var r = Example_6_2.Cyclic_Binary_Search(x);
            Assert.Equal(result, r);
        }

        [Theory]
        [InlineData(new[] { -4, -2, 1, 4, 6 }, 4)]
        [InlineData(new[] { 0, 2, 5, 11, 12 }, 2)]
        [InlineData(new[] { 0, 3, 5, 11, 12 }, 0)]
        public void E6_2_3(int[] x, int result)
        {
            var r = Example_6_2.Special_Binary_Search(x);
            Assert.Equal(result, r);
        }
    }
}